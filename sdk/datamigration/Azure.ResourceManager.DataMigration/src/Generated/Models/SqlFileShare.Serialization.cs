// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SqlFileShare : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            writer.WriteEndObject();
        }

        internal static SqlFileShare DeserializeSqlFileShare(JsonElement element)
        {
            Optional<string> path = default;
            Optional<string> username = default;
            Optional<string> password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
            }
            return new SqlFileShare(path.Value, username.Value, password.Value);
        }
    }
}
