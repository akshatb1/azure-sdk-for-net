// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupFeatureValidationContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FeatureType))
            {
                writer.WritePropertyName("featureType");
                writer.WriteStringValue(FeatureType.Value.ToString());
            }
            if (Optional.IsDefined(FeatureName))
            {
                writer.WritePropertyName("featureName");
                writer.WriteStringValue(FeatureName);
            }
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }
    }
}
