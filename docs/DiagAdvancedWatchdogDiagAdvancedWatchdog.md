# SonicWallGen7.Model.DiagAdvancedWatchdogDiagAdvancedWatchdog
Configure advanced diag watchdog settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebServerWatchdog** | **bool** | Enable web server watchdog. | [optional] 
**RestartOnWebServerHang** | **bool** | Enable watchdog restart on web server hang. | [optional] 
**RestartOnFdLeak** | **bool** | Enable watchdog restart on fd leak. | [optional] 
**RestartWhenNoPacketRx** | **bool** | Enable rstart when no packet Rx activity is detected. | [optional] 
**WaitForNoPacketRx** | **decimal** | Set no packet Rx activity wait time in seconds. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

