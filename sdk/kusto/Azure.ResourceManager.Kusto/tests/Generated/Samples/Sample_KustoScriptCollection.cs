// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Kusto
{
    public partial class Sample_KustoScriptCollection
    {
        // KustoScriptsList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_KustoScriptsList()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoScriptsListByDatabase.json
            // this example is just showing the usage of "Scripts_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "Kustodatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoScriptResource
            KustoScriptCollection collection = kustoDatabase.GetKustoScripts();

            // invoke the operation and iterate over the result
            await foreach (KustoScriptResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KustoScriptData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // KustoScriptsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KustoScriptsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoScriptsGet.json
            // this example is just showing the usage of "Scripts_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "Kustodatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoScriptResource
            KustoScriptCollection collection = kustoDatabase.GetKustoScripts();

            // invoke the operation
            string scriptName = "kustoScript";
            KustoScriptResource result = await collection.GetAsync(scriptName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoScriptsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_KustoScriptsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoScriptsGet.json
            // this example is just showing the usage of "Scripts_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "Kustodatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoScriptResource
            KustoScriptCollection collection = kustoDatabase.GetKustoScripts();

            // invoke the operation
            string scriptName = "kustoScript";
            bool result = await collection.ExistsAsync(scriptName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // KustoScriptsCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_KustoScriptsCreateOrUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2022-07-07/examples/KustoScriptsCreateOrUpdate.json
            // this example is just showing the usage of "Scripts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this KustoDatabaseResource created on azure
            // for more information of creating KustoDatabaseResource, please refer to the document of KustoDatabaseResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier kustoDatabaseResourceId = KustoDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            KustoDatabaseResource kustoDatabase = client.GetKustoDatabaseResource(kustoDatabaseResourceId);

            // get the collection of this KustoScriptResource
            KustoScriptCollection collection = kustoDatabase.GetKustoScripts();

            // invoke the operation
            string scriptName = "kustoScript";
            KustoScriptData data = new KustoScriptData()
            {
                ScriptUri = new Uri("https://mysa.blob.core.windows.net/container/script.txt"),
                ScriptUriSasToken = "?sv=2019-02-02&st=2019-04-29T22%3A18%3A26Z&se=2019-04-30T02%3A23%3A26Z&sr=b&sp=rw&sip=168.1.5.60-168.1.5.70&spr=https&sig=********************************",
                ForceUpdateTag = "2bcf3c21-ffd1-4444-b9dd-e52e00ee53fe",
                ShouldContinueOnErrors = true,
            };
            ArmOperation<KustoScriptResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scriptName, data);
            KustoScriptResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
