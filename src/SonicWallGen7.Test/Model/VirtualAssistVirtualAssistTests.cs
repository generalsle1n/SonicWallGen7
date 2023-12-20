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
    ///  Class for testing VirtualAssistVirtualAssist
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class VirtualAssistVirtualAssistTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for VirtualAssistVirtualAssist
        //private VirtualAssistVirtualAssist instance;

        public VirtualAssistVirtualAssistTests()
        {
            // TODO uncomment below to create an instance of VirtualAssistVirtualAssist
            //instance = new VirtualAssistVirtualAssist();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VirtualAssistVirtualAssist
        /// </summary>
        [Fact]
        public void VirtualAssistVirtualAssistInstanceTest()
        {
            // TODO uncomment below to test "IsType" VirtualAssistVirtualAssist
            //Assert.IsType<VirtualAssistVirtualAssist>(instance);
        }

        /// <summary>
        /// Test the property 'AssistanceCode'
        /// </summary>
        [Fact]
        public void AssistanceCodeTest()
        {
            // TODO unit test for the property 'AssistanceCode'
        }

        /// <summary>
        /// Test the property 'SupportWithoutInvitation'
        /// </summary>
        [Fact]
        public void SupportWithoutInvitationTest()
        {
            // TODO unit test for the property 'SupportWithoutInvitation'
        }

        /// <summary>
        /// Test the property 'Disclaimer'
        /// </summary>
        [Fact]
        public void DisclaimerTest()
        {
            // TODO unit test for the property 'Disclaimer'
        }

        /// <summary>
        /// Test the property 'CustomerAccessLink'
        /// </summary>
        [Fact]
        public void CustomerAccessLinkTest()
        {
            // TODO unit test for the property 'CustomerAccessLink'
        }

        /// <summary>
        /// Test the property 'LinkOnPortalLogin'
        /// </summary>
        [Fact]
        public void LinkOnPortalLoginTest()
        {
            // TODO unit test for the property 'LinkOnPortalLogin'
        }

        /// <summary>
        /// Test the property 'TechnicianEmailList'
        /// </summary>
        [Fact]
        public void TechnicianEmailListTest()
        {
            // TODO unit test for the property 'TechnicianEmailList'
        }

        /// <summary>
        /// Test the property 'InvitationSubject'
        /// </summary>
        [Fact]
        public void InvitationSubjectTest()
        {
            // TODO unit test for the property 'InvitationSubject'
        }

        /// <summary>
        /// Test the property 'InvitationMessage'
        /// </summary>
        [Fact]
        public void InvitationMessageTest()
        {
            // TODO unit test for the property 'InvitationMessage'
        }

        /// <summary>
        /// Test the property 'MaxRequests'
        /// </summary>
        [Fact]
        public void MaxRequestsTest()
        {
            // TODO unit test for the property 'MaxRequests'
        }

        /// <summary>
        /// Test the property 'LimitMessage'
        /// </summary>
        [Fact]
        public void LimitMessageTest()
        {
            // TODO unit test for the property 'LimitMessage'
        }

        /// <summary>
        /// Test the property 'MaxRequestsOneIp'
        /// </summary>
        [Fact]
        public void MaxRequestsOneIpTest()
        {
            // TODO unit test for the property 'MaxRequestsOneIp'
        }

        /// <summary>
        /// Test the property 'PendingRequestExpiration'
        /// </summary>
        [Fact]
        public void PendingRequestExpirationTest()
        {
            // TODO unit test for the property 'PendingRequestExpiration'
        }
    }
}
