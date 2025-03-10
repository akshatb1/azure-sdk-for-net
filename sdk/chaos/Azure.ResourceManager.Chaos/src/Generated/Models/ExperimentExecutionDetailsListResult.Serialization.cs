// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Models
{
    internal partial class ExperimentExecutionDetailsListResult
    {
        internal static ExperimentExecutionDetailsListResult DeserializeExperimentExecutionDetailsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExperimentExecutionDetailData>> value = default;
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
                    List<ExperimentExecutionDetailData> array = new List<ExperimentExecutionDetailData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExperimentExecutionDetailData.DeserializeExperimentExecutionDetailData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextLink = null;
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ExperimentExecutionDetailsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
