// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Search.Models
{
    using System.Linq;

    /// <summary>
    /// Describes an API key for a given Azure Cognitive Search service that has
    /// permissions for query operations only.
    /// </summary>
    public partial class QueryKey
    {
        /// <summary>
        /// Initializes a new instance of the QueryKey class.
        /// </summary>
        public QueryKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryKey class.
        /// </summary>

        /// <param name="name">The name of the query API key; may be empty.
        /// </param>

        /// <param name="key">The value of the query API key.
        /// </param>
        public QueryKey(string name = default(string), string key = default(string))

        {
            this.Name = name;
            this.Key = key;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the name of the query API key; may be empty.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets the value of the query API key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "key")]
        public string Key {get; private set; }
    }
}