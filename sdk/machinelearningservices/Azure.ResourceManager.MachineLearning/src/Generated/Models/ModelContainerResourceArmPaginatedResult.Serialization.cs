// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ModelContainerResourceArmPaginatedResult
    {
        internal static ModelContainerResourceArmPaginatedResult DeserializeModelContainerResourceArmPaginatedResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<MachineLearningModelContainerData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MachineLearningModelContainerData> array = new List<MachineLearningModelContainerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningModelContainerData.DeserializeMachineLearningModelContainerData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ModelContainerResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
