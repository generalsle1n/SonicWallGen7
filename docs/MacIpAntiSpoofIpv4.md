# SonicWallGen7.Model.MacIpAntiSpoofIpv4
MAC IP anti-spoof IPv4 interfaces configuration schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Configure MAC-IP anti-spoof for the specified interface. | 
**Enable** | **bool** | Enable MAC-IP based anti-spoofing on this interface. | [optional] 
**StaticArp** | **bool** | Enable population of MAC-IP anti-spoof from static ARP entries. | [optional] 
**DhcpServer** | **bool** | Enable population of MAC-IP anti-spoof entry from DHCP lease (SonicWall&#39;s DHCP server). | [optional] 
**DhcpRelay** | **bool** | Enable population of MAC-IP anti-spoof entry from DHCP lease (DHCP relay - IP helper). | [optional] 
**ArpLock** | **bool** | Enable locking of MAC-IP binding in ARP cache to prevent ARP poisoning from others. | [optional] 
**ArpWatch** | **bool** | Enable prevention of ARP poisoning of connected machines. | [optional] 
**EnforceIngress** | **bool** | Enable enforcement of ingress anti-spoof - drop packets not matching MAC-IP anti-spoof cache. | [optional] 
**SpoofDetection** | **bool** | Enable creation of MAC-IP spoof detected list for packets failing to match anti-spoof cache. | [optional] 
**AllowManagement** | **bool** | Enable all traffic destined to the box to be allowed without a valid MAC-IP anti-spoof cache. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

