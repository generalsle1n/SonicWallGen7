# SonicWallGen7.Model.GatewayAntivirusGatewayAntivirus
Enter Gateway Anti-Virus Configuration Mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable Gateway Anti-Virus service. | [optional] 
**InboundInspection** | [**GatewayAntivirusGatewayAntivirusInboundInspection**](GatewayAntivirusGatewayAntivirusInboundInspection.md) |  | [optional] 
**OutboundInspection** | [**GatewayAntivirusGatewayAntivirusOutboundInspection**](GatewayAntivirusGatewayAntivirusOutboundInspection.md) |  | [optional] 
**Restrict** | [**GatewayAntivirusGatewayAntivirusRestrict**](GatewayAntivirusGatewayAntivirusRestrict.md) |  | [optional] 
**ExclusionObject** | [**GatewayAntivirusGatewayAntivirusExclusionObject**](GatewayAntivirusGatewayAntivirusExclusionObject.md) |  | [optional] 
**SmtpResponses** | **bool** | Enable SMTP responses. | [optional] 
**EicarDetection** | **bool** | Enable detection of EICAR test virus. | [optional] 
**HttpByteRange** | **bool** | Enable HTTP Byte-Range requests with Gateway AV. | [optional] 
**FtpRest** | **bool** | Enable FTP &#39;REST&#39; requests with Gateway AV. | [optional] 
**ScanHighCompression** | **bool** | Scan parts of files with high compression ratios. | [optional] 
**BlockMultipleCompressFiles** | **bool** | Enable to block files with multiple levels of zip/gzip compression. | [optional] 
**DetectionOnly** | **bool** | Enable detection only mode. | [optional] 
**HttpClientlessNotification** | **bool** | Enable HTTP Clientless Notification Alerts. | [optional] 
**NotificationMessage** | **string** | Set HTTP Clientless Notification Message to display when blocking. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

