# SonicWallGen7.Model.DiagAdvancedDhcpDiagAdvancedDhcp
Configure advanced diag DHCP settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkPreDiscovery** | **bool** | Enable DHCP server network pre-discovery. | [optional] 
**ConflictDetectPeriod** | **decimal** | Set the DHCP server conflict detect period in seconds. | [optional] 
**ResourcesToDiscover** | **decimal** | Set number of DHCP resources to discover. | [optional] 
**ConflictedResourceTimeout** | **decimal** | Set the timeout for conflicted resource to be rechecked in seconds. | [optional] 
**AvailableResourceTimeout** | **decimal** | Set the timeout for available resource to be rechecked in seconds. | [optional] 
**Dhcpnak** | **bool** | Enable sending DHCPNAK if the &#39;requested IP address&#39; is on the wrong network. | [optional] 
**LeaseDatabaseRefreshInterval** | **decimal** | Set time interval of DHCP lease database to be refreshed in seconds. | [optional] 
**LeaseDatabaseRefreshNumber** | **decimal** | Set number of DHCP leases in database to be refreshed. | [optional] 
**UseClientEthernerAddress** | **bool** | Enable use client Etherner address instead of client-identifier option. | [optional] 
**UseUnicastAndLinkLayer** | **bool** | Enable use unicast dst ip address and link-layer address when unicast flag is set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

