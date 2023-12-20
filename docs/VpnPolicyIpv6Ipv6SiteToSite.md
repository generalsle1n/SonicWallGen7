# SonicWallGen7.Model.VpnPolicyIpv6Ipv6SiteToSite
IPv6 site to site VPN policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Policy name. | 
**Enable** | **bool** | Enable VPN policy. | [optional] 
**AuthMethod** | [**VpnPolicyIpv6Ipv6SiteToSiteAuthMethod**](VpnPolicyIpv6Ipv6SiteToSiteAuthMethod.md) |  | [optional] 
**Gateway** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteGateway**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteGateway.md) |  | [optional] 
**Network** | [**VpnPolicyIpv6Ipv6SiteToSiteNetwork**](VpnPolicyIpv6Ipv6SiteToSiteNetwork.md) |  | [optional] 
**Proposal** | [**VpnPolicyIpv6Ipv6SiteToSiteProposal**](VpnPolicyIpv6Ipv6SiteToSiteProposal.md) |  | [optional] 
**KeepAlive** | **bool** | Enable VPN policy keep alive. | [optional] 
**AntiReplay** | **bool** | Enable anti replay. | [optional] 
**Management** | [**VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement**](VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement.md) |  | [optional] 
**BoundTo** | [**VpnPolicyIpv6Ipv6SiteToSiteBoundTo**](VpnPolicyIpv6Ipv6SiteToSiteBoundTo.md) |  | [optional] 
**LocalIp** | [**VpnPolicyIpv6Ipv6SiteToSiteLocalIp**](VpnPolicyIpv6Ipv6SiteToSiteLocalIp.md) |  | [optional] 
**PreemptSecondaryGateway** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSitePreemptSecondaryGateway**](VpnPolicyIpv4SiteToSiteIpv4SiteToSitePreemptSecondaryGateway.md) |  | [optional] 
**SuppressTriggerPacket** | **bool** | Do not send trigger packet during IKE SA negotiation for IKEv2. | [optional] 
**AcceptHash** | **bool** | Accept hash &amp; URL certificate type for IKEv2. | [optional] 
**SendHash** | **string** | Enable send hash &amp; URL certificate type for IKEv2 and specify url. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

