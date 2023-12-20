# SonicWallGen7.Model.DhcpServerBaseDhcpServerIpv4
Enter IPv4 DHCP server configuration mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable DHCP server. | [optional] 
**ConflictDetection** | **bool** | Enable DHCP server conflict detection. | [optional] 
**Persistence** | **bool** | Enable DHCP server persistence. | [optional] 
**PersistenceMonitoringInterval** | **decimal** | Set DHCP server persistence monitoring interval in minutes. | [optional] 
**TrustedRelayAgents** | **string** | Enable and set trusted DHCP relay agent list. * Set to null to represent an unconfigured state. | [optional] 
**RecycleExpiredLease** | **decimal?** | Enable aggressively recycle expired DHCP leases in advance. * Set to null to represent an unconfigured state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

