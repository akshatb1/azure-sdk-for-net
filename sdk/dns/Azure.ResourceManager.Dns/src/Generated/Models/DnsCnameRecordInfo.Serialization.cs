// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    internal partial class DnsCnameRecordInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Cname))
            {
                writer.WritePropertyName("cname");
                writer.WriteStringValue(Cname);
            }
            writer.WriteEndObject();
        }

        internal static DnsCnameRecordInfo DeserializeDnsCnameRecordInfo(JsonElement element)
        {
            Optional<string> cname = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cname"))
                {
                    cname = property.Value.GetString();
                    continue;
                }
            }
            return new DnsCnameRecordInfo(cname.Value);
        }
    }
}
