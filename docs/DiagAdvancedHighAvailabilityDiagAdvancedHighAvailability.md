# SonicWallGen7.Model.DiagAdvancedHighAvailabilityDiagAdvancedHighAvailability
Configure advanced diag High Availability settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RestartBackupOnWatchdog** | **bool** | Enable always restarting HA backup for watchdog task . | [optional] 
**InterleaveCache** | **bool** | Enable interleave connection cache state synchronization messages. | [optional] 
**CacheSyncRemoveRetryLimit** | **decimal** | Set Connection Cache synchronization remove retry limit time. | [optional] 
**CacheSyncGiveUpRemoveRetry** | **decimal** | Set the cache usage of giving up cache remove retry. | [optional] 
**RecoverStatefulData** | **bool** | Enable HA recover stateful data when remove failed cache reaches half of maximum connection cache. | [optional] 
**IdleNetworkMonitorProbing** | **bool** | Enable network Monitor probing on Idle unit. | [optional] 
**LowPacketPoolFailover** | **bool** | Enable HA failover when packet pool is low on active unit. | [optional] 
**SuppressActiveTransitionAlarm** | **bool** | Enable suppressing alarm on HA Transition to active. | [optional] 
**MultiChassisLag** | **bool** | Enable support for multi chassis LAG on Active/Standby noth units. | [optional] 
**SyslogMessagesBothUnits** | **bool** | Send syslog messages from both HA units with unique serial numbers. | [optional] 
**MaxTransparentModeGratuitousArps** | **decimal** | Set maximum number of gratuitous ARP of transparent mode per interface while HA failover. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

