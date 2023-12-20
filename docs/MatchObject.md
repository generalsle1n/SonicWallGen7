# SonicWallGen7.Model.MatchObject
Match object configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Set match object name. | 
**Type** | **string** | Match object type. | [optional] 
**MatchType** | **string** | Set match object match type. | [optional] 
**Enable** | **bool** | Enable custom settings. | [optional] 
**Offset** | **decimal** | Set offset. | [optional] 
**Depth** | **decimal** | Set depth. | [optional] 
**MinSize** | **decimal** | Set min size. | [optional] 
**MaxSize** | **decimal** | Set max size. | [optional] 
**NegativeMatching** | **bool** | Enable negative matching. | [optional] 
**CustomHeader** | **string** | Set custom header name. | [optional] 
**EmailSize** | [**MatchObjectEmailSize**](MatchObjectEmailSize.md) |  | [optional] 
**InputRepresentation** | **string** | Set match object input representation. | [optional] 
**PreDefinedRegex** | [**MatchObjectPreDefinedRegex**](MatchObjectPreDefinedRegex.md) |  | [optional] 
**ContentEntry** | [**List&lt;EmailObjectContentEntryInner&gt;**](EmailObjectContentEntryInner.md) | Add match object content. | [optional] 
**Browser** | [**List&lt;MatchObjectBrowserInner&gt;**](MatchObjectBrowserInner.md) | Add match object FTP browser. | [optional] 
**FtpCommand** | [**List&lt;MatchObjectFtpCommandInner&gt;**](MatchObjectFtpCommandInner.md) | Add match object FTP command. | [optional] 
**Argument** | [**List&lt;MatchObjectArgumentInner&gt;**](MatchObjectArgumentInner.md) | Add FTP command argument. | [optional] 
**Ips** | [**MatchObjectIps**](MatchObjectIps.md) |  | [optional] 
**Category** | [**List&lt;MatchObjectCategoryInner&gt;**](MatchObjectCategoryInner.md) | Add an application category. | [optional] 
**Application** | [**List&lt;MatchObjectApplicationInner&gt;**](MatchObjectApplicationInner.md) | Add an application. | [optional] 
**Signature** | [**List&lt;MatchObjectSignatureInner&gt;**](MatchObjectSignatureInner.md) | Add a signature. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

