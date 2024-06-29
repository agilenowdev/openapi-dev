# # Config

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | The identifier of the config |
**webhook_entity_id** | [**\OpenAPI\Client\Model\AbstractText**](AbstractText.md) |  |
**has_create_access** | **bool** | Service has create access to data | [optional] [default to false]
**has_update_access** | **bool** | Service has update access to data | [optional] [default to false]
**has_delete_access** | **bool** | Service has delete access to data | [optional] [default to false]
**is_active** | **bool** | If true, the configuration is active | [optional] [default to false]
**modified_by** | [**\OpenAPI\Client\Model\AbstractLong**](AbstractLong.md) |  | [optional]
**modified_on** | **\DateTime** | The date the record was updated. | [optional]
**created_by** | [**\OpenAPI\Client\Model\AbstractLong**](AbstractLong.md) |  | [optional]
**created_on** | **\DateTime** | The date the record was created. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
