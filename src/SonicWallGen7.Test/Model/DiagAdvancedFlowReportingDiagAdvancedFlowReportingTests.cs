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
    ///  Class for testing DiagAdvancedFlowReportingDiagAdvancedFlowReporting
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DiagAdvancedFlowReportingDiagAdvancedFlowReportingTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DiagAdvancedFlowReportingDiagAdvancedFlowReporting
        //private DiagAdvancedFlowReportingDiagAdvancedFlowReporting instance;

        public DiagAdvancedFlowReportingDiagAdvancedFlowReportingTests()
        {
            // TODO uncomment below to create an instance of DiagAdvancedFlowReportingDiagAdvancedFlowReporting
            //instance = new DiagAdvancedFlowReportingDiagAdvancedFlowReporting();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiagAdvancedFlowReportingDiagAdvancedFlowReporting
        /// </summary>
        [Fact]
        public void DiagAdvancedFlowReportingDiagAdvancedFlowReportingInstanceTest()
        {
            // TODO uncomment below to test "IsType" DiagAdvancedFlowReportingDiagAdvancedFlowReporting
            //Assert.IsType<DiagAdvancedFlowReportingDiagAdvancedFlowReporting>(instance);
        }

        /// <summary>
        /// Test the property 'ExportRawDatabase'
        /// </summary>
        [Fact]
        public void ExportRawDatabaseTest()
        {
            // TODO unit test for the property 'ExportRawDatabase'
        }

        /// <summary>
        /// Test the property 'SqlConsole'
        /// </summary>
        [Fact]
        public void SqlConsoleTest()
        {
            // TODO unit test for the property 'SqlConsole'
        }

        /// <summary>
        /// Test the property 'AppflowMonitorBrowserFrameLaunch'
        /// </summary>
        [Fact]
        public void AppflowMonitorBrowserFrameLaunchTest()
        {
            // TODO unit test for the property 'AppflowMonitorBrowserFrameLaunch'
        }

        /// <summary>
        /// Test the property 'NonAdminVisualization'
        /// </summary>
        [Fact]
        public void NonAdminVisualizationTest()
        {
            // TODO unit test for the property 'NonAdminVisualization'
        }

        /// <summary>
        /// Test the property 'DatabaseBusyTimeout'
        /// </summary>
        [Fact]
        public void DatabaseBusyTimeoutTest()
        {
            // TODO unit test for the property 'DatabaseBusyTimeout'
        }

        /// <summary>
        /// Test the property 'HideAppflowServer'
        /// </summary>
        [Fact]
        public void HideAppflowServerTest()
        {
            // TODO unit test for the property 'HideAppflowServer'
        }

        /// <summary>
        /// Test the property 'HideGmsflowServer'
        /// </summary>
        [Fact]
        public void HideGmsflowServerTest()
        {
            // TODO unit test for the property 'HideGmsflowServer'
        }

        /// <summary>
        /// Test the property 'ReportServerAddress'
        /// </summary>
        [Fact]
        public void ReportServerAddressTest()
        {
            // TODO unit test for the property 'ReportServerAddress'
        }
    }
}
