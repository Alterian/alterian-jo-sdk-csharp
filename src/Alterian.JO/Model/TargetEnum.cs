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
    /// the target (dev/test/prod)
    /// </summary>
    /// <value>the target (dev/test/prod)</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TargetEnum
    {
        /// <summary>
        /// Enum Dev for value: dev
        /// </summary>
        [EnumMember(Value = "dev")]
        Dev = 1,

        /// <summary>
        /// Enum Test for value: test
        /// </summary>
        [EnumMember(Value = "test")]
        Test = 2,

        /// <summary>
        /// Enum Prod for value: prod
        /// </summary>
        [EnumMember(Value = "prod")]
        Prod = 3
    }

}
