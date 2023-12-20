# SonicWallGen7.Model.HaBaseHighAvailability
Configure high availability.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HeartbeatInterval** | **decimal** | Set heartbeat interval in milliseconds. | [optional] 
**FailoverTriggerLevel** | **decimal** | Set Failover trigger level (missed heartbeats). | [optional] 
**Probe** | [**HaBaseHighAvailabilityProbe**](HaBaseHighAvailabilityProbe.md) |  | [optional] 
**ElectionDelayTime** | **decimal** | Set election delay time in seconds. | [optional] 
**RouteHoldDownTime** | [**HaBaseHighAvailabilityRouteHoldDownTime**](HaBaseHighAvailabilityRouteHoldDownTime.md) |  | [optional] 
**SdwanHoldDownTime** | **decimal** | Set SD-WAN probes hold-down time in seconds. | [optional] 
**IncludeCertificatesKeys** | **bool** | Enable include certificates and keys. | [optional] 
**L3Mode** | [**HaBaseHighAvailabilityL3Mode**](HaBaseHighAvailabilityL3Mode.md) |  | [optional] 
**Mode** | [**HaBaseHighAvailabilityMode**](HaBaseHighAvailabilityMode.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

