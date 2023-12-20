# SonicWallGen7.Model.PacketMonitorPacketMonitorDisplayFilter
Specify packet display filter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Interfaces** | **string** | Specify name of interface(s) on which packet filter needs                to be performed (maximum 10). | [optional] 
**EtherTypes** | **string** | Specify name of ether type(s) on which packet filter needs                to be performed. | [optional] 
**IpTypes** | **string** | Specify name of ip type(s) on which packet filter needs                to be performed. | [optional] 
**SourceIps** | **string** | Specify source IP addresses on which packet filter needs to                be performed. | [optional] 
**SourcePorts** | **string** | Specify source TCP/UDP ports on which packet filter needs to                be performed. | [optional] 
**DestinationIps** | **string** | Specify destination IP addresses on which packet filter needs                to be performed. | [optional] 
**DestinationPorts** | **string** | Specify destination TCP/UDP ports on which packet filter needs                to be performed. | [optional] 
**Bidirectional** | **bool** | Enable bidirectional address and port matching. | [optional] 
**Status** | [**PacketMonitorPacketMonitorDisplayFilterStatus**](PacketMonitorPacketMonitorDisplayFilterStatus.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

