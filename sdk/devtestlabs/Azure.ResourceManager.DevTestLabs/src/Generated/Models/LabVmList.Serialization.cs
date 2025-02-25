// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class LabVmList
    {
        internal static LabVmList DeserializeLabVmList(JsonElement element)
        {
            Optional<IReadOnlyList<DevTestLabVmData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DevTestLabVmData> array = new List<DevTestLabVmData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabVmData.DeserializeDevTestLabVmData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LabVmList(Optional.ToList(value), nextLink.Value);
        }
    }
}
