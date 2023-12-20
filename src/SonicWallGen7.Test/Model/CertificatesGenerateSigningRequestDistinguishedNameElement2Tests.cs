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
    ///  Class for testing CertificatesGenerateSigningRequestDistinguishedNameElement2
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CertificatesGenerateSigningRequestDistinguishedNameElement2Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CertificatesGenerateSigningRequestDistinguishedNameElement2
        //private CertificatesGenerateSigningRequestDistinguishedNameElement2 instance;

        public CertificatesGenerateSigningRequestDistinguishedNameElement2Tests()
        {
            // TODO uncomment below to create an instance of CertificatesGenerateSigningRequestDistinguishedNameElement2
            //instance = new CertificatesGenerateSigningRequestDistinguishedNameElement2();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CertificatesGenerateSigningRequestDistinguishedNameElement2
        /// </summary>
        [Fact]
        public void CertificatesGenerateSigningRequestDistinguishedNameElement2InstanceTest()
        {
            // TODO uncomment below to test "IsType" CertificatesGenerateSigningRequestDistinguishedNameElement2
            //Assert.IsType<CertificatesGenerateSigningRequestDistinguishedNameElement2>(instance);
        }

        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }

        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }

        /// <summary>
        /// Test the property 'Locality'
        /// </summary>
        [Fact]
        public void LocalityTest()
        {
            // TODO unit test for the property 'Locality'
        }

        /// <summary>
        /// Test the property 'Organization'
        /// </summary>
        [Fact]
        public void OrganizationTest()
        {
            // TODO unit test for the property 'Organization'
        }

        /// <summary>
        /// Test the property 'Department'
        /// </summary>
        [Fact]
        public void DepartmentTest()
        {
            // TODO unit test for the property 'Department'
        }
    }
}
