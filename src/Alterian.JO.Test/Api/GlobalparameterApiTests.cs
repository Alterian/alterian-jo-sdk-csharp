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
    ///  Class for testing GlobalparameterApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GlobalparameterApiTests : IDisposable
    {
        private GlobalparameterApi instance;

        public GlobalparameterApiTests()
        {
            instance = new GlobalparameterApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GlobalparameterApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GlobalparameterApi
            //Assert.IsType<GlobalparameterApi>(instance);
        }

        /// <summary>
        /// Test DownloadGlobalparameterClientParamnameGet
        /// </summary>
        [Fact]
        public void DownloadGlobalparameterClientParamnameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //string paramname = null;
            //instance.DownloadGlobalparameterClientParamnameGet(varClient, paramname);
        }

        /// <summary>
        /// Test GlobalparameterClientGet
        /// </summary>
        [Fact]
        public void GlobalparameterClientGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //int? from = null;
            //int? to = null;
            //string? sortProperty = null;
            //string? sortDescending = null;
            //string? searchText = null;
            //List<string>? iClients = null;
            //var response = instance.GlobalparameterClientGet(varClient, from, to, sortProperty, sortDescending, searchText, iClients);
            //Assert.IsType<ParameterList>(response);
        }

        /// <summary>
        /// Test GlobalparameterClientParamnameCopyPost
        /// </summary>
        [Fact]
        public void GlobalparameterClientParamnameCopyPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //string paramname = null;
            //ParameterCopyDetails parameterCopyDetails = null;
            //var response = instance.GlobalparameterClientParamnameCopyPost(varClient, paramname, parameterCopyDetails);
            //Assert.IsType<ParameterApiResponse>(response);
        }

        /// <summary>
        /// Test GlobalparameterClientParamnameCopyPut
        /// </summary>
        [Fact]
        public void GlobalparameterClientParamnameCopyPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //string paramname = null;
            //ParameterCopyDetails parameterCopyDetails = null;
            //var response = instance.GlobalparameterClientParamnameCopyPut(varClient, paramname, parameterCopyDetails);
            //Assert.IsType<ParameterApiResponse>(response);
        }

        /// <summary>
        /// Test GlobalparameterClientParamnameDelete
        /// </summary>
        [Fact]
        public void GlobalparameterClientParamnameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //string paramname = null;
            //var response = instance.GlobalparameterClientParamnameDelete(varClient, paramname);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test GlobalparameterClientParamnameGet
        /// </summary>
        [Fact]
        public void GlobalparameterClientParamnameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //string paramname = null;
            //var response = instance.GlobalparameterClientParamnameGet(varClient, paramname);
            //Assert.IsType<ParameterList>(response);
        }

        /// <summary>
        /// Test GlobalparameterClientParamnamePut
        /// </summary>
        [Fact]
        public void GlobalparameterClientParamnamePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string varClient = null;
            //string paramname = null;
            //Parameter varParameter = null;
            //var response = instance.GlobalparameterClientParamnamePut(varClient, paramname, varParameter);
            //Assert.IsType<ParameterApiResponse>(response);
        }

        /// <summary>
        /// Test GlobalparameterGet
        /// </summary>
        [Fact]
        public void GlobalparameterGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? from = null;
            //int? to = null;
            //string? sortProperty = null;
            //string? sortDescending = null;
            //string? searchText = null;
            //List<string>? iClients = null;
            //var response = instance.GlobalparameterGet(from, to, sortProperty, sortDescending, searchText, iClients);
            //Assert.IsType<ParameterList>(response);
        }

        /// <summary>
        /// Test GlobalparameterPost
        /// </summary>
        [Fact]
        public void GlobalparameterPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Parameter? varParameter = null;
            //var response = instance.GlobalparameterPost(varParameter);
            //Assert.IsType<ParameterApiResponse>(response);
        }
    }
}
