/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SonicWallGen7.Client;
using SonicWallGen7.Api;
// uncomment below to import models
//using SonicWallGen7.Model;

namespace SonicWallGen7.Test.Api
{
    /// <summary>
    ///  Class for testing PolicySectionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PolicySectionApiTests : IDisposable
    {
        private PolicySectionApi instance;

        public PolicySectionApiTests()
        {
            instance = new PolicySectionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PolicySectionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PolicySectionApi
            //Assert.IsType<PolicySectionApi>(instance);
        }

        /// <summary>
        /// Test PolicySectionsGet
        /// </summary>
        [Fact]
        public void PolicySectionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PolicySectionsGet();
            //Assert.IsType<PolicySectionCollection>(response);
        }

        /// <summary>
        /// Test PolicySectionsPost
        /// </summary>
        [Fact]
        public void PolicySectionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PolicySectionCollection? policySectionCollection = null;
            //var response = instance.PolicySectionsPost(policySectionCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test PolicySectionsPut
        /// </summary>
        [Fact]
        public void PolicySectionsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PolicySectionCollection? policySectionCollection = null;
            //var response = instance.PolicySectionsPut(policySectionCollection);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test PolicySectionsUuidUUIDNameNAMEDelete
        /// </summary>
        [Fact]
        public void PolicySectionsUuidUUIDNameNAMEDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //string NAME = null;
            //var response = instance.PolicySectionsUuidUUIDNameNAMEDelete(UUID, NAME);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test PolicySectionsUuidUUIDNameNAMEGet
        /// </summary>
        [Fact]
        public void PolicySectionsUuidUUIDNameNAMEGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //string NAME = null;
            //var response = instance.PolicySectionsUuidUUIDNameNAMEGet(UUID, NAME);
            //Assert.IsType<PolicySectionCollection>(response);
        }

        /// <summary>
        /// Test PolicySectionsUuidUUIDNameNAMEPut
        /// </summary>
        [Fact]
        public void PolicySectionsUuidUUIDNameNAMEPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string UUID = null;
            //string NAME = null;
            //PolicySectionCollection? policySectionCollection = null;
            //var response = instance.PolicySectionsUuidUUIDNameNAMEPut(UUID, NAME, policySectionCollection);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}