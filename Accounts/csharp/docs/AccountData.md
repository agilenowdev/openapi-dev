# Agile.Now.ApiAccounts.Model.AccountData
The record of Account information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of account | 
**TenantId** | [**FieldType**](FieldType.md) |  | [optional] 
**Name** | **string** | The name of the account | [optional] 
**FirstName** | **string** | Person&#39;s first name | 
**LastName** | **string** | Person&#39;s last name | 
**Phone** | **string** | The phone number of account. The phone number is unique in the system | [optional] 
**Email** | **string** | The e-mail of account. The email is unique in the system | 
**LanguageId** | [**FieldType**](FieldType.md) |  | [optional] 
**TimezoneId** | [**FieldType**](FieldType.md) |  | [optional] 
**DateFormatId** | [**FieldType**](FieldType.md) |  | [optional] 
**Username** | **string** | Username used to log in into the system. The username is unique in the system | 
**ExternalId** | **string** | External Authentication identifier. Example Azure AD guid | [optional] 
**NotifyByEmail** | **bool** | Defines if a person should get notifications via e-mail | [optional] [default to false]
**NotifyBySMS** | **bool** | Defines if a contact should get notifications via SMS | [optional] [default to false]
**IsActive** | **bool** | Defines if the account is active and can be used | [optional] [default to false]
**ModifiedOn** | **DateTime** | The date the record was updated | [optional] [default to "1900-01-01T00:00Z"]
**CreatedOn** | **DateTime** | The date the record was created | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

