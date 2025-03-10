// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class ApiPortalResourceList
    {
        internal static ApiPortalResourceList DeserializeApiPortalResourceList(JsonElement element)
        {
            Optional<IReadOnlyList<AppPlatformApiPortalData>> value = default;
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
                    List<AppPlatformApiPortalData> array = new List<AppPlatformApiPortalData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformApiPortalData.DeserializeAppPlatformApiPortalData(item));
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
            return new ApiPortalResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
