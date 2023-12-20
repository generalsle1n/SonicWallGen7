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
    ///  Class for testing SslVpnPortalSslVpnPortal
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SslVpnPortalSslVpnPortalTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SslVpnPortalSslVpnPortal
        //private SslVpnPortalSslVpnPortal instance;

        public SslVpnPortalSslVpnPortalTests()
        {
            // TODO uncomment below to create an instance of SslVpnPortalSslVpnPortal
            //instance = new SslVpnPortalSslVpnPortal();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SslVpnPortalSslVpnPortal
        /// </summary>
        [Fact]
        public void SslVpnPortalSslVpnPortalInstanceTest()
        {
            // TODO uncomment below to test "IsType" SslVpnPortalSslVpnPortal
            //Assert.IsType<SslVpnPortalSslVpnPortal>(instance);
        }

        /// <summary>
        /// Test the property 'SiteTitle'
        /// </summary>
        [Fact]
        public void SiteTitleTest()
        {
            // TODO unit test for the property 'SiteTitle'
        }

        /// <summary>
        /// Test the property 'BannerTitle'
        /// </summary>
        [Fact]
        public void BannerTitleTest()
        {
            // TODO unit test for the property 'BannerTitle'
        }

        /// <summary>
        /// Test the property 'HomePageMessage'
        /// </summary>
        [Fact]
        public void HomePageMessageTest()
        {
            // TODO unit test for the property 'HomePageMessage'
        }

        /// <summary>
        /// Test the property 'LoginMessage'
        /// </summary>
        [Fact]
        public void LoginMessageTest()
        {
            // TODO unit test for the property 'LoginMessage'
        }

        /// <summary>
        /// Test the property 'AutoLaunch'
        /// </summary>
        [Fact]
        public void AutoLaunchTest()
        {
            // TODO unit test for the property 'AutoLaunch'
        }

        /// <summary>
        /// Test the property 'CacheControl'
        /// </summary>
        [Fact]
        public void CacheControlTest()
        {
            // TODO unit test for the property 'CacheControl'
        }

        /// <summary>
        /// Test the property 'DisplayLink'
        /// </summary>
        [Fact]
        public void DisplayLinkTest()
        {
            // TODO unit test for the property 'DisplayLink'
        }

        /// <summary>
        /// Test the property 'Logo'
        /// </summary>
        [Fact]
        public void LogoTest()
        {
            // TODO unit test for the property 'Logo'
        }
    }
}
