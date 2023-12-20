# SonicWallGen7.Model.UserSsoBaseUserSsoProbe
Probe user IP addresses before attempting SSO. * Set to null or {} to represent  an unconfigured state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Netapi** | [**UserSsoBaseUserSsoProbeNetapi**](UserSsoBaseUserSsoProbeNetapi.md) |  | [optional] 
**Wmi** | **bool** | Probe for WMI. | [optional] 
**Timeout** | **decimal** | Set timeout for probing IP addresses. | [optional] 
**TestMode** | **bool** | Enable probe test-mode.                Probe test mode allows testing that SSO probes are functioning correctly                during SSO without their interfering with the user authentications | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

