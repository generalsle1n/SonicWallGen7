# SonicWallGen7.Model.DiagAdvancedNetworkDiagAdvancedNetwork
Configure advanced diag network and routing settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FlushAlternatePathFlows** | **bool** | Enable flushing flows on alternate path when normal route path is enabled (affects existing connections). | [optional] 
**UpdateRouteVersion** | **bool** | Enable updating route version when route is enabled/disabled (affects existing connections). | [optional] 
**TcpPacketOptionTagging** | **bool** | Enable TCP packet option tagging. | [optional] 
**FixMalformedTcpHeaders** | **bool** | Enable fix/ignore malformed TCP headers. | [optional] 
**SequenceNumberRandomization** | **bool** | Enable TCP sequence number randomization. | [optional] 
**SynValidation** | **bool** | Enable performing SYN validation when not operating in strict TCP compliance mode. | [optional] 
**DebounceInterfaceStateChanges** | **bool** | Enable Debounce Interface State Changes for routing protocols | [optional] 
**ClearDfBit** | **bool** | Enable clear DF (don&#39;t fragment) bit. | [optional] 
**SmallerFirstFragment** | **bool** | Enable smaller first fragment packets. | [optional] 
**Ipv6SmallFragment** | **bool** | Enable IPv6 Fragmentation Packets smaller than 1280 bytes. | [optional] 
**OverrideMac** | **bool** | Enable override MAC address when NAT. | [optional] 
**DropRecordRoute** | **bool** | Enable droping record route packets. | [optional] 
**AdvertiseFqdnRoute** | **bool** | Enable advertisement of FQDN based policy route to dynamic routing protocol. | [optional] 
**GenerateInterfaceDefaultRoute** | **bool** | Generate an interface specific default route. | [optional] 
**ZebosGranularDebug** | **bool** | Enable granular debug in routing protocols. | [optional] 
**DmzIcmpRedirect** | **bool** | Enable ICMP redirect on DMZ zone. | [optional] 
**EnforceStrictTcpComplianceRfc5961** | **bool** | Enforce Strict TCP Compliance with RFC5961 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

