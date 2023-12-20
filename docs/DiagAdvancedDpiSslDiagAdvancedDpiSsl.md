# SonicWallGen7.Model.DiagAdvancedDpiSslDiagAdvancedDpiSsl
Configure advanced diag DPI-SSL settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewrittenCertificateSnModifier** | **decimal** | Set rewritten certificate SN modifier. | [optional] 
**ClientSpoofedCertificateCaching** | **bool** | Enable client spoofed certificate caching. | [optional] 
**RemoveTcpTimestampOption** | **bool** | Enable removing TCP timestamp option. | [optional] 
**DropSslOnLowMemory** | **bool** | Enable dropping SSL packets when memory low. | [optional] 
**DpiSslSignedCertificateTrust** | **bool** | Trust DPI-SSL signed certificate. | [optional] 
**ProxylessSslWhenLimitExceeded** | **bool** | Enable allowing SSL without proxy when connection limit exceeded. | [optional] 
**ServerFacingSessionReuse** | **bool** | Enable server facing cache. | [optional] 
**ClientFacingSessionReuse** | **bool** | Enable client facing cache. | [optional] 
**IpBasedExclusionCache** | **bool** | Enable IP based exclusion cache. | [optional] 
**Use2048BitCertificateKey** | **bool** | Use 2048 bit spoof certificate key in DPI SSL. | [optional] 
**DynamicExclusionForExcludedConnections** | **bool** | Enable Dynamic Exclusion for exclude connections. | [optional] 
**ConnectionFailures** | [**DiagAdvancedDpiSslDiagAdvancedDpiSslConnectionFailures**](DiagAdvancedDpiSslDiagAdvancedDpiSslConnectionFailures.md) |  | [optional] 
**RevocationCheckServerCerificate** | **bool** | Enable check for server certificate revocation. | [optional] 
**ExpiredCertificateAuthority** | **bool** | Allow expired certificate authority. | [optional] 
**DpiSslExtendedMemory** | **bool** | Allow DPI-SSL connections to use extended memory. | [optional] 
**EndpointTcpWindowSetup** | **bool** | Enable endpoint TCP window setup. | [optional] 
**BlockUntrustedCertificateConnections** | **bool** | Enable blocking connections to sites with untrusted certificates. | [optional] 
**MaxStreamOffset** | **decimal** | Set max stream offset to check for SSL client-hello resemblance. | [optional] 
**SslVersion** | **string** | Set ssl version. | [optional] 
**TcpWindowMultiplier** | **decimal** | Set TCP window multiplier (N *64k). | [optional] 
**TcpDuplicateAckResponseThreshold** | **decimal** | Set TCP Duplicate Ack response threshold. | [optional] 
**ExtendedMemoryImplementation** | **decimal** | Settings for Extended Memory Implementation. | [optional] 
**MaxProxiedConnections** | **decimal** | Set the override for max proxied SSL connections. | [optional] 
**CipherMethod** | **string** | Set ssl cipher method. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

