# SonicWallGen7.Model.DosActionProfile
DoS action object configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of DoS action profile. | 
**Uuid** | **string** | Name of DoS action profile. | [optional] [readonly] 
**SynFloodProtection** | [**DosActionProfileSynFloodProtection**](DosActionProfileSynFloodProtection.md) |  | [optional] 
**SynAttackThreshold** | [**DosActionProfileSynAttackThreshold**](DosActionProfileSynAttackThreshold.md) |  | [optional] 
**TcpSack** | **bool** | Enable TCP SACK option support. | [optional] 
**LimitMss** | [**DosActionProfileLimitMss**](DosActionProfileLimitMss.md) |  | [optional] 
**LogSynPackets** | **bool** | Enable always log SYN packets received. | [optional] 
**SynFloodBlacklisting** | **bool** | Enable SYN/RST/FIN flood blacklisting. | [optional] 
**BlacklistThreshold** | **decimal** | Set threshold for SYN/RST/FIN flood blacklisting (packets / sec). | [optional] 
**NeverBlacklistWan** | **bool** | Enable never blacklist WAN machines. | [optional] 
**Management** | **bool** | Enable always allow SonicWall management traffic. | [optional] 
**UdpFloodProtection** | **bool** | Enable UDP flood protection. | [optional] 
**UdpFloodAttack** | [**DosActionProfileUdpFloodAttack**](DosActionProfileUdpFloodAttack.md) |  | [optional] 
**IcmpFloodProtection** | **bool** | Enable ICMP flood protection. | [optional] 
**IcmpFloodAttack** | [**DosActionProfileIcmpFloodAttack**](DosActionProfileIcmpFloodAttack.md) |  | [optional] 
**Ddos** | [**DosActionProfileDdos**](DosActionProfileDdos.md) |  | [optional] 
**SpankProtection** | **bool** | Enable spank protection. | [optional] 
**SmurfProtection** | **bool** | Enable smurf protection. | [optional] 
**LandAttackProtection** | **bool** | Enable land-attack protection. | [optional] 
**ConnectionLimit** | [**DosActionProfileConnectionLimit**](DosActionProfileConnectionLimit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

