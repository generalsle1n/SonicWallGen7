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
    ///  Class for testing AppflowSfrMailingAppflowSfrMailing
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AppflowSfrMailingAppflowSfrMailingTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AppflowSfrMailingAppflowSfrMailing
        //private AppflowSfrMailingAppflowSfrMailing instance;

        public AppflowSfrMailingAppflowSfrMailingTests()
        {
            // TODO uncomment below to create an instance of AppflowSfrMailingAppflowSfrMailing
            //instance = new AppflowSfrMailingAppflowSfrMailing();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppflowSfrMailingAppflowSfrMailing
        /// </summary>
        [Fact]
        public void AppflowSfrMailingAppflowSfrMailingInstanceTest()
        {
            // TODO uncomment below to test "IsType" AppflowSfrMailingAppflowSfrMailing
            //Assert.IsType<AppflowSfrMailingAppflowSfrMailing>(instance);
        }

        /// <summary>
        /// Test the property 'SendEmail'
        /// </summary>
        [Fact]
        public void SendEmailTest()
        {
            // TODO unit test for the property 'SendEmail'
        }

        /// <summary>
        /// Test the property 'SmtpServerHost'
        /// </summary>
        [Fact]
        public void SmtpServerHostTest()
        {
            // TODO unit test for the property 'SmtpServerHost'
        }

        /// <summary>
        /// Test the property 'ReportToEmail'
        /// </summary>
        [Fact]
        public void ReportToEmailTest()
        {
            // TODO unit test for the property 'ReportToEmail'
        }

        /// <summary>
        /// Test the property 'ReportFromEmail'
        /// </summary>
        [Fact]
        public void ReportFromEmailTest()
        {
            // TODO unit test for the property 'ReportFromEmail'
        }

        /// <summary>
        /// Test the property 'SmtpServerPort'
        /// </summary>
        [Fact]
        public void SmtpServerPortTest()
        {
            // TODO unit test for the property 'SmtpServerPort'
        }

        /// <summary>
        /// Test the property 'SecurityMethod'
        /// </summary>
        [Fact]
        public void SecurityMethodTest()
        {
            // TODO unit test for the property 'SecurityMethod'
        }

        /// <summary>
        /// Test the property 'SmtpAuth'
        /// </summary>
        [Fact]
        public void SmtpAuthTest()
        {
            // TODO unit test for the property 'SmtpAuth'
        }

        /// <summary>
        /// Test the property 'SmtpUser'
        /// </summary>
        [Fact]
        public void SmtpUserTest()
        {
            // TODO unit test for the property 'SmtpUser'
        }

        /// <summary>
        /// Test the property 'SmtpPass'
        /// </summary>
        [Fact]
        public void SmtpPassTest()
        {
            // TODO unit test for the property 'SmtpPass'
        }

        /// <summary>
        /// Test the property 'PopBeforeSmtp'
        /// </summary>
        [Fact]
        public void PopBeforeSmtpTest()
        {
            // TODO unit test for the property 'PopBeforeSmtp'
        }

        /// <summary>
        /// Test the property 'PopServerAddress'
        /// </summary>
        [Fact]
        public void PopServerAddressTest()
        {
            // TODO unit test for the property 'PopServerAddress'
        }

        /// <summary>
        /// Test the property 'PopUsername'
        /// </summary>
        [Fact]
        public void PopUsernameTest()
        {
            // TODO unit test for the property 'PopUsername'
        }

        /// <summary>
        /// Test the property 'PopPass'
        /// </summary>
        [Fact]
        public void PopPassTest()
        {
            // TODO unit test for the property 'PopPass'
        }
    }
}