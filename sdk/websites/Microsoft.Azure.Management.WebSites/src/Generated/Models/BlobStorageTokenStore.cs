// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the storage of the tokens if blob storage
    /// is used.
    /// </summary>
    public partial class BlobStorageTokenStore
    {
        /// <summary>
        /// Initializes a new instance of the BlobStorageTokenStore class.
        /// </summary>
        public BlobStorageTokenStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobStorageTokenStore class.
        /// </summary>
        /// <param name="sasUrlSettingName">The name of the app setting
        /// containing the SAS URL of the blob storage containing the
        /// tokens.</param>
        public BlobStorageTokenStore(string sasUrlSettingName = default(string))
        {
            SasUrlSettingName = sasUrlSettingName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the app setting containing the SAS URL of
        /// the blob storage containing the tokens.
        /// </summary>
        [JsonProperty(PropertyName = "sasUrlSettingName")]
        public string SasUrlSettingName { get; set; }

    }
}
