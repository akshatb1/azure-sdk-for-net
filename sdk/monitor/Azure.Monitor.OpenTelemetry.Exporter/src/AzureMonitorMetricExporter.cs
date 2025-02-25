﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Monitor.OpenTelemetry.Exporter.Internals;
using Azure.Monitor.OpenTelemetry.Exporter.Internals.PersistentStorage;
using OpenTelemetry;
using OpenTelemetry.Metrics;

namespace Azure.Monitor.OpenTelemetry.Exporter
{
    internal class AzureMonitorMetricExporter : BaseExporter<Metric>
    {
        private readonly ITransmitter _transmitter;
        private readonly string _instrumentationKey;
        private readonly ResourceParser _resourceParser;
        private readonly AzureMonitorPersistentStorage _persistentStorage;

        public AzureMonitorMetricExporter(AzureMonitorExporterOptions options, TokenCredential credential = null) : this(new AzureMonitorTransmitter(options, credential))
        {
        }

        internal AzureMonitorMetricExporter(ITransmitter transmitter)
        {
            _transmitter = transmitter;
            _instrumentationKey = transmitter.InstrumentationKey;
            _resourceParser = new ResourceParser();

            if (transmitter is AzureMonitorTransmitter azureMonitorTransmitter && azureMonitorTransmitter._fileBlobProvider != null)
            {
                _persistentStorage = new AzureMonitorPersistentStorage(transmitter);
            }
        }

        /// <inheritdoc/>
        public override ExportResult Export(in Batch<Metric> batch)
        {
            _persistentStorage?.StartExporterTimer();

            // Prevent Azure Monitor's HTTP operations from being instrumented.
            using var scope = SuppressInstrumentationScope.Begin();

            try
            {
                var exportResult = ExportResult.Success;
                // In case of metrics, export is called
                // even if there are no items in batch
                if (batch.Count > 0)
                {
                    if (_resourceParser.RoleName is null && _resourceParser.RoleInstance is null)
                    {
                        var resource = ParentProvider.GetResource();
                        _resourceParser.UpdateRoleNameAndInstance(resource);
                    }
                    var telemetryItems = MetricHelper.OtelToAzureMonitorMetrics(batch, _resourceParser.RoleName, _resourceParser.RoleInstance, _instrumentationKey);
                    exportResult = _transmitter.TrackAsync(telemetryItems, false, CancellationToken.None).EnsureCompleted();
                }

                _persistentStorage?.StopExporterTimerAndTransmitFromStorage();

                return exportResult;
            }
            catch (Exception ex)
            {
                AzureMonitorExporterEventSource.Log.WriteError("FailedToExport", ex);
                return ExportResult.Failure;
            }
        }
    }
}
