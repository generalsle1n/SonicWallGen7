# SonicWallGen7.Model.NatPolicyIpv6Ipv6
IPv6 NAT policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inbound** | **string** | Specify the inbound interface for the NAT policy. | 
**Outbound** | **string** | Specify the outbound interface for the NAT policy. | 
**Source** | [**NatPolicyIpv6Ipv6Source**](NatPolicyIpv6Ipv6Source.md) |  | 
**TranslatedSource** | [**NatPolicyIpv6Ipv6TranslatedSource**](NatPolicyIpv6Ipv6TranslatedSource.md) |  | 
**Destination** | [**NatPolicyIpv6Ipv6Destination**](NatPolicyIpv6Ipv6Destination.md) |  | 
**TranslatedDestination** | [**NatPolicyIpv6Ipv6TranslatedDestination**](NatPolicyIpv6Ipv6TranslatedDestination.md) |  | 
**Service** | [**NatPolicyIpv6Ipv6Service**](NatPolicyIpv6Ipv6Service.md) |  | 
**TranslatedService** | [**NatPolicyIpv6Ipv6TranslatedService**](NatPolicyIpv6Ipv6TranslatedService.md) |  | 
**Uuid** | **string** | Nat policy UUID. | [optional] 
**Name** | **string** | Nat policy name. | [optional] 
**Enable** | **bool** | Enable NAT policy. | [optional] 
**Priority** | [**NatPolicyIpv6Ipv6Priority**](NatPolicyIpv6Ipv6Priority.md) |  | [optional] 
**Comment** | **string** | Set comment to help identify this NAT policy. | [optional] 
**Ticket** | [**NatPolicyIpv4Ipv4Ticket**](NatPolicyIpv4Ipv4Ticket.md) |  | [optional] 
**Reflexive** | **bool** | Configure a reflexive rule. | [optional] 
**NatMethod** | **string** | Set the NAT destination translation method. | [optional] 
**SourcePortRemap** | **bool** | Enable source port remap. | [optional] 
**HighAvailability** | [**NatPolicyIpv6Ipv6HighAvailability**](NatPolicyIpv6Ipv6HighAvailability.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

