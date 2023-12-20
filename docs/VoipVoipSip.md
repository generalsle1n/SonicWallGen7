# SonicWallGen7.Model.VoipVoipSip
Enter SIP transformations configure mode. * Set to null or {} to represent  an unconfigured state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable SIP transformations. | [optional] 
**AccessRuleBased** | **bool** | Set SIP transformation will be performed only when it is enabled on the corresponding firewall access rule. | [optional] 
**Tcp** | **bool** | Enable transformations on TCP connections. | [optional] 
**TransformsInServiceObject** | [**VoipVoipSipTransformsInServiceObject**](VoipVoipSipTransformsInServiceObject.md) |  | [optional] 
**NonSipPackets** | **bool** | Enable permit non-SIP packets on signaling port. | [optional] 
**B2buaSupport** | **bool** | Enable SIP back-to-back user agent (B2BUA) support. | [optional] 
**SignalingTimeout** | **decimal** | Set SIP signaling inactivity time out (seconds). | [optional] 
**MediaTimeout** | **decimal** | Set SIP media inactivity time out (seconds). | [optional] 
**SignalingPort** | [**VoipVoipSipSignalingPort**](VoipVoipSipSignalingPort.md) |  | [optional] 
**EndpointRegistrationAnomalyTracking** | **bool** | Enable SIP endpoint registration anomaly tracking. | [optional] 
**RegistrationTrackingInterval** | **decimal** | Set SIP registration tracking interval (seconds). | [optional] 
**FailedRegistrationThreshold** | **decimal** | Set SIP failed registration threshold. | [optional] 
**EndpointBlockInterval** | **decimal** | Set endpoint block interval(seconds) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

