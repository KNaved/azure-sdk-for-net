// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Analysis.Models
{
    using System.Linq;

    /// <summary>
    /// Array of administrator user identities
    /// </summary>
    public partial class ServerAdministrators
    {
        /// <summary>
        /// Initializes a new instance of the ServerAdministrators class.
        /// </summary>
        public ServerAdministrators() { }

        /// <summary>
        /// Initializes a new instance of the ServerAdministrators class.
        /// </summary>
        /// <param name="members">Collection of administrator user
        /// identities</param>
        public ServerAdministrators(System.Collections.Generic.IList<string> members = default(System.Collections.Generic.IList<string>))
        {
            Members = members;
        }

        /// <summary>
        /// Gets or sets collection of administrator user identities
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "members")]
        public System.Collections.Generic.IList<string> Members { get; set; }

    }
}
