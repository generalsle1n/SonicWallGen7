# SonicWallGen7.Model.VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsec
IPsec (phase 2) proposal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Protocol** | **string** | Protocol. | [optional] 
**Encryption** | [**VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecEncryption**](VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecEncryption.md) |  | [optional] 
**Authentication** | [**VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication**](VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposalIpsecAuthentication.md) |  | [optional] 
**PerfectForwardSecrecy** | [**VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecPerfectForwardSecrecy**](VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecPerfectForwardSecrecy.md) |  | [optional] 
**Lifetime** | **decimal** | Life time (seconds). | [optional] 
**Lifebytes** | **decimal** | Life bytes (kb). | [optional] 
**InSpi** | **string** | Configure incoming SPI. | [optional] 
**OutSpi** | **string** | Configure outgoing SPI. | [optional] 
**EncryptionKey** | **string** | Configure encryption key. | [optional] 
**AuthenticationKey** | **string** | Configure authentication key. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

