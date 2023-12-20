# SonicWallGen7.Model.InterfaceIpv4IpAssignmentModePppoePppoe
Interface uses point to point protocol over ethernet.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dynamic** | **bool** | Enable dynamic acquisition of IP configuration data. | [optional] 
**Unnumbered** | **string** | Enable unnumbered interface. | [optional] 
**Inactivity** | **decimal** | Enable the PPPoE inactivity timer. | [optional] 
**Ip** | **string** | Set PPPoE IP address. | [optional] 
**LcpEchoPackets** | **bool** | Enable strictly use LCP echo packets for server keep-alive. | [optional] 
**Password** | **string** | Set PPPoE user password. | [optional] 
**ServiceName** | **string** | Set PPPoE service Name. | [optional] 
**Reconnect** | **decimal** | Enable and set reconnect the PPPoE client if the server does not send traffic for specified minutes. | [optional] 
**UserName** | **string** | Set PPPoE user name. | [optional] 
**NcpNegRetrans** | **decimal** | Set the retransmission time during NCP negotiation | [optional] 
**Schedule** | [**InterfaceIpv4IpAssignmentModePppoePppoeSchedule**](InterfaceIpv4IpAssignmentModePppoePppoeSchedule.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

