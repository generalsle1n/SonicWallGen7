# SonicWallGen7.Model.DhcpOverVpnBaseRemoteVpnDhcpOverVpnRemote
Configure DHCP over VPN for remote gateway and enter to remote mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoundTo** | **string** | DHCP lease bound to. | [optional] 
**RelayIp** | **string** | Configure DHCP relay IP address. | [optional] 
**ManagementIp** | **string** | Configure remote management IP address. | [optional] 
**BlockSpoof** | **bool** | Enable block traffic through tunnel when IP spoof detected. | [optional] 
**TempLease** | **bool** | Enable obtain temporary lease from local DHCP server if tunnel is down. | [optional] 
**LeaseTime** | **decimal** | Set the temporary lease time (minutes). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

