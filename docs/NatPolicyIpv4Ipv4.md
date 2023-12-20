# SonicWallGen7.Model.NatPolicyIpv4Ipv4
IPv4 NAT policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inbound** | **string** | Specify the inbound interface for the NAT policy. | 
**Outbound** | **string** | Specify the outbound interface for the NAT policy. | 
**Source** | [**NatPolicyIpv4Ipv4Source**](NatPolicyIpv4Ipv4Source.md) |  | 
**TranslatedSource** | [**NatPolicyIpv4Ipv4TranslatedSource**](NatPolicyIpv4Ipv4TranslatedSource.md) |  | 
**Destination** | [**NatPolicyIpv4Ipv4Destination**](NatPolicyIpv4Ipv4Destination.md) |  | 
**TranslatedDestination** | [**NatPolicyIpv4Ipv4TranslatedDestination**](NatPolicyIpv4Ipv4TranslatedDestination.md) |  | 
**Service** | [**NatPolicyIpv4Ipv4Service**](NatPolicyIpv4Ipv4Service.md) |  | 
**TranslatedService** | [**NatPolicyIpv4Ipv4TranslatedService**](NatPolicyIpv4Ipv4TranslatedService.md) |  | 
**Uuid** | **string** | Nat policy UUID. | [optional] 
**Name** | **string** | Nat policy name. | [optional] 
**Enable** | **bool** | Enable NAT policy. | [optional] 
**Priority** | [**NatPolicyIpv4Ipv4Priority**](NatPolicyIpv4Ipv4Priority.md) |  | [optional] 
**Comment** | **string** | Set comment to help identify this NAT policy. | [optional] 
**Ticket** | [**NatPolicyIpv4Ipv4Ticket**](NatPolicyIpv4Ipv4Ticket.md) |  | [optional] 
**DnsDoctoring** | **bool** | Enable NAT policy DNS doctoring. | [optional] 
**Reflexive** | **bool** | Configure a reflexive rule. | [optional] 
**NatMethod** | **string** | Set the NAT destination translation method. | [optional] 
**SourcePortRemap** | **bool** | Enable source port remap. | [optional] 
**HighAvailability** | [**NatPolicyIpv4Ipv4HighAvailability**](NatPolicyIpv4Ipv4HighAvailability.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

