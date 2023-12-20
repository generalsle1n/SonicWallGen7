# SonicWallGen7.Model.DiagAdvancedArpDiagAdvancedArp
Configure advanced diag ARP settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bridging** | **bool** | Enable ARP bridging. | [optional] 
**OpenArpBehavior** | **bool** | Enable open ARP behavior (WARNING: Insecure!!). | [optional] 
**SourceIpValidation** | **bool** | Enable source IP address validation for being directly connected. | [optional] 
**OnlyUnicast** | **bool** | Enable only allowing ARP entries with unicast addresses. | [optional] 
**LimitNonresponsive** | **bool** | Enable limiting ARPs of non-responsive IPs. | [optional] 
**RedundantIpResolutionRate** | [**DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate**](DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate.md) |  | [optional] 
**GratuitousArpCompatibility** | **bool** | Enable gratuitous ARP compatibility mode. | [optional] 
**SecondarySubnet** | **bool** | Enable ARP responses for secondary subnets on WAN Interfaces. | [optional] 
**GratuitousArpLimit** | [**DiagAdvancedArpDiagAdvancedArpGratuitousArpLimit**](DiagAdvancedArpDiagAdvancedArpGratuitousArpLimit.md) |  | [optional] 
**SystemBroadcast** | [**DiagAdvancedArpDiagAdvancedArpSystemBroadcast**](DiagAdvancedArpDiagAdvancedArpSystemBroadcast.md) |  | [optional] 
**IgnoreArpsWithPrimaryMacFromOtherIf** | **bool** | Enable ignore ARPs with primary-gateway&#39;s MAC received on other interfaces. | [optional] 
**DisplayMacTracking** | **bool** | Enable displaying of MAC tracking. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

