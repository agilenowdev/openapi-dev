# # Account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | The identifier of account |
**tenant_id** | [**\OpenAPI\Client\Model\AbstractLong**](AbstractLong.md) |  | [optional]
**name** | **string** | The name of the account | [optional]
**first_name** | **string** | Person&#39;s first name |
**last_name** | **string** | Person&#39;s last name |
**phone** | **string** | The phone number of account. The phone number is unique in the system | [optional]
**email** | **string** | The e-mail of account. The email is unique in the system |
**language_id** | [**\OpenAPI\Client\Model\AbstractText**](AbstractText.md) |  | [optional]
**timezone_id** | [**\OpenAPI\Client\Model\AbstractText**](AbstractText.md) |  | [optional]
**date_format_id** | [**\OpenAPI\Client\Model\AbstractText**](AbstractText.md) |  | [optional]
**username** | **string** | Username used to log in into the system. The username is unique in the system |
**external_id** | **string** | External Authentication identifier. Example Azure AD guid | [optional]
**notify_by_email** | **bool** | Defines if a person should get notifications via e-mail | [optional] [default to false]
**notify_by_sms** | **bool** | Defines if a contact should get notifications via SMS | [optional] [default to false]
**is_active** | **bool** | Defines if the account is active and can be used | [optional] [default to false]
**modified_on** | **\DateTime** | The date the record was updated | [optional]
**created_on** | **\DateTime** | The date the record was created | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
