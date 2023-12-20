# SonicWallGen7.Model.IphProtocol
IP helper protocols configuration schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Specify IP Helper relay protocol name. | 
**Enable** | **bool** | Enable IP helper relay protocol. | [optional] 
**Port1** | [**IphProtocolPort1**](IphProtocolPort1.md) |  | [optional] 
**Port2** | [**IphProtocolPort2**](IphProtocolPort2.md) |  | [optional] 
**Timeout** | **string** | Specify IP helper relay protocol timeout. | [optional] 
**Mode** | **string** | Specify IP helper relay protocol mode. | [optional] 
**MulticastIp** | [**IphProtocolMulticastIp**](IphProtocolMulticastIp.md) |  | [optional] 
**MulticastIpv6** | [**IphProtocolMulticastIpv6**](IphProtocolMulticastIpv6.md) |  | [optional] 
**SourceTranslation** | **bool** | Configure IP source translation for IP helper relay protocol. | [optional] 
**Raw** | **bool** | Enable raw mode for IP helper relay protocol. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

