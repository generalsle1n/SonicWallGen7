# SonicWallGen7.Model.Zone
Zone Object configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Zone name. | 
**Uuid** | **string** | zone object UUID. | [optional] [readonly] 
**SecurityType** | **string** | Set zone security type. | [optional] 
**InterfaceTrust** | **bool** | Enable allow interface trust. | [optional] 
**AutoGenerateAccessRules** | [**ZoneAutoGenerateAccessRules**](ZoneAutoGenerateAccessRules.md) |  | [optional] 
**WebsenseContentFiltering** | **bool** | Enable enforce websense enterprise content filtering service. | [optional] 
**GatewayAntiVirus** | **bool** | Enable gateway anti-virus service. | [optional] 
**IntrusionPrevention** | **bool** | Enable intrusion prevention service. | [optional] 
**AppControl** | **bool** | Enable app control service. | [optional] 
**AntiSpyware** | **bool** | Enable anti-spyware service. | [optional] 
**CreateGroupVpn** | **bool** | Enable automatic creation of group VPN for this zone. | [optional] 
**SslControl** | **bool** | Enable SSL-Control on this zone. | [optional] 
**SslvpnAccess** | **bool** | Enable SSL-VPN access this zone. | [optional] 
**DpiSslClient** | **bool** | Enable SSL client inspection. | [optional] 
**DpiSslServer** | **bool** | Enable SSL server inspection. | [optional] 
**GuestServices** | [**ZoneGuestServices**](ZoneGuestServices.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

