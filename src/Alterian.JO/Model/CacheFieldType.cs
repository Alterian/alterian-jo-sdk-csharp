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
    /// Cassandra Data Types
    /// </summary>
    /// <value>Cassandra Data Types</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CacheFieldType
    {
        /// <summary>
        /// Enum Ascii for value: ascii
        /// </summary>
        [EnumMember(Value = "ascii")]
        Ascii = 1,

        /// <summary>
        /// Enum Bigint for value: bigint
        /// </summary>
        [EnumMember(Value = "bigint")]
        Bigint = 2,

        /// <summary>
        /// Enum Blob for value: blob
        /// </summary>
        [EnumMember(Value = "blob")]
        Blob = 3,

        /// <summary>
        /// Enum Boolean for value: boolean
        /// </summary>
        [EnumMember(Value = "boolean")]
        Boolean = 4,

        /// <summary>
        /// Enum Counter for value: counter
        /// </summary>
        [EnumMember(Value = "counter")]
        Counter = 5,

        /// <summary>
        /// Enum Date for value: date
        /// </summary>
        [EnumMember(Value = "date")]
        Date = 6,

        /// <summary>
        /// Enum Double for value: double
        /// </summary>
        [EnumMember(Value = "double")]
        Double = 7,

        /// <summary>
        /// Enum Duration for value: duration
        /// </summary>
        [EnumMember(Value = "duration")]
        Duration = 8,

        /// <summary>
        /// Enum Float for value: float
        /// </summary>
        [EnumMember(Value = "float")]
        Float = 9,

        /// <summary>
        /// Enum Inet for value: inet
        /// </summary>
        [EnumMember(Value = "inet")]
        Inet = 10,

        /// <summary>
        /// Enum Int for value: int
        /// </summary>
        [EnumMember(Value = "int")]
        Int = 11,

        /// <summary>
        /// Enum Smallint for value: smallint
        /// </summary>
        [EnumMember(Value = "smallint")]
        Smallint = 12,

        /// <summary>
        /// Enum Test for value: test
        /// </summary>
        [EnumMember(Value = "test")]
        Test = 13,

        /// <summary>
        /// Enum Time for value: time
        /// </summary>
        [EnumMember(Value = "time")]
        Time = 14,

        /// <summary>
        /// Enum Timestamp for value: timestamp
        /// </summary>
        [EnumMember(Value = "timestamp")]
        Timestamp = 15,

        /// <summary>
        /// Enum Timeuuid for value: timeuuid
        /// </summary>
        [EnumMember(Value = "timeuuid")]
        Timeuuid = 16,

        /// <summary>
        /// Enum Tinyint for value: tinyint
        /// </summary>
        [EnumMember(Value = "tinyint")]
        Tinyint = 17,

        /// <summary>
        /// Enum Uuid for value: uuid
        /// </summary>
        [EnumMember(Value = "uuid")]
        Uuid = 18,

        /// <summary>
        /// Enum Varchar for value: varchar
        /// </summary>
        [EnumMember(Value = "varchar")]
        Varchar = 19,

        /// <summary>
        /// Enum Varint for value: varint
        /// </summary>
        [EnumMember(Value = "varint")]
        Varint = 20,

        /// <summary>
        /// Enum Long for value: long
        /// </summary>
        [EnumMember(Value = "long")]
        Long = 21,

        /// <summary>
        /// Enum Text for value: text
        /// </summary>
        [EnumMember(Value = "text")]
        Text = 22
    }

}