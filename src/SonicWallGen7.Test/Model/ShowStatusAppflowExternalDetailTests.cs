/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SonicWallGen7.Model;
using SonicWallGen7.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace SonicWallGen7.Test.Model
{
    /// <summary>
    ///  Class for testing ShowStatusAppflowExternalDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusAppflowExternalDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusAppflowExternalDetail
        //private ShowStatusAppflowExternalDetail instance;

        public ShowStatusAppflowExternalDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusAppflowExternalDetail
            //instance = new ShowStatusAppflowExternalDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusAppflowExternalDetail
        /// </summary>
        [Fact]
        public void ShowStatusAppflowExternalDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusAppflowExternalDetail
            //Assert.IsType<ShowStatusAppflowExternalDetail>(instance);
        }

        /// <summary>
        /// Test the property 'ConnectionFlowsEnqueued'
        /// </summary>
        [Fact]
        public void ConnectionFlowsEnqueuedTest()
        {
            // TODO unit test for the property 'ConnectionFlowsEnqueued'
        }

        /// <summary>
        /// Test the property 'ConnectionFlowsDequeued'
        /// </summary>
        [Fact]
        public void ConnectionFlowsDequeuedTest()
        {
            // TODO unit test for the property 'ConnectionFlowsDequeued'
        }

        /// <summary>
        /// Test the property 'ConnectionFlowsDropped'
        /// </summary>
        [Fact]
        public void ConnectionFlowsDroppedTest()
        {
            // TODO unit test for the property 'ConnectionFlowsDropped'
        }

        /// <summary>
        /// Test the property 'ConnectionFlowsSkippedReporting'
        /// </summary>
        [Fact]
        public void ConnectionFlowsSkippedReportingTest()
        {
            // TODO unit test for the property 'ConnectionFlowsSkippedReporting'
        }

        /// <summary>
        /// Test the property 'NonConnectionDataEnqueued'
        /// </summary>
        [Fact]
        public void NonConnectionDataEnqueuedTest()
        {
            // TODO unit test for the property 'NonConnectionDataEnqueued'
        }

        /// <summary>
        /// Test the property 'NonConnectionDataDequeued'
        /// </summary>
        [Fact]
        public void NonConnectionDataDequeuedTest()
        {
            // TODO unit test for the property 'NonConnectionDataDequeued'
        }

        /// <summary>
        /// Test the property 'NonConnectionDataDropped'
        /// </summary>
        [Fact]
        public void NonConnectionDataDroppedTest()
        {
            // TODO unit test for the property 'NonConnectionDataDropped'
        }

        /// <summary>
        /// Test the property 'NonConnectionRelatedStaticDataReported'
        /// </summary>
        [Fact]
        public void NonConnectionRelatedStaticDataReportedTest()
        {
            // TODO unit test for the property 'NonConnectionRelatedStaticDataReported'
        }

        /// <summary>
        /// Test the property 'LogReportedByIpfix'
        /// </summary>
        [Fact]
        public void LogReportedByIpfixTest()
        {
            // TODO unit test for the property 'LogReportedByIpfix'
        }
    }
}
