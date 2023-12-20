# SonicWallGen7.Model.ZoneGuestServices
Enter configuration mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** | Enable guest services. | [optional] 
**InterGuest** | **bool** | Enable inter-guest communication. | [optional] 
**ExternalAuth** | [**ZoneGuestServicesExternalAuth**](ZoneGuestServicesExternalAuth.md) |  | [optional] 
**PolicyPageNonAuthentication** | [**ZoneGuestServicesPolicyPageNonAuthentication**](ZoneGuestServicesPolicyPageNonAuthentication.md) |  | [optional] 
**CustomAuthPage** | [**ZoneGuestServicesCustomAuthPage**](ZoneGuestServicesCustomAuthPage.md) |  | [optional] 
**PostAuth** | **string** | Enable page to direct users to after successful authentication. * Set to null to represent an unconfigured state. | [optional] 
**BypassGuestAuth** | [**ZoneGuestServicesBypassGuestAuth**](ZoneGuestServicesBypassGuestAuth.md) |  | [optional] 
**SmtpRedirect** | [**ZoneGuestServicesSmtpRedirect**](ZoneGuestServicesSmtpRedirect.md) |  | [optional] 
**DenyNetworks** | [**ZoneGuestServicesDenyNetworks**](ZoneGuestServicesDenyNetworks.md) |  | [optional] 
**PassNetworks** | [**ZoneGuestServicesPassNetworks**](ZoneGuestServicesPassNetworks.md) |  | [optional] 
**MaxGuests** | **decimal** | Specify the maximum number of guest users allowed to connect to the WLAN zone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

