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
    ///  Class for testing RecordingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RecordingApiTests : IDisposable
    {
        private RecordingApi instance;

        public RecordingApiTests()
        {
            instance = new RecordingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RecordingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RecordingApi
            //Assert.IsType<RecordingApi>(instance);
        }

        /// <summary>
        /// Test RecordingClientDelete
        /// </summary>
        [Fact]
        public void RecordingClientDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //instance.RecordingClientDelete(varClient);
        }

        /// <summary>
        /// Test RecordingClientGet
        /// </summary>
        [Fact]
        public void RecordingClientGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //int? from = null;
            //int? to = null;
            //instance.RecordingClientGet(varClient, from, to);
        }

        /// <summary>
        /// Test RecordingClientTargetDelete
        /// </summary>
        [Fact]
        public void RecordingClientTargetDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //TargetEnum target = null;
            //instance.RecordingClientTargetDelete(varClient, target);
        }

        /// <summary>
        /// Test RecordingClientTargetGet
        /// </summary>
        [Fact]
        public void RecordingClientTargetGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //TargetEnum target = null;
            //int? from = null;
            //int? to = null;
            //instance.RecordingClientTargetGet(varClient, target, from, to);
        }

        /// <summary>
        /// Test RecordingClientTargetNameDelete
        /// </summary>
        [Fact]
        public void RecordingClientTargetNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //TargetEnum target = null;
            //string name = null;
            //instance.RecordingClientTargetNameDelete(varClient, target, name);
        }

        /// <summary>
        /// Test RecordingClientTargetNameEventsGet
        /// </summary>
        [Fact]
        public void RecordingClientTargetNameEventsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //TargetEnum target = null;
            //string name = null;
            //int? from = null;
            //int? to = null;
            //instance.RecordingClientTargetNameEventsGet(varClient, target, name, from, to);
        }

        /// <summary>
        /// Test RecordingClientTargetNameGet
        /// </summary>
        [Fact]
        public void RecordingClientTargetNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //TargetEnum target = null;
            //string name = null;
            //bool? analysis = null;
            //bool? force = null;
            //instance.RecordingClientTargetNameGet(varClient, target, name, analysis, force);
        }

        /// <summary>
        /// Test RecordingClientTargetNamePut
        /// </summary>
        [Fact]
        public void RecordingClientTargetNamePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //TargetEnum target = null;
            //string name = null;
            //string? body = null;
            //var response = instance.RecordingClientTargetNamePut(varClient, target, name, body);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test RecordingClientTargetPost
        /// </summary>
        [Fact]
        public void RecordingClientTargetPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //TargetEnum target = null;
            //string? action = null;
            //string? body = null;
            //instance.RecordingClientTargetPost(varClient, target, action, body);
        }

        /// <summary>
        /// Test RecordingGet
        /// </summary>
        [Fact]
        public void RecordingGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? from = null;
            //int? to = null;
            //instance.RecordingGet(from, to);
        }
    }
}
