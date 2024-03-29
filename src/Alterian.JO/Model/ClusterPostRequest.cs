/*
 * Journey Orchestration API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 4.29.139
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Alterian.JO.Client.OpenAPIDateConverter;

namespace Alterian.JO.Model
{
    /// <summary>
    /// ClusterPostRequest
    /// </summary>
    [DataContract(Name = "_cluster_post_request")]
    public partial class ClusterPostRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterPostRequest" /> class.
        /// </summary>
        /// <param name="bootstrapVersion">When adding a new node, pass this as 0.</param>
        /// <param name="host">The internal ip address of the new instance.</param>
        /// <param name="publicIp">The public ip of the new instance.</param>
        /// <param name="varVersion">The version number of the new instance.</param>
        public ClusterPostRequest(int bootstrapVersion = default(int), string host = default(string), string publicIp = default(string), string varVersion = default(string))
        {
            this.BootstrapVersion = bootstrapVersion;
            this.Host = host;
            this.PublicIp = publicIp;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// When adding a new node, pass this as 0
        /// </summary>
        /// <value>When adding a new node, pass this as 0</value>
        /// <example>0</example>
        [DataMember(Name = "bootstrapVersion", EmitDefaultValue = false)]
        public int BootstrapVersion { get; set; }

        /// <summary>
        /// The internal ip address of the new instance
        /// </summary>
        /// <value>The internal ip address of the new instance</value>
        /// <example>172.10.11.12</example>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// The public ip of the new instance
        /// </summary>
        /// <value>The public ip of the new instance</value>
        /// <example>1.1.1.1</example>
        [DataMember(Name = "public_ip", EmitDefaultValue = false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// The version number of the new instance
        /// </summary>
        /// <value>The version number of the new instance</value>
        /// <example>4.20.123</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClusterPostRequest {\n");
            sb.Append("  BootstrapVersion: ").Append(BootstrapVersion).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  PublicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
