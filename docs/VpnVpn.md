# SonicWallGen7.Model.VpnVpn
Configure VPN.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable VPN. | [optional] 
**FirewallIdentifier** | **string** | Configure unique firewall identifier. | [optional] 
**IkeDpd** | [**VpnVpnIkeDpd**](VpnVpnIkeDpd.md) |  | [optional] 
**FragPackets** | [**VpnVpnFragPackets**](VpnVpnFragPackets.md) |  | [optional] 
**NatTraversal** | **bool** | Enable NAT traversal. | [optional] 
**CleanupTunnels** | **bool** | Enable clean up active tunnels when peer gateway DNS name resolves to a different IP address. | [optional] 
**PreserveIkePort** | **bool** | Enable preserve IKE port for pass through connections. | [optional] 
**OcspChecking** | **bool** | Enable OCSP checking. | [optional] 
**ResponderUrl** | **string** | OCSP responder URL. | [optional] 
**TrapsOnChange** | **bool** | Enable VPN tunnel traps only when tunnel status changes. | [optional] 
**UseRadius** | [**VpnVpnUseRadius**](VpnVpnUseRadius.md) |  | [optional] 
**Dns** | [**VpnVpnDns**](VpnVpnDns.md) |  | [optional] 
**Wins** | [**DhcpServerScopeDynamicWins**](DhcpServerScopeDynamicWins.md) |  | [optional] 
**AutoRule** | **bool** | Enable UPE Auto Rule. | [optional] 
**Ikev2** | [**VpnVpnIkev2**](VpnVpnIkev2.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

