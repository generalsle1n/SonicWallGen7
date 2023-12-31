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
    ///  Class for testing ServiceObject
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ServiceObjectTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ServiceObject
        //private ServiceObject instance;

        public ServiceObjectTests()
        {
            // TODO uncomment below to create an instance of ServiceObject
            //instance = new ServiceObject();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ServiceObject
        /// </summary>
        [Fact]
        public void ServiceObjectInstanceTest()
        {
            // TODO uncomment below to test "IsType" ServiceObject
            //Assert.IsType<ServiceObject>(instance);
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
        /// Test the property 'Uuid'
        /// </summary>
        [Fact]
        public void UuidTest()
        {
            // TODO unit test for the property 'Uuid'
        }

        /// <summary>
        /// Test the property 'Custom'
        /// </summary>
        [Fact]
        public void CustomTest()
        {
            // TODO unit test for the property 'Custom'
        }

        /// <summary>
        /// Test the property 'Icmp'
        /// </summary>
        [Fact]
        public void IcmpTest()
        {
            // TODO unit test for the property 'Icmp'
        }

        /// <summary>
        /// Test the property 'Igmp'
        /// </summary>
        [Fact]
        public void IgmpTest()
        {
            // TODO unit test for the property 'Igmp'
        }

        /// <summary>
        /// Test the property 'Tcp'
        /// </summary>
        [Fact]
        public void TcpTest()
        {
            // TODO unit test for the property 'Tcp'
        }

        /// <summary>
        /// Test the property 'Udp'
        /// </summary>
        [Fact]
        public void UdpTest()
        {
            // TODO unit test for the property 'Udp'
        }

        /// <summary>
        /// Test the property 'Gre'
        /// </summary>
        [Fact]
        public void GreTest()
        {
            // TODO unit test for the property 'Gre'
        }

        /// <summary>
        /// Test the property 'Esp'
        /// </summary>
        [Fact]
        public void EspTest()
        {
            // TODO unit test for the property 'Esp'
        }

        /// <summary>
        /// Test the property 'Var6over4'
        /// </summary>
        [Fact]
        public void Var6over4Test()
        {
            // TODO unit test for the property 'Var6over4'
        }

        /// <summary>
        /// Test the property 'Ah'
        /// </summary>
        [Fact]
        public void AhTest()
        {
            // TODO unit test for the property 'Ah'
        }

        /// <summary>
        /// Test the property 'Icmpv6Custom'
        /// </summary>
        [Fact]
        public void Icmpv6CustomTest()
        {
            // TODO unit test for the property 'Icmpv6Custom'
        }

        /// <summary>
        /// Test the property 'Icmpv6'
        /// </summary>
        [Fact]
        public void Icmpv6Test()
        {
            // TODO unit test for the property 'Icmpv6'
        }

        /// <summary>
        /// Test the property 'Eigrp'
        /// </summary>
        [Fact]
        public void EigrpTest()
        {
            // TODO unit test for the property 'Eigrp'
        }

        /// <summary>
        /// Test the property 'Ospf'
        /// </summary>
        [Fact]
        public void OspfTest()
        {
            // TODO unit test for the property 'Ospf'
        }

        /// <summary>
        /// Test the property 'Pim'
        /// </summary>
        [Fact]
        public void PimTest()
        {
            // TODO unit test for the property 'Pim'
        }

        /// <summary>
        /// Test the property 'L2tp'
        /// </summary>
        [Fact]
        public void L2tpTest()
        {
            // TODO unit test for the property 'L2tp'
        }

        /// <summary>
        /// Test the property 'Ipcomp'
        /// </summary>
        [Fact]
        public void IpcompTest()
        {
            // TODO unit test for the property 'Ipcomp'
        }
    }
}
