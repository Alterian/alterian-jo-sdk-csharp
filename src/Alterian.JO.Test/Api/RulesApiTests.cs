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
    ///  Class for testing RulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RulesApiTests : IDisposable
    {
        private RulesApi instance;

        public RulesApiTests()
        {
            instance = new RulesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RulesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RulesApi
            //Assert.IsType<RulesApi>(instance);
        }

        /// <summary>
        /// Test DownloadRuleTargetClientRulenameGet
        /// </summary>
        [Fact]
        public void DownloadRuleTargetClientRulenameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //instance.DownloadRuleTargetClientRulenameGet(target, varClient, rulename);
        }

        /// <summary>
        /// Test RuleGet
        /// </summary>
        [Fact]
        public void RuleGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? from = null;
            //int? to = null;
            //string? sortProperty = null;
            //string? sortDescending = null;
            //string? createdRuleUrl = null;
            //HealthScoreTimeFrame? healthScore = null;
            //bool? includeStatistics = null;
            //string? searchText = null;
            //string? parameterName = null;
            //string? parameterValue = null;
            //string? templateFilter = null;
            //bool? includePublic = null;
            //bool? checkTemplateLatestVersion = null;
            //List<string>? iClients = null;
            //var response = instance.RuleGet(from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
            //Assert.IsType<RuleList>(response);
        }

        /// <summary>
        /// Test RuleTargetClientDelete
        /// </summary>
        [Fact]
        public void RuleTargetClientDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //var response = instance.RuleTargetClientDelete(target, varClient);
            //Assert.IsType<RuleList>(response);
        }

        /// <summary>
        /// Test RuleTargetClientDesignerPut
        /// </summary>
        [Fact]
        public void RuleTargetClientDesignerPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //RuleData? ruleData = null;
            //var response = instance.RuleTargetClientDesignerPut(target, varClient, ruleData);
            //Assert.IsType<RuleDesignerResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientGet
        /// </summary>
        [Fact]
        public void RuleTargetClientGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //int? from = null;
            //int? to = null;
            //string? sortProperty = null;
            //string? sortDescending = null;
            //string? createdRuleUrl = null;
            //HealthScoreTimeFrame? healthScore = null;
            //bool? includeStatistics = null;
            //string? searchText = null;
            //string? parameterName = null;
            //string? parameterValue = null;
            //string? templateFilter = null;
            //bool? includePublic = null;
            //bool? checkTemplateLatestVersion = null;
            //List<string>? iClients = null;
            //var response = instance.RuleTargetClientGet(target, varClient, from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
            //Assert.IsType<RuleList>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameAutoloaderGet
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameAutoloaderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenameAutoloaderGet(target, varClient, rulename);
            //Assert.IsType<RuleList>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameAutoloaderPost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameAutoloaderPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //Object? body = null;
            //var response = instance.RuleTargetClientRulenameAutoloaderPost(target, varClient, rulename, body);
            //Assert.IsType<RuleAndStateResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameCopytoPost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameCopytoPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //TargetEnum? destinationtarget = null;
            //DestinationTarget? destinationTarget = null;
            //var response = instance.RuleTargetClientRulenameCopytoPost(target, varClient, rulename, destinationtarget, destinationTarget);
            //Assert.IsType<RuleAndStateResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameDatagridDataGridNameGet
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameDatagridDataGridNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //string dataGridName = null;
            //CsvEnum? format = null;
            //var response = instance.RuleTargetClientRulenameDatagridDataGridNameGet(target, varClient, rulename, dataGridName, format);
            //Assert.IsType<DataGridApiResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameDatagridDataGridNamePost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameDatagridDataGridNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //string dataGridName = null;
            //List<DataGridDetails>? dataGridDetails = null;
            //var response = instance.RuleTargetClientRulenameDatagridDataGridNamePost(target, varClient, rulename, dataGridName, dataGridDetails);
            //Assert.IsType<RuleAndStateResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameDatagridDataGridNameRowsPost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameDatagridDataGridNameRowsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //string dataGridName = null;
            //DataGridRow? dataGridRow = null;
            //var response = instance.RuleTargetClientRulenameDatagridDataGridNameRowsPost(target, varClient, rulename, dataGridName, dataGridRow);
            //Assert.IsType<RuleAndStateResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameDelete
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenameDelete(target, varClient, rulename);
            //Assert.IsType<RuleList>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameDesignerGet
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameDesignerGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenameDesignerGet(target, varClient, rulename);
            //Assert.IsType<RuleList>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameDesignerPost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameDesignerPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //bool? validate = null;
            //RuleData? ruleData = null;
            //var response = instance.RuleTargetClientRulenameDesignerPost(target, varClient, rulename, validate, ruleData);
            //Assert.IsType<RuleDesignerResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameDesignerPut
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameDesignerPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //bool? validate = null;
            //bool? download = null;
            //string? body = null;
            //var response = instance.RuleTargetClientRulenameDesignerPut(target, varClient, rulename, validate, download, body);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameGet
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //HealthScoreTimeFrame? healthScore = null;
            //bool? includeStatistics = null;
            //bool? checkTemplateLatestVersion = null;
            //var response = instance.RuleTargetClientRulenameGet(target, varClient, rulename, healthScore, includeStatistics, checkTemplateLatestVersion);
            //Assert.IsType<RuleList>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameParameterPost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameParameterPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //Object? body = null;
            //var response = instance.RuleTargetClientRulenameParameterPost(target, varClient, rulename, body);
            //Assert.IsType<RuleAndStateResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenamePauseDelete
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenamePauseDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenamePauseDelete(target, varClient, rulename);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenamePost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenamePost(target, varClient, rulename);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenamePriorityWeightingPost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenamePriorityWeightingPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //Object? body = null;
            //var response = instance.RuleTargetClientRulenamePriorityWeightingPost(target, varClient, rulename, body);
            //Assert.IsType<RuleAndStateResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameResetDelete
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameResetDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenameResetDelete(target, varClient, rulename);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameSampleDataGet
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameSampleDataGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenameSampleDataGet(target, varClient, rulename);
            //Assert.IsType<ApiJSONArrayResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameSnoozePost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameSnoozePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenameSnoozePost(target, varClient, rulename);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameTestDataDelete
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameTestDataDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenameTestDataDelete(target, varClient, rulename);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameTestDataGet
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameTestDataGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //var response = instance.RuleTargetClientRulenameTestDataGet(target, varClient, rulename);
            //Assert.IsType<TestDataResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetClientRulenameTestDataPost
        /// </summary>
        [Fact]
        public void RuleTargetClientRulenameTestDataPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //string varClient = null;
            //string rulename = null;
            //List<TestData>? testData = null;
            //var response = instance.RuleTargetClientRulenameTestDataPost(target, varClient, rulename, testData);
            //Assert.IsType<ApiResponse>(response);
        }

        /// <summary>
        /// Test RuleTargetGet
        /// </summary>
        [Fact]
        public void RuleTargetGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TargetEnum target = null;
            //int? from = null;
            //int? to = null;
            //string? sortProperty = null;
            //string? sortDescending = null;
            //string? createdRuleUrl = null;
            //HealthScoreTimeFrame? healthScore = null;
            //bool? includeStatistics = null;
            //string? searchText = null;
            //string? parameterName = null;
            //string? parameterValue = null;
            //string? templateFilter = null;
            //bool? includePublic = null;
            //bool? checkTemplateLatestVersion = null;
            //List<string>? iClients = null;
            //var response = instance.RuleTargetGet(target, from, to, sortProperty, sortDescending, createdRuleUrl, healthScore, includeStatistics, searchText, parameterName, parameterValue, templateFilter, includePublic, checkTemplateLatestVersion, iClients);
            //Assert.IsType<RuleList>(response);
        }
    }
}
