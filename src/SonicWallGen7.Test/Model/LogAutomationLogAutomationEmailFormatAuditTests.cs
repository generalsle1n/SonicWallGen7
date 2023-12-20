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
    ///  Class for testing LogAutomationLogAutomationEmailFormatAudit
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LogAutomationLogAutomationEmailFormatAuditTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LogAutomationLogAutomationEmailFormatAudit
        //private LogAutomationLogAutomationEmailFormatAudit instance;

        public LogAutomationLogAutomationEmailFormatAuditTests()
        {
            // TODO uncomment below to create an instance of LogAutomationLogAutomationEmailFormatAudit
            //instance = new LogAutomationLogAutomationEmailFormatAudit();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LogAutomationLogAutomationEmailFormatAudit
        /// </summary>
        [Fact]
        public void LogAutomationLogAutomationEmailFormatAuditInstanceTest()
        {
            // TODO uncomment below to test "IsType" LogAutomationLogAutomationEmailFormatAudit
            //Assert.IsType<LogAutomationLogAutomationEmailFormatAudit>(instance);
        }

        /// <summary>
        /// Test the property 'PlainText'
        /// </summary>
        [Fact]
        public void PlainTextTest()
        {
            // TODO unit test for the property 'PlainText'
        }

        /// <summary>
        /// Test the property 'Html'
        /// </summary>
        [Fact]
        public void HtmlTest()
        {
            // TODO unit test for the property 'Html'
        }

        /// <summary>
        /// Test the property 'Csv'
        /// </summary>
        [Fact]
        public void CsvTest()
        {
            // TODO unit test for the property 'Csv'
        }
    }
}