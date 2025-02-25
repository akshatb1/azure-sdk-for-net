// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBLocationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static CosmosDBLocationProperties DeserializeCosmosDBLocationProperties(JsonElement element)
        {
            Optional<bool> supportsAvailabilityZone = default;
            Optional<bool> isResidencyRestricted = default;
            Optional<IReadOnlyList<CosmosDBBackupStorageRedundancy>> backupStorageRedundancies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportsAvailabilityZone"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    supportsAvailabilityZone = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isResidencyRestricted"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isResidencyRestricted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupStorageRedundancies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CosmosDBBackupStorageRedundancy> array = new List<CosmosDBBackupStorageRedundancy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CosmosDBBackupStorageRedundancy(item.GetString()));
                    }
                    backupStorageRedundancies = array;
                    continue;
                }
            }
            return new CosmosDBLocationProperties(Optional.ToNullable(supportsAvailabilityZone), Optional.ToNullable(isResidencyRestricted), Optional.ToList(backupStorageRedundancies));
        }
    }
}
