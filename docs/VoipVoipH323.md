# SonicWallGen7.Model.VoipVoipH323
Enter H.323 transformations configure mode. * Set to null or {} to represent  an unconfigured state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable H.323 transformations. | [optional] 
**AccessRuleBased** | **bool** | Set H.323 transformation will be performed only when it is enabled on the corresponding firewall access rule. | [optional] 
**OnlyGatekeeperCalls** | **bool** | Enable only accept incoming calls from gatekeeper. | [optional] 
**InactivityTimeout** | **decimal** | Set H.323 signaling/media inactivity time out (seconds). | [optional] 
**GatekeeperIp** | **string** | Set default wan/dmz gatekeeper IP address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

