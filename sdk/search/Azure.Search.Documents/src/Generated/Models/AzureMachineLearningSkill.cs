// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The AML skill allows you to extend AI enrichment with a custom Azure Machine Learning (AML) model. Once an AML model is trained and deployed, an AML skill integrates it into AI enrichment. </summary>
    public partial class AzureMachineLearningSkill : SearchIndexerSkill
    {

        /// <summary> Initializes a new instance of AzureMachineLearningSkill. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character &apos;#&apos;. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="scoringUri"> (Required for no authentication or key authentication) The scoring URI of the AML service to which the JSON payload will be sent. Only the https URI scheme is allowed. </param>
        /// <param name="authenticationKey"> (Required for key authentication) The key for the AML service. </param>
        /// <param name="rawResourceId"> (Required for token authentication). The Azure Resource Manager resource ID of the AML service. It should be in the format subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.MachineLearningServices/workspaces/{workspace-name}/services/{service_name}. </param>
        /// <param name="timeout"> (Optional) When specified, indicates the timeout for the http client making the API call. </param>
        /// <param name="rawLocation"> (Optional for token authentication). The region the AML service is deployed in. </param>
        /// <param name="degreeOfParallelism"> (Optional) When specified, indicates the number of calls the indexer will make in parallel to the endpoint you have provided. You can decrease this value if your endpoint is failing under too high of a request load, or raise it if your endpoint is able to accept more requests and you would like an increase in the performance of the indexer. If not set, a default value of 5 is used. The degreeOfParallelism can be set to a maximum of 10 and a minimum of 1. </param>
        internal AzureMachineLearningSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, Uri scoringUri, string authenticationKey, string rawResourceId, TimeSpan? timeout, string rawLocation, int? degreeOfParallelism) : base(oDataType, name, description, context, inputs, outputs)
        {
            ScoringUri = scoringUri;
            AuthenticationKey = authenticationKey;
            RawResourceId = rawResourceId;
            Timeout = timeout;
            RawLocation = rawLocation;
            DegreeOfParallelism = degreeOfParallelism;
            ODataType = oDataType ?? "#Microsoft.Skills.Custom.AmlSkill";
        }
        /// <summary> (Optional) When specified, indicates the timeout for the http client making the API call. </summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary> (Optional) When specified, indicates the number of calls the indexer will make in parallel to the endpoint you have provided. You can decrease this value if your endpoint is failing under too high of a request load, or raise it if your endpoint is able to accept more requests and you would like an increase in the performance of the indexer. If not set, a default value of 5 is used. The degreeOfParallelism can be set to a maximum of 10 and a minimum of 1. </summary>
        public int? DegreeOfParallelism { get; set; }
    }
}
