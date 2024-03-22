# Alterian.JO.Model.LicenseData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the license | 
**VarClient** | **string** | Name of the license client | 
**HasAvailableQuota** | **bool** | Has available quota remaining | [optional] 
**StartDate** | **DateTime** | Start date of the license | 
**EndDate** | **DateTime** | End date of the license | [optional] 
**ConversationQuotaUsed** | **int** | Current conversation quota used | 
**ConversationQuota** | **int** | Conversation quota | 
**BlockOverage** | **bool** | Does this license block overage once quota has been reached? | 
**QuotaUsageHistory** | [**List&lt;QuotaUsageHistory&gt;**](QuotaUsageHistory.md) | History of quota usage | [optional] 
**Signature** | **string** | License signature | [optional] 
**IsActive** | **bool** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

