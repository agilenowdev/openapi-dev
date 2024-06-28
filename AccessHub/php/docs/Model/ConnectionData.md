# # ConnectionData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | The identifier of the module that owns the entity that is being processed |
**name** | **string** | Name of connection |
**description** | **string** | Description of connection | [optional]
**api_key** | **string** | An API key is a unique identifier used to authenticate a user, developer, or calling program to an API | [optional]
**secret_key** | **string** | A secret key for signing payloads, enhancing security. | [optional]
**url** | **string** | Webhook external service URL-address |
**is_active** | **bool** | If true, the configuration is active | [optional] [default to false]
**is_system** | **bool** | If true, the configuration is internal to the system and not visible in the user interface | [optional] [default to false]
**modified_by** | [**\OpenAPI\Client\Model\FieldType**](FieldType.md) |  | [optional]
**modified_on** | **\DateTime** | The date the record was updated. | [optional]
**created_by** | [**\OpenAPI\Client\Model\FieldType**](FieldType.md) |  | [optional]
**created_on** | **\DateTime** | The date the record was created. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
