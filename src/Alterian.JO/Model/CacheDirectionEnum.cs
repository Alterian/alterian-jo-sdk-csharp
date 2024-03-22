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
    /// The direction of the clustering column
    /// </summary>
    /// <value>The direction of the clustering column</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CacheDirectionEnum
    {
        /// <summary>
        /// Enum READ for value: READ
        /// </summary>
        [EnumMember(Value = "READ")]
        READ = 1,

        /// <summary>
        /// Enum WRITE for value: WRITE
        /// </summary>
        [EnumMember(Value = "WRITE")]
        WRITE = 2,

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 3
    }

}
