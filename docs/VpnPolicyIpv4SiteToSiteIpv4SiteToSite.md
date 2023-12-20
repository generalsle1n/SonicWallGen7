# SonicWallGen7.Model.VpnPolicyIpv4SiteToSiteIpv4SiteToSite
Site to site VPN policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Policy name. | 
**Enable** | **bool** | Enable VPN policy. | [optional] 
**AuthMethod** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethod**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteAuthMethod.md) |  | [optional] 
**Gateway** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteGateway**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteGateway.md) |  | [optional] 
**Proposal** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposal**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposal.md) |  | [optional] 
**Network** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetwork**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetwork.md) |  | [optional] 
**KeepAlive** | **bool** | Enable VPN policy keep alive. | [optional] 
**SuppressAutoAddRule** | **bool** | Enable suppress automatic access rules creation for VPN policy. | [optional] 
**RequireXauth** | **string** | Enable XAUTH checking for VPN policy. | [optional] 
**AntiReplay** | **bool** | Enable anti replay. | [optional] 
**Netbios** | **bool** | Enable VPN policy NetBIOS. | [optional] 
**Multicast** | **bool** | Enable VPN policy multicast. | [optional] 
**ApplyNat** | **bool** | Enable apply NAT policies. | [optional] 
**TranslatedNetwork** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteTranslatedNetwork**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteTranslatedNetwork.md) |  | [optional] 
**OcspChecking** | **bool** | Enable and configure OCSP checking. | [optional] 
**ResponderUrl** | **string** | OCSP responder URL. | [optional] 
**Management** | [**VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement**](VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement.md) |  | [optional] 
**UserLogin** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin.md) |  | [optional] 
**DefaultLanGateway** | **string** | Configure LAN default gateway. | [optional] 
**BoundTo** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteBoundTo**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteBoundTo.md) |  | [optional] 
**PreemptSecondaryGateway** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSitePreemptSecondaryGateway**](VpnPolicyIpv4SiteToSiteIpv4SiteToSitePreemptSecondaryGateway.md) |  | [optional] 
**SuppressTriggerPacket** | **bool** | Do not send trigger packet during IKE SA negotiation for IKEv2. | [optional] 
**AcceptHash** | **bool** | Accept hash &amp; URL certificate type for IKEv2. | [optional] 
**SendHash** | **string** | Enable send hash &amp; URL certificate type for IKEv2 and specify url. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

