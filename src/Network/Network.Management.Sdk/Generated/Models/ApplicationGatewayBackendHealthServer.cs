// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Application gateway backendhealth http settings.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthServer
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendHealthServer class.
        /// </summary>
        public ApplicationGatewayBackendHealthServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendHealthServer class.
        /// </summary>

        /// <param name="address">IP address or FQDN of backend server.
        /// </param>

        /// <param name="ipConfiguration">Reference to IP configuration of backend server.
        /// </param>

        /// <param name="health">Health of backend server.
        /// Possible values include: &#39;Unknown&#39;, &#39;Up&#39;, &#39;Down&#39;, &#39;Partial&#39;, &#39;Draining&#39;</param>

        /// <param name="healthProbeLog">Health Probe Log.
        /// </param>
        public ApplicationGatewayBackendHealthServer(string address = default(string), NetworkInterfaceIPConfiguration ipConfiguration = default(NetworkInterfaceIPConfiguration), string health = default(string), string healthProbeLog = default(string))

        {
            this.Address = address;
            this.IPConfiguration = ipConfiguration;
            this.Health = health;
            this.HealthProbeLog = healthProbeLog;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets iP address or FQDN of backend server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "address")]
        public string Address {get; set; }

        /// <summary>
        /// Gets or sets reference to IP configuration of backend server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipConfiguration")]
        public NetworkInterfaceIPConfiguration IPConfiguration {get; set; }

        /// <summary>
        /// Gets or sets health of backend server. Possible values include: &#39;Unknown&#39;, &#39;Up&#39;, &#39;Down&#39;, &#39;Partial&#39;, &#39;Draining&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "health")]
        public string Health {get; set; }

        /// <summary>
        /// Gets or sets health Probe Log.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "healthProbeLog")]
        public string HealthProbeLog {get; set; }
    }
}