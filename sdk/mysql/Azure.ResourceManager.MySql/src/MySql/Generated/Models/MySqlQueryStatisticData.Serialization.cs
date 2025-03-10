// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql
{
    public partial class MySqlQueryStatisticData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(QueryId))
            {
                writer.WritePropertyName("queryId");
                writer.WriteStringValue(QueryId);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(AggregationFunction))
            {
                writer.WritePropertyName("aggregationFunction");
                writer.WriteStringValue(AggregationFunction);
            }
            if (Optional.IsCollectionDefined(DatabaseNames))
            {
                writer.WritePropertyName("databaseNames");
                writer.WriteStartArray();
                foreach (var item in DatabaseNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(QueryExecutionCount))
            {
                writer.WritePropertyName("queryExecutionCount");
                writer.WriteNumberValue(QueryExecutionCount.Value);
            }
            if (Optional.IsDefined(MetricName))
            {
                writer.WritePropertyName("metricName");
                writer.WriteStringValue(MetricName);
            }
            if (Optional.IsDefined(MetricDisplayName))
            {
                writer.WritePropertyName("metricDisplayName");
                writer.WriteStringValue(MetricDisplayName);
            }
            if (Optional.IsDefined(MetricValue))
            {
                writer.WritePropertyName("metricValue");
                writer.WriteNumberValue(MetricValue.Value);
            }
            if (Optional.IsDefined(MetricValueUnit))
            {
                writer.WritePropertyName("metricValueUnit");
                writer.WriteStringValue(MetricValueUnit);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MySqlQueryStatisticData DeserializeMySqlQueryStatisticData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> queryId = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> aggregationFunction = default;
            Optional<IList<string>> databaseNames = default;
            Optional<long> queryExecutionCount = default;
            Optional<string> metricName = default;
            Optional<string> metricDisplayName = default;
            Optional<double> metricValue = default;
            Optional<string> metricValueUnit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("queryId"))
                        {
                            queryId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("aggregationFunction"))
                        {
                            aggregationFunction = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            databaseNames = array;
                            continue;
                        }
                        if (property0.NameEquals("queryExecutionCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryExecutionCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("metricName"))
                        {
                            metricName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricDisplayName"))
                        {
                            metricDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricValue"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            metricValue = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("metricValueUnit"))
                        {
                            metricValueUnit = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MySqlQueryStatisticData(id, name, type, systemData.Value, queryId.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), aggregationFunction.Value, Optional.ToList(databaseNames), Optional.ToNullable(queryExecutionCount), metricName.Value, metricDisplayName.Value, Optional.ToNullable(metricValue), metricValueUnit.Value);
        }
    }
}
