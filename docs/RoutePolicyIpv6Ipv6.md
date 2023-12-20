# SonicWallGen7.Model.RoutePolicyIpv6Ipv6
IPv6 route policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarInterface** | **string** | Set route policy interface. | 
**Metric** | **decimal** | Set route policy metric. | 
**Source** | [**RoutePolicyIpv6Ipv6Source**](RoutePolicyIpv6Ipv6Source.md) |  | 
**Destination** | [**RoutePolicyIpv6Ipv6Destination**](RoutePolicyIpv6Ipv6Destination.md) |  | 
**App** | **string** | set route policy application match-object. | [optional] 
**Application** | **string** | set route policy application group. | [optional] 
**Service** | [**RoutePolicyIpv6Ipv6Service**](RoutePolicyIpv6Ipv6Service.md) |  | 
**Gateway** | [**RoutePolicyIpv6Ipv6Gateway**](RoutePolicyIpv6Ipv6Gateway.md) |  | 
**Tos** | **string** | Route policy TOS. | 
**Mask** | **string** | Route policy TOS mask. | 
**Distance** | [**RoutePolicyIpv6Ipv6Distance**](RoutePolicyIpv6Ipv6Distance.md) |  | 
**NexthopNumber** | **decimal** | the nexthop number. | [optional] 
**Interface2** | **string** | Set route policy 2nd interface. | [optional] 
**Gateway2** | [**RoutePolicyIpv6Ipv6Gateway2**](RoutePolicyIpv6Ipv6Gateway2.md) |  | [optional] 
**Interface3** | **string** | Set route policy 3rd interface. | [optional] 
**Gateway3** | [**RoutePolicyIpv6Ipv6Gateway3**](RoutePolicyIpv6Ipv6Gateway3.md) |  | [optional] 
**Interface4** | **string** | Set route policy 4th interface. | [optional] 
**Gateway4** | [**RoutePolicyIpv6Ipv6Gateway4**](RoutePolicyIpv6Ipv6Gateway4.md) |  | [optional] 
**Uuid** | **string** | Route policy UUID. | [optional] 
**Name** | **string** | Set route policy name. | [optional] 
**Type** | **string** | Set route policy type. | [optional] 
**Priority** | **decimal** | Set route policy priority. | [optional] 
**DisableOnInterfaceDown** | **bool** | Disable route when the interface is disconnected. | [optional] 
**VpnPrecedence** | **bool** | Allow VPN path to take precedence. | [optional] 
**AutoAddAccessRules** | **bool** | Enable auto-add access rules. | [optional] 
**Probe** | **string** | Set route policy network monitor object for probing. | [optional] 
**DisableWhenProbesSucceed** | **bool** | Disable route when probe succeeds. | [optional] 
**DefaultProbeStateUp** | **bool** | Set probe default state to up. | [optional] 
**Comment** | **string** | Set route policy comment. | [optional] 
**Ticket** | [**RoutePolicyIpv4Ipv4Ticket**](RoutePolicyIpv4Ipv4Ticket.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

