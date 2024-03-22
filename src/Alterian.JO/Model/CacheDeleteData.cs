/*
 * Journey Orchestration API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 4.30.49
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
    /// CacheDeleteData
    /// </summary>
    [DataContract(Name = "CacheDeleteData")]
    public partial class CacheDeleteData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheDeleteData" /> class.
        /// </summary>
        /// <param name="columnsDropped">columnsDropped.</param>
        /// <param name="tablesDropped">tablesDropped.</param>
        public CacheDeleteData(List<CacheColumnListing> columnsDropped = default(List<CacheColumnListing>), List<CacheTableListing> tablesDropped = default(List<CacheTableListing>))
        {
            this.ColumnsDropped = columnsDropped;
            this.TablesDropped = tablesDropped;
        }

        /// <summary>
        /// Gets or Sets ColumnsDropped
        /// </summary>
        [DataMember(Name = "columnsDropped", EmitDefaultValue = false)]
        public List<CacheColumnListing> ColumnsDropped { get; set; }

        /// <summary>
        /// Gets or Sets TablesDropped
        /// </summary>
        [DataMember(Name = "tablesDropped", EmitDefaultValue = false)]
        public List<CacheTableListing> TablesDropped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CacheDeleteData {\n");
            sb.Append("  ColumnsDropped: ").Append(ColumnsDropped).Append("\n");
            sb.Append("  TablesDropped: ").Append(TablesDropped).Append("\n");
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
