

# Account

The record of Account information.

## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**id** | **String** | The identifier of account |  |
|**tenantId** | [**AbstractLong**](AbstractLong.md) |  |  [optional] |
|**name** | **String** | The name of the account |  [optional] |
|**firstName** | **String** | Person&#39;s first name |  |
|**lastName** | **String** | Person&#39;s last name |  |
|**phone** | **String** | The phone number of account. The phone number is unique in the system |  [optional] |
|**email** | **String** | The e-mail of account. The email is unique in the system |  |
|**languageId** | [**AbstractText**](AbstractText.md) |  |  [optional] |
|**timezoneId** | [**AbstractText**](AbstractText.md) |  |  [optional] |
|**dateFormatId** | [**AbstractText**](AbstractText.md) |  |  [optional] |
|**username** | **String** | Username used to log in into the system. The username is unique in the system |  |
|**externalId** | **String** | External Authentication identifier. Example Azure AD guid |  [optional] |
|**notifyByEmail** | **Boolean** | Defines if a person should get notifications via e-mail |  [optional] |
|**notifyBySMS** | **Boolean** | Defines if a contact should get notifications via SMS |  [optional] |
|**isActive** | **Boolean** | Defines if the account is active and can be used |  [optional] |
|**modifiedOn** | **OffsetDateTime** | The date the record was updated |  [optional] |
|**createdOn** | **OffsetDateTime** | The date the record was created |  [optional] |



