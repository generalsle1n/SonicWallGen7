# SonicWallGen7.Model.NatPolicyIpv4Ipv4HighAvailabilityProbing
Enable HA probing and enter configuration mode. * Set to null or {} to represent  an unconfigured state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProbeEvery** | **decimal** | Probe interval (in seconds). | [optional] 
**ProbeType** | [**NatPolicyIpv4Ipv4HighAvailabilityProbingProbeType**](NatPolicyIpv4Ipv4HighAvailabilityProbingProbeType.md) |  | [optional] 
**ReplyTimeout** | **decimal** | Set reply timeout (in seconds). | [optional] 
**DeactivateAfter** | **decimal** | Set number of missed probes required before deactivating the NAT policy. | [optional] 
**ReactivateAfter** | **decimal** | Set number of successful probes required before reactivating the NAT policy. | [optional] 
**RstAsMiss** | **bool** | Enable count RST response as miss. | [optional] 
**PortProbing** | **bool** | Enable port probing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

