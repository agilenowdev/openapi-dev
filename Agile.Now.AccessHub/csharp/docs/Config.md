# Agile.Now.AccessHub.Model.Config
The record of Config information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the config | 
**WebhookEntityId** | [**AbstractText**](AbstractText.md) |  | 
**HasCreateAccess** | **bool** | Service has create access to data | [optional] [default to false]
**HasUpdateAccess** | **bool** | Service has update access to data | [optional] [default to false]
**HasDeleteAccess** | **bool** | Service has delete access to data | [optional] [default to false]
**IsActive** | **bool** | If true, the configuration is active | [optional] [default to false]
**ModifiedBy** | [**AbstractLong**](AbstractLong.md) |  | [optional] 
**ModifiedOn** | **DateTime** | The date the record was updated. | [optional] [default to "1900-01-01T00:00Z"]
**CreatedBy** | [**AbstractLong**](AbstractLong.md) |  | [optional] 
**CreatedOn** | **DateTime** | The date the record was created. | [optional] [default to "1900-01-01T00:00Z"]
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

