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
    ///  Class for testing LogGlobalCategoriesLogCategoriesGlobalCategoryAttribute
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LogGlobalCategoriesLogCategoriesGlobalCategoryAttribute
        //private LogGlobalCategoriesLogCategoriesGlobalCategoryAttribute instance;

        public LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeTests()
        {
            // TODO uncomment below to create an instance of LogGlobalCategoriesLogCategoriesGlobalCategoryAttribute
            //instance = new LogGlobalCategoriesLogCategoriesGlobalCategoryAttribute();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LogGlobalCategoriesLogCategoriesGlobalCategoryAttribute
        /// </summary>
        [Fact]
        public void LogGlobalCategoriesLogCategoriesGlobalCategoryAttributeInstanceTest()
        {
            // TODO uncomment below to test "IsType" LogGlobalCategoriesLogCategoriesGlobalCategoryAttribute
            //Assert.IsType<LogGlobalCategoriesLogCategoriesGlobalCategoryAttribute>(instance);
        }

        /// <summary>
        /// Test the property 'PriorityLevel'
        /// </summary>
        [Fact]
        public void PriorityLevelTest()
        {
            // TODO unit test for the property 'PriorityLevel'
        }

        /// <summary>
        /// Test the property 'LogMonitor'
        /// </summary>
        [Fact]
        public void LogMonitorTest()
        {
            // TODO unit test for the property 'LogMonitor'
        }

        /// <summary>
        /// Test the property 'EmailAlert'
        /// </summary>
        [Fact]
        public void EmailAlertTest()
        {
            // TODO unit test for the property 'EmailAlert'
        }

        /// <summary>
        /// Test the property 'Syslog'
        /// </summary>
        [Fact]
        public void SyslogTest()
        {
            // TODO unit test for the property 'Syslog'
        }

        /// <summary>
        /// Test the property 'Trap'
        /// </summary>
        [Fact]
        public void TrapTest()
        {
            // TODO unit test for the property 'Trap'
        }

        /// <summary>
        /// Test the property 'Ipfix'
        /// </summary>
        [Fact]
        public void IpfixTest()
        {
            // TODO unit test for the property 'Ipfix'
        }

        /// <summary>
        /// Test the property 'EventProfile'
        /// </summary>
        [Fact]
        public void EventProfileTest()
        {
            // TODO unit test for the property 'EventProfile'
        }

        /// <summary>
        /// Test the property 'LogDigest'
        /// </summary>
        [Fact]
        public void LogDigestTest()
        {
            // TODO unit test for the property 'LogDigest'
        }

        /// <summary>
        /// Test the property 'Color'
        /// </summary>
        [Fact]
        public void ColorTest()
        {
            // TODO unit test for the property 'Color'
        }

        /// <summary>
        /// Test the property 'AlertEmail'
        /// </summary>
        [Fact]
        public void AlertEmailTest()
        {
            // TODO unit test for the property 'AlertEmail'
        }

        /// <summary>
        /// Test the property 'LogEmail'
        /// </summary>
        [Fact]
        public void LogEmailTest()
        {
            // TODO unit test for the property 'LogEmail'
        }
    }
}
