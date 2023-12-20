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
    ///  Class for testing FlbGroup
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class FlbGroupTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FlbGroup
        //private FlbGroup instance;

        public FlbGroupTests()
        {
            // TODO uncomment below to create an instance of FlbGroup
            //instance = new FlbGroup();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FlbGroup
        /// </summary>
        [Fact]
        public void FlbGroupInstanceTest()
        {
            // TODO uncomment below to test "IsType" FlbGroup
            //Assert.IsType<FlbGroup>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'Preempt'
        /// </summary>
        [Fact]
        public void PreemptTest()
        {
            // TODO unit test for the property 'Preempt'
        }

        /// <summary>
        /// Test the property 'SpilloverBandwidth'
        /// </summary>
        [Fact]
        public void SpilloverBandwidthTest()
        {
            // TODO unit test for the property 'SpilloverBandwidth'
        }

        /// <summary>
        /// Test the property 'AddressBinding'
        /// </summary>
        [Fact]
        public void AddressBindingTest()
        {
            // TODO unit test for the property 'AddressBinding'
        }

        /// <summary>
        /// Test the property 'FinalBackup'
        /// </summary>
        [Fact]
        public void FinalBackupTest()
        {
            // TODO unit test for the property 'FinalBackup'
        }

        /// <summary>
        /// Test the property 'VarInterface'
        /// </summary>
        [Fact]
        public void VarInterfaceTest()
        {
            // TODO unit test for the property 'VarInterface'
        }

        /// <summary>
        /// Test the property 'Percent'
        /// </summary>
        [Fact]
        public void PercentTest()
        {
            // TODO unit test for the property 'Percent'
        }

        /// <summary>
        /// Test the property 'Probing'
        /// </summary>
        [Fact]
        public void ProbingTest()
        {
            // TODO unit test for the property 'Probing'
        }
    }
}