// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class IotHubDataConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(IotHubResourceId))
            {
                writer.WritePropertyName("iotHubResourceId");
                writer.WriteStringValue(IotHubResourceId);
            }
            if (Optional.IsDefined(ConsumerGroup))
            {
                writer.WritePropertyName("consumerGroup");
                writer.WriteStringValue(ConsumerGroup);
            }
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName");
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(MappingRuleName))
            {
                writer.WritePropertyName("mappingRuleName");
                writer.WriteStringValue(MappingRuleName);
            }
            if (Optional.IsDefined(DataFormat))
            {
                writer.WritePropertyName("dataFormat");
                writer.WriteStringValue(DataFormat.Value.ToString());
            }
            if (Optional.IsCollectionDefined(EventSystemProperties))
            {
                writer.WritePropertyName("eventSystemProperties");
                writer.WriteStartArray();
                foreach (var item in EventSystemProperties)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                writer.WritePropertyName("sharedAccessPolicyName");
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IotHubDataConnection DeserializeIotHubDataConnection(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            DataConnectionKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> iotHubResourceId = default;
            Optional<string> consumerGroup = default;
            Optional<string> tableName = default;
            Optional<string> mappingRuleName = default;
            Optional<IotHubDataFormat> dataFormat = default;
            Optional<IList<string>> eventSystemProperties = default;
            Optional<string> sharedAccessPolicyName = default;
            Optional<ResourceProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new DataConnectionKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("iotHubResourceId"))
                        {
                            iotHubResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumerGroup"))
                        {
                            consumerGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mappingRuleName"))
                        {
                            mappingRuleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataFormat"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataFormat = new IotHubDataFormat(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventSystemProperties"))
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
                            eventSystemProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IotHubDataConnection(id, name, type, systemData.Value, Optional.ToNullable(location), kind, iotHubResourceId.Value, consumerGroup.Value, tableName.Value, mappingRuleName.Value, Optional.ToNullable(dataFormat), Optional.ToList(eventSystemProperties), sharedAccessPolicyName.Value, Optional.ToNullable(provisioningState));
        }
    }
}
