# SonicWallGen7.Model.MacIpAntiSpoofIpv6
MAC IP anti-spoof IPv6 interfaces configuration schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Configure IPv6 MAC-IP anti-spoof for the specified interface. | 
**Enable** | **bool** | Enable MAC-IP based anti-spoofing on this interface. | [optional] 
**StaticNdp** | **bool** | Enable population of MAC-IP anti-spoof from static NDP entries. | [optional] 
**NdpLock** | **bool** | Enable locking of IPv6 MAC-IP binding in NDP cache to prevent NDP poisoning from others. | [optional] 
**EnforceIngress** | **bool** | Enable enforcement of ingress anti-spoof - drop packets not matching MAC-IP anti-spoof cache. | [optional] 
**SpoofDetection** | **bool** | Enable creation of MAC-IP spoof detected list for packets failing to match anti-spoof cache. | [optional] 
**AllowManagement** | **bool** | Enable all traffic destined to the box to be allowed without a valid MAC-IP anti-spoof cache. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

