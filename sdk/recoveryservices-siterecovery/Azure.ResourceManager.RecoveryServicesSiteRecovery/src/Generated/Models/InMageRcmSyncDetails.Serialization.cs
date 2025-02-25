// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmSyncDetails
    {
        internal static InMageRcmSyncDetails DeserializeInMageRcmSyncDetails(JsonElement element)
        {
            Optional<DiskReplicationProgressHealth> progressHealth = default;
            Optional<long> transferredBytes = default;
            Optional<long> last15MinutesTransferredBytes = default;
            Optional<string> lastDataTransferTimeUtc = default;
            Optional<long> processedBytes = default;
            Optional<string> startTime = default;
            Optional<string> lastRefreshTime = default;
            Optional<int> progressPercentage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("progressHealth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    progressHealth = new DiskReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("transferredBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    transferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("last15MinutesTransferredBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    last15MinutesTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastDataTransferTimeUtc"))
                {
                    lastDataTransferTimeUtc = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processedBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    processedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRefreshTime"))
                {
                    lastRefreshTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("progressPercentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    progressPercentage = property.Value.GetInt32();
                    continue;
                }
            }
            return new InMageRcmSyncDetails(Optional.ToNullable(progressHealth), Optional.ToNullable(transferredBytes), Optional.ToNullable(last15MinutesTransferredBytes), lastDataTransferTimeUtc.Value, Optional.ToNullable(processedBytes), startTime.Value, lastRefreshTime.Value, Optional.ToNullable(progressPercentage));
        }
    }
}
