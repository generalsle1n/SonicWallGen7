# SonicWallGen7.Model.DiagAdvancedVpnDiagAdvancedVpn
Configure advanced diag VPN settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdjustTcpMss** | **bool** | Enable adjusting TCP MSS option for VPN traffic. | [optional] 
**InteroperableIkeDhExchange** | **bool** | Enable using interoperable IKE DH exchange . | [optional] 
**FragmentAfterEsp** | **bool** | Enable fragmenting VPN packets after applying ESP. | [optional] 
**SpiCpiParameterIndex** | **bool** | Enable using SPI/CPI parameter index for IPsec/IPcomp passthru connections. | [optional] 
**TrustBuiltInCa** | **bool** | Enable trust built-in CA certificates for IKE authentication and local certificate import. | [optional] 
**PreserveIkePort** | **bool** | Enable preserve IKE port for pass through connections. | [optional] 
**QuickModeAcceptReservedId** | **bool** | Accept reserved ID type in quick mode. | [optional] 
**TunnelRemovalNoIkeResponse** | **bool** | Remove VPN tunnel when IKEv2 peer has no response. | [optional] 
**Android40Compatibility** | **bool** | Enable compatibility with Android 4.0 client. | [optional] 
**AutoAddedManagementRules** | **bool** | Enable auto-added VPN management rules. | [optional] 
**PeerNotificationOnValidationFailure** | **bool** | Send notification to peer when fail to validate or verify received IKEv1 payload. | [optional] 
**MaxNegotiatePerSec** | **decimal** | Set threshold for max negotiation could start per second (0 for unlimited). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

