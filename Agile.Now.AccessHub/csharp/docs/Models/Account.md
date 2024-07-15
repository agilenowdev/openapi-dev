# Account
## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
| **Id** | **String** | The identifier of account | [default to null] |
| **TenantId** | [**AbstractLong**](AbstractLong.md) |  | [optional] [default to null] |
| **Name** | **String** | The name of the account | [optional] [default to null] |
| **FirstName** | **String** | Person&#39;s first name | [default to null] |
| **LastName** | **String** | Person&#39;s last name | [default to null] |
| **Phone** | **String** | The phone number of account. The phone number is unique in the system | [optional] [default to null] |
| **Email** | **String** | The e-mail of account. The email is unique in the system | [default to null] |
| **LanguageId** | [**AbstractText**](AbstractText.md) |  | [optional] [default to null] |
| **TimezoneId** | [**AbstractText**](AbstractText.md) |  | [optional] [default to null] |
| **DateFormatId** | [**AbstractText**](AbstractText.md) |  | [optional] [default to null] |
| **Username** | **String** | Username used to log in into the system. The username is unique in the system | [default to null] |
| **ExternalId** | **String** | External Authentication identifier. Example Azure AD guid | [optional] [default to null] |
| **NotifyByEmail** | **Boolean** | Defines if a person should get notifications via e-mail | [optional] [default to false] |
| **NotifyBySMS** | **Boolean** | Defines if a contact should get notifications via SMS | [optional] [default to false] |
| **Is\_Active** | **Boolean** | Defines if the account is active and can be used | [optional] [default to false] |
| **ModifiedOn** | **Date** | The date the record was updated | [optional] [default to 1900-01-01T00:00Z] |
| **CreatedOn** | **Date** | The date the record was created | [optional] [default to 1900-01-01T00:00Z] |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

