# SonicWallGen7.Model.VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface
Tunnel interface VPN policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Policy name. | 
**Enable** | **bool** | Enable VPN policy. | [optional] 
**AuthMethod** | [**VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethod**](VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethod.md) |  | [optional] 
**Gateway** | [**VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceGateway**](VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceGateway.md) |  | [optional] 
**Proposal** | [**VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposal**](VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposal.md) |  | [optional] 
**KeepAlive** | **bool** | Enable VPN policy keep alive. | [optional] 
**AntiReplay** | **bool** | Enable anti replay. | [optional] 
**AdvancedRouting** | **bool** | Enable allow advanced routing. | [optional] 
**TransportMode** | **bool** | Enable transport mode. | [optional] 
**Netbios** | **bool** | Enable VPN policy NetBIOS. | [optional] 
**Multicast** | **bool** | Enable VPN policy multicast. | [optional] 
**ApplyNat** | **bool** | Enable apply NAT policies. | [optional] 
**OcspChecking** | **bool** | Enable and configure OCSP checking. | [optional] 
**ResponderUrl** | **string** | OCSP responder URL. | [optional] 
**Management** | [**VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement**](VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement.md) |  | [optional] 
**UserLogin** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin.md) |  | [optional] 
**BoundTo** | [**VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceBoundTo**](VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceBoundTo.md) |  | [optional] 
**SuppressTriggerPacket** | **bool** | Do not send trigger packet during IKE SA negotiation for IKEv2. | [optional] 
**AcceptHash** | **bool** | Accept hash &amp; URL certificate type for IKEv2. | [optional] 
**SendHash** | **string** | Enable send hash &amp; URL certificate type for IKEv2 and specify url. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

