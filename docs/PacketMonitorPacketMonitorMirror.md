# SonicWallGen7.Model.PacketMonitorPacketMonitorMirror
Set mirror params.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxRate** | **decimal** | Set maximum mirror rate (in kilobits per second). | [optional] 
**OnlyIpPackets** | **bool** | Enable mirror only IP packets. | [optional] 
**VarInterface** | **string** | Mirror filtered packets to interface. | [optional] 
**Ip** | **string** | Mirror filtered packets to remote SonicWall firewall (IP address). | [optional] 
**ReceiveFromIp** | **string** | Receive mirrored packets from remote SonicWall firewall (IP address). | [optional] 
**ForwardInterface** | **string** | Send received remote mirrored packets to interface. | [optional] 
**ToCaptureBuffer** | **bool** | Enable sending received remote mirrored packets to capture                buffer. | [optional] 
**EncryptKey** | **string** | Encrypt remote mirrored packets via IPSec (preshared key-IKE). | [optional] 
**DecryptKey** | **string** | Decrypt remote mirrored packets via IPSec (preshared key-IKE). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

