# SonicWallGen7.Model.PoliciesSettingBasePoliciesSetting
Enter policies setting configuration mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockConnections** | [**PoliciesSettingBasePoliciesSettingBlockConnections**](PoliciesSettingBasePoliciesSettingBlockConnections.md) |  | [optional] 
**ActiveApplicationCaching** | **bool** | Enable active application caching. | [optional] 
**CachedApplicationBypass** | **bool** | Enable cached applications to bypass DPI. | [optional] 
**ApplicationCache** | [**PoliciesSettingBasePoliciesSettingApplicationCache**](PoliciesSettingBasePoliciesSettingApplicationCache.md) |  | [optional] 
**SslServerInspection** | **bool** | Enable SSL server inspection. | [optional] 
**BypassDecryption** | [**PoliciesSettingBasePoliciesSettingBypassDecryption**](PoliciesSettingBasePoliciesSettingBypassDecryption.md) |  | [optional] 
**PolicyBasedDosProtection** | **bool** | Enable policy-based DoS protection. | [optional] 
**AppCustomMalwareMode** | **string** | Set application, custom match and malware (threats, virus and spyware) control plus prevention mode. | [optional] 
**ApplicationBasedOn** | **string** | Set what application classification (identification) is based on. | [optional] 
**ThreatBasedOn** | **string** | Set what threat detection and prevention is based on. | [optional] 
**AntispywareBasedOn** | **string** | Set what Anti-Spyware prevention profile is based on. | [optional] 
**AntivirusBasedOn** | **string** | Set what Anti-Virus prevention profile is based on. | [optional] 
**GeoipMode** | **string** | Set Geo-IP control and enforcement mode. | [optional] 
**GeoipInspectionBasedOn** | **string** | Set what Geo-IP resolution and inspection is based on. | [optional] 
**BotnetMode** | **string** | Set Botnet filter control and enforcement mode. | [optional] 
**DpisslMode** | **string** | Set decryption (DPI-SSL) control and enforcement mode. | [optional] 
**DpisshMode** | **string** | Set decryption (DPI-SSH) control and enforcement mode. | [optional] 
**DosMode** | **string** | Set DoS control and enforcement mode. | [optional] 
**SynFlood** | **string** | Set SYN flood protection mode. | [optional] 
**UdpFlood** | **string** | Set UDP flood protection mode. | [optional] 
**IcmpFlood** | **string** | Set ICMP flood protection mode. | [optional] 
**Attack** | **string** | Set attack protection mode. | [optional] 
**Ddos** | **string** | Set DDoS protection mode. | [optional] 
**ThreatProfileForZone** | [**PoliciesSettingBasePoliciesSettingThreatProfileForZone**](PoliciesSettingBasePoliciesSettingThreatProfileForZone.md) |  | [optional] 
**AntispywareProfileForZone** | [**PoliciesSettingBasePoliciesSettingAntispywareProfileForZone**](PoliciesSettingBasePoliciesSettingAntispywareProfileForZone.md) |  | [optional] 
**AntivirusProfileForZone** | [**PoliciesSettingBasePoliciesSettingAntivirusProfileForZone**](PoliciesSettingBasePoliciesSettingAntivirusProfileForZone.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

