# SonicWallGen7.Model.DiagAdvancedSecurityServiceDiagAdvancedSecurityService
Configure advanced diag security services settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DpiEngine** | **bool** | Enable DPI engine. | [optional] 
**BidirectionalIps** | **bool** | Enable applying IPS signatures bidirectionally. | [optional] 
**DpiIpFragmentReassembly** | **bool** | Enable IP fragment reassembly in DPI. | [optional] 
**DevDebug** | **bool** | Enable extra dev debug info. | [optional] 
**TcpSequenceAdjustment** | **bool** | Enable TCP expected sequence adjustment in DPI. | [optional] 
**ProxyEmailPackets** | **bool** | Enable proxy email packets in DPI. | [optional] 
**SmtpChunkingModification** | **bool** | Enable App-Firewall SMTP CHUNKING modification. | [optional] 
**Pop3AutoDeletion** | **bool** | Enable gateway AV POP3 auto deletion. | [optional] 
**Pop3UidlRewriting** | **bool** | Enable gateway AV POP3 UIDL rewriting. | [optional] 
**SmbReadWriteEnforcement** | **bool** | Enable gateway AV SMB read/write ordering enforcement. | [optional] 
**KeepHttpAcceptRangeBytes** | **bool** | Keep HTTP header Accept-range: bytes. | [optional] 
**LogVirusUri** | **bool** | Enable log virus URI. | [optional] 
**OffsetQualifierSignature** | **bool** | Enable apply signatures containing file offset qualifiers. | [optional] 
**MinimumHttpHeaderLength** | **decimal** | Set minimum HTTP header length (0 to disable). | [optional] 
**IncrementalSignatureUpdates** | **bool** | Enable incremental updates to IDP, GAV and SPY signature databases. | [optional] 
**HandleHttp2** | **bool** | Enable handle HTTP/2. | [optional] 
**ForceUtmOffload** | **bool** | Enable force UTM offload. | [optional] 
**UtmTrafficOffload** | **decimal** | Set Active/Active UTM traffic Offload percentage. | [optional] 
**LimitDpiTcpWindowAdvertisement** | [**DiagAdvancedSecurityServiceDiagAdvancedSecurityServiceLimitDpiTcpWindowAdvertisement**](DiagAdvancedSecurityServiceDiagAdvancedSecurityServiceLimitDpiTcpWindowAdvertisement.md) |  | [optional] 
**ThresholdLimit** | **decimal** | Threshold above which size limits are enforced on regex automaton. | [optional] 
**MaximumRegexAutomatonSize** | **decimal** | Maximum allowed size for regex automaton. | [optional] 
**SignatureDatabaseReload** | **bool** | Enable signature database reload. | [optional] 
**ProcessIpsSignatures** | **bool** | Enable processing of IPS signatures. | [optional] 
**ProcessGavSignatures** | **bool** | Enable processing of GAV signatures. | [optional] 
**ProcessAntiSpywareSignatures** | **bool** | Enable processing of Anti-Spyware signatures. | [optional] 
**ProcessAppSignatures** | **bool** | Enable processing of App signatures. | [optional] 
**OptimalValue** | [**DiagAdvancedSecurityServiceDiagAdvancedSecurityServiceOptimalValue**](DiagAdvancedSecurityServiceDiagAdvancedSecurityServiceOptimalValue.md) |  | [optional] 
**LimitIpsCftScan** | **bool** | Enable limit IPS CFT scan. | [optional] 
**EnforceCfsHostTagSearch** | **bool** | Enable enforcement of host tag search for CFS. | [optional] 
**LocalCfsServer** | [**DiagAdvancedSecurityServiceDiagAdvancedSecurityServiceLocalCfsServer**](DiagAdvancedSecurityServiceDiagAdvancedSecurityServiceLocalCfsServer.md) |  | [optional] 
**CloudAvServer** | [**DiagAdvancedSecurityServiceDiagAdvancedSecurityServiceCloudAvServer**](DiagAdvancedSecurityServiceDiagAdvancedSecurityServiceCloudAvServer.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

