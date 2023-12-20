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
    ///  Class for testing LogAutomationLogAutomation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LogAutomationLogAutomationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LogAutomationLogAutomation
        //private LogAutomationLogAutomation instance;

        public LogAutomationLogAutomationTests()
        {
            // TODO uncomment below to create an instance of LogAutomationLogAutomation
            //instance = new LogAutomationLogAutomation();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LogAutomationLogAutomation
        /// </summary>
        [Fact]
        public void LogAutomationLogAutomationInstanceTest()
        {
            // TODO uncomment below to test "IsType" LogAutomationLogAutomation
            //Assert.IsType<LogAutomationLogAutomation>(instance);
        }

        /// <summary>
        /// Test the property 'EmailAddress'
        /// </summary>
        [Fact]
        public void EmailAddressTest()
        {
            // TODO unit test for the property 'EmailAddress'
        }

        /// <summary>
        /// Test the property 'SendLog'
        /// </summary>
        [Fact]
        public void SendLogTest()
        {
            // TODO unit test for the property 'SendLog'
        }

        /// <summary>
        /// Test the property 'EmailFormatLog'
        /// </summary>
        [Fact]
        public void EmailFormatLogTest()
        {
            // TODO unit test for the property 'EmailFormatLog'
        }

        /// <summary>
        /// Test the property 'SendAudit'
        /// </summary>
        [Fact]
        public void SendAuditTest()
        {
            // TODO unit test for the property 'SendAudit'
        }

        /// <summary>
        /// Test the property 'EmailFormatAudit'
        /// </summary>
        [Fact]
        public void EmailFormatAuditTest()
        {
            // TODO unit test for the property 'EmailFormatAudit'
        }

        /// <summary>
        /// Test the property 'IncludeAllLogInformation'
        /// </summary>
        [Fact]
        public void IncludeAllLogInformationTest()
        {
            // TODO unit test for the property 'IncludeAllLogInformation'
        }

        /// <summary>
        /// Test the property 'HealthCheckEmail'
        /// </summary>
        [Fact]
        public void HealthCheckEmailTest()
        {
            // TODO unit test for the property 'HealthCheckEmail'
        }

        /// <summary>
        /// Test the property 'MailServer'
        /// </summary>
        [Fact]
        public void MailServerTest()
        {
            // TODO unit test for the property 'MailServer'
        }

        /// <summary>
        /// Test the property 'MailFrom'
        /// </summary>
        [Fact]
        public void MailFromTest()
        {
            // TODO unit test for the property 'MailFrom'
        }

        /// <summary>
        /// Test the property 'AuthenticationMethod'
        /// </summary>
        [Fact]
        public void AuthenticationMethodTest()
        {
            // TODO unit test for the property 'AuthenticationMethod'
        }

        /// <summary>
        /// Test the property 'Pop3Server'
        /// </summary>
        [Fact]
        public void Pop3ServerTest()
        {
            // TODO unit test for the property 'Pop3Server'
        }

        /// <summary>
        /// Test the property 'Pop3UserName'
        /// </summary>
        [Fact]
        public void Pop3UserNameTest()
        {
            // TODO unit test for the property 'Pop3UserName'
        }

        /// <summary>
        /// Test the property 'Pop3Password'
        /// </summary>
        [Fact]
        public void Pop3PasswordTest()
        {
            // TODO unit test for the property 'Pop3Password'
        }

        /// <summary>
        /// Test the property 'MailServerAdvanced'
        /// </summary>
        [Fact]
        public void MailServerAdvancedTest()
        {
            // TODO unit test for the property 'MailServerAdvanced'
        }

        /// <summary>
        /// Test the property 'FtpLog'
        /// </summary>
        [Fact]
        public void FtpLogTest()
        {
            // TODO unit test for the property 'FtpLog'
        }

        /// <summary>
        /// Test the property 'Solera'
        /// </summary>
        [Fact]
        public void SoleraTest()
        {
            // TODO unit test for the property 'Solera'
        }
    }
}
