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
    ///  Class for testing ShowStatusIcmpv6Detail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusIcmpv6DetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusIcmpv6Detail
        //private ShowStatusIcmpv6Detail instance;

        public ShowStatusIcmpv6DetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusIcmpv6Detail
            //instance = new ShowStatusIcmpv6Detail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusIcmpv6Detail
        /// </summary>
        [Fact]
        public void ShowStatusIcmpv6DetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusIcmpv6Detail
            //Assert.IsType<ShowStatusIcmpv6Detail>(instance);
        }

        /// <summary>
        /// Test the property 'ConnectionsOpened'
        /// </summary>
        [Fact]
        public void ConnectionsOpenedTest()
        {
            // TODO unit test for the property 'ConnectionsOpened'
        }

        /// <summary>
        /// Test the property 'ConnectionsClosed'
        /// </summary>
        [Fact]
        public void ConnectionsClosedTest()
        {
            // TODO unit test for the property 'ConnectionsClosed'
        }

        /// <summary>
        /// Test the property 'TotalIcmpv6Packets'
        /// </summary>
        [Fact]
        public void TotalIcmpv6PacketsTest()
        {
            // TODO unit test for the property 'TotalIcmpv6Packets'
        }

        /// <summary>
        /// Test the property 'ValidatedPacketsPassed'
        /// </summary>
        [Fact]
        public void ValidatedPacketsPassedTest()
        {
            // TODO unit test for the property 'ValidatedPacketsPassed'
        }

        /// <summary>
        /// Test the property 'MalformedPacketsDropped'
        /// </summary>
        [Fact]
        public void MalformedPacketsDroppedTest()
        {
            // TODO unit test for the property 'MalformedPacketsDropped'
        }

        /// <summary>
        /// Test the property 'AverageIcmpv6PacketRate'
        /// </summary>
        [Fact]
        public void AverageIcmpv6PacketRateTest()
        {
            // TODO unit test for the property 'AverageIcmpv6PacketRate'
        }

        /// <summary>
        /// Test the property 'Icmpv6FloodsInProgress'
        /// </summary>
        [Fact]
        public void Icmpv6FloodsInProgressTest()
        {
            // TODO unit test for the property 'Icmpv6FloodsInProgress'
        }

        /// <summary>
        /// Test the property 'TotalIcmpv6FloodsDetected'
        /// </summary>
        [Fact]
        public void TotalIcmpv6FloodsDetectedTest()
        {
            // TODO unit test for the property 'TotalIcmpv6FloodsDetected'
        }

        /// <summary>
        /// Test the property 'TotalIcmpv6FloodPacketsRejected'
        /// </summary>
        [Fact]
        public void TotalIcmpv6FloodPacketsRejectedTest()
        {
            // TODO unit test for the property 'TotalIcmpv6FloodPacketsRejected'
        }
    }
}
