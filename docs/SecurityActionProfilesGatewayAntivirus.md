# SonicWallGen7.Model.SecurityActionProfilesGatewayAntivirus
Enter security policy gateway anti-Virus configuration mod.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable gateway anti-virus. | [optional] 
**Cloud** | **bool** | Enable cloud gateway anti-virus database. | [optional] 
**Inbound** | **bool** | Enable inbound inspection. | [optional] 
**Outbound** | **bool** | Enable outbound inspection for the specified protocols. | [optional] 
**Prevent** | **bool** | Disable prevention. | [optional] 
**PacketMonitor** | **bool** | Enable packet monitor. | [optional] 
**Log** | **bool** | Enable log. | [optional] 
**PasswordProtectedZip** | **bool** | Disable restricting transfer of password-protected ZIP files. | [optional] 
**MsOfficeMacros** | **bool** | Disable restricting transfer of MS-Office type files containing macros (VBA 5 and above). | [optional] 
**PackedExecutables** | **bool** | Disable restricting transfer of packed executable files (UPX, FSG, etc.). | [optional] 
**SmtpResponses** | **bool** | Enable SMTP responses. | [optional] 
**EicarDetection** | **bool** | Enable detection of EICAR test virus. | [optional] 
**HttpByteRange** | **bool** | Enable HTTP Byte-Range requests with Gateway AV. | [optional] 
**FtpRest** | **bool** | Enable FTP &#39;REST&#39; requests with Gateway AV. | [optional] 
**ScanHighCompression** | **bool** | Scan parts of files with high compression ratios. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

