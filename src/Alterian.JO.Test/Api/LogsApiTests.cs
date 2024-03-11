/*
 * Journey Orchestration API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 4.29.139
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Alterian.JO.Client;
using Alterian.JO.Api;
// uncomment below to import models
//using Alterian.JO.Model;

namespace Alterian.JO.Test.Api
{
    /// <summary>
    ///  Class for testing LogsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LogsApiTests : IDisposable
    {
        private LogsApi instance;

        public LogsApiTests()
        {
            instance = new LogsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LogsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LogsApi
            //Assert.IsType<LogsApi>(instance);
        }

        /// <summary>
        /// Test LogsTypeTargetClientGet
        /// </summary>
        [Fact]
        public void LogsTypeTargetClientGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LogType type = null;
            //TargetEnum target = null;
            //string varClient = null;
            //string searchPhrase = null;
            //string? sequenceNumber = null;
            //string? templateUrl = null;
            //int? limit = null;
            //LogSource? source = null;
            //bool? csv = null;
            //DateTime? startdate = null;
            //DateTime? enddate = null;
            //var response = instance.LogsTypeTargetClientGet(type, target, varClient, searchPhrase, sequenceNumber, templateUrl, limit, source, csv, startdate, enddate);
            //Assert.IsType<LogsApiResponse>(response);
        }

        /// <summary>
        /// Test LogsTypeTargetClientRulenameGet
        /// </summary>
        [Fact]
        public void LogsTypeTargetClientRulenameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LogTypeOrTimeseries type = null;
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //string? searchPhrase = null;
            //string? searchQuery = null;
            //string? sequenceNumber = null;
            //string? tileName = null;
            //string? tileId = null;
            //string? templateUrl = null;
            //int? limit = null;
            //LogSource? source = null;
            //bool? csv = null;
            //DateTime? startdate = null;
            //DateTime? enddate = null;
            //var response = instance.LogsTypeTargetClientRulenameGet(type, target, varClient, rulename, searchPhrase, searchQuery, sequenceNumber, tileName, tileId, templateUrl, limit, source, csv, startdate, enddate);
            //Assert.IsType<LogsApiResponse>(response);
        }
    }
}
