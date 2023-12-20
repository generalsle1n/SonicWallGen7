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
    ///  Class for testing HaBaseModeActiveStandbyActiveStandby
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class HaBaseModeActiveStandbyActiveStandbyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for HaBaseModeActiveStandbyActiveStandby
        //private HaBaseModeActiveStandbyActiveStandby instance;

        public HaBaseModeActiveStandbyActiveStandbyTests()
        {
            // TODO uncomment below to create an instance of HaBaseModeActiveStandbyActiveStandby
            //instance = new HaBaseModeActiveStandbyActiveStandby();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HaBaseModeActiveStandbyActiveStandby
        /// </summary>
        [Fact]
        public void HaBaseModeActiveStandbyActiveStandbyInstanceTest()
        {
            // TODO uncomment below to test "IsType" HaBaseModeActiveStandbyActiveStandby
            //Assert.IsType<HaBaseModeActiveStandbyActiveStandby>(instance);
        }

        /// <summary>
        /// Test the property 'PrimarySerial'
        /// </summary>
        [Fact]
        public void PrimarySerialTest()
        {
            // TODO unit test for the property 'PrimarySerial'
        }

        /// <summary>
        /// Test the property 'SecondarySerial'
        /// </summary>
        [Fact]
        public void SecondarySerialTest()
        {
            // TODO unit test for the property 'SecondarySerial'
        }

        /// <summary>
        /// Test the property 'StatefulSynchronization'
        /// </summary>
        [Fact]
        public void StatefulSynchronizationTest()
        {
            // TODO unit test for the property 'StatefulSynchronization'
        }

        /// <summary>
        /// Test the property 'ControlInterface'
        /// </summary>
        [Fact]
        public void ControlInterfaceTest()
        {
            // TODO unit test for the property 'ControlInterface'
        }

        /// <summary>
        /// Test the property 'DataInterface'
        /// </summary>
        [Fact]
        public void DataInterfaceTest()
        {
            // TODO unit test for the property 'DataInterface'
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
        /// Test the property 'Encryption'
        /// </summary>
        [Fact]
        public void EncryptionTest()
        {
            // TODO unit test for the property 'Encryption'
        }
    }
}
