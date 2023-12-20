# SonicWallGen7.Model.AppRulePolicy
App rules policy configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | App rule name. | 
**Enable** | **bool** | Enable app rule policy. | [optional] 
**Type** | [**AppRulePolicyType**](AppRulePolicyType.md) |  | [optional] 
**Source** | [**AppRulePolicySource**](AppRulePolicySource.md) |  | [optional] 
**Destination** | [**AppRulePolicyDestination**](AppRulePolicyDestination.md) |  | [optional] 
**Address** | [**AppRulePolicyAddress**](AppRulePolicyAddress.md) |  | [optional] 
**Exclusion** | [**AppRulePolicyExclusion**](AppRulePolicyExclusion.md) |  | [optional] 
**MatchObject** | [**AppRulePolicyMatchObject**](AppRulePolicyMatchObject.md) |  | [optional] 
**ActionObject** | **string** | Set action object for this app rule policy. | [optional] 
**Users** | [**AppRulePolicyUsers**](AppRulePolicyUsers.md) |  | [optional] 
**MailFrom** | [**AppRulePolicyMailFrom**](AppRulePolicyMailFrom.md) |  | [optional] 
**RcptTo** | [**AppRulePolicyRcptTo**](AppRulePolicyRcptTo.md) |  | [optional] 
**Schedule** | [**AppRulePolicySchedule**](AppRulePolicySchedule.md) |  | [optional] 
**FlowReporting** | **bool** | Enable flow reporting. | [optional] 
**Logging** | **bool** | Enable logging when this app rule is used. | [optional] 
**Log** | [**AppRulePolicyLog**](AppRulePolicyLog.md) |  | [optional] 
**IpsMessageFormat** | **bool** | Enable log using IPS message format. | [optional] 
**AppControlMessageFormat** | **bool** | Enable log using app control message format. | [optional] 
**CfsMessageFormat** | **bool** | Enable log using CFS message format. | [optional] 
**ConnectionSide** | **string** | Set connection side. | [optional] 
**Direction** | [**AppRulePolicyDirection**](AppRulePolicyDirection.md) |  | [optional] 
**Zone** | [**AppRulePolicyZone**](AppRulePolicyZone.md) |  | [optional] 
**CfsList** | [**AppRulePolicyCfsList**](AppRulePolicyCfsList.md) |  | [optional] 
**SafeSearch** | **bool** | Enable safe search enforcement. | [optional] 
**YoutubeForSchools** | **bool** | Enable YouTube for schools. | [optional] 
**SchoolId** | **string** | Set CFS school id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

