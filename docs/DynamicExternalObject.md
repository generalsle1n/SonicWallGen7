# SonicWallGen7.Model.DynamicExternalObject
Dynamic external object configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Edit dynamic external object name. | 
**Type** | [**DynamicExternalObjectType**](DynamicExternalObjectType.md) |  | [optional] 
**Zone** | **string** | Set dynamic external object zon. | [optional] 
**Fqdn** | **bool** | Enable dynamic external object FQDN flag. | [optional] 
**PeriodicDownload** | [**DynamicExternalObjectPeriodicDownload**](DynamicExternalObjectPeriodicDownload.md) |  | [optional] 
**Protocol** | **string** | Set the dynamic external object download protocol. | [optional] 
**Url** | **string** | Set the external dynamic object HTTPS URL. | [optional] 
**Server** | [**DynamicExternalObjectServer**](DynamicExternalObjectServer.md) |  | [optional] 
**Login** | **string** | Set the external dynamic object FTP server&#39;s login name. | [optional] 
**Password** | **string** | Set the external dynamic object FTP server&#39;s login password. * Set to null to represent an unconfigured state. | [optional] 
**Directory** | **string** | Set the external dynamic object FTP server&#39;s directory path. * Set to null to represent an unconfigured state. | [optional] 
**Filename** | **string** | Set the external dynamic object FTP server&#39;s filename. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

