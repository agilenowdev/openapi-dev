# Agile.Now.AccessHub.Model.AccountData
The record of Account information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of account. | [optional] 
**Name** | **string** | The name of the account. | [optional] 
**FirstName** | **string** | Person&#39;s first name. | [optional] 
**LastName** | **string** | Person&#39;s last name. | [optional] 
**Phone** | **string** | The phone number of account. The phone number is unique in the system. | [optional] 
**PhoneVerified** | **bool** | Indicates whether the phone number has been verified. | [optional] [default to false]
**Email** | **string** | The e-mail of account. The email is unique in the system. | [optional] 
**LanguageId** | [**EnumLanguage**](EnumLanguage.md) | The EnumLanguage enumeration | [optional] 
**TimezoneId** | [**EnumTimezone**](EnumTimezone.md) | The EnumTimezone enumeration | [optional] 
**DateFormatId** | [**EnumDateFormat**](EnumDateFormat.md) | The EnumDateFormat enumeration | [optional] 
**Username** | **string** | Username used to log in into the system. The username is unique in the system. The value must be unique in the system and you cannot add multiple values. | [optional] 
**ExternalId** | **string** | External Authentication identifier. Example Azure AD guid. The value must be unique in the system and you cannot add multiple values. | [optional] 
**NotifyByEmail** | **bool** | Defines if a person should get notifications via e-mail. | [optional] [default to false]
**NotifyBySMS** | **bool** | Defines if a contact should get notifications via SMS. | [optional] [default to false]
**IsActive** | **bool** | Defines if the account is active and can be used. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

