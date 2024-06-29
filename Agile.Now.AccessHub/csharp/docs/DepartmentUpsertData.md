# Agile.Now.AccessHub.Model.DepartmentUpsertData
The record of Department information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The guid to identify the department | 
**ExternalId** | **string** | The external identifier of the department | [optional] 
**Name** | **string** | The name of the department | 
**DepartmentTypeId** | [**FieldType**](FieldType.md) |  | 
**ParentDepartmentId** | [**FieldType**](FieldType.md) |  | [optional] 
**HierarchicalName** | **string** | The hierarchical name of the department | [optional] 
**Level** | **int** | The department level at the hierarchy | [optional] [default to 0]
**ContactName** | **string** | The contact name of company or department | [optional] 
**ContactEmail** | **string** | The contact email of external company or department | [optional] 
**ContactPhone** | **string** |  | [optional] 
**OwnerId** | [**FieldType**](FieldType.md) |  | [optional] 
**CountryId** | [**FieldType**](FieldType.md) |  | [optional] 
**IsActive** | **bool** | Defines if the department is active and can be used | [default to false]
**ModifiedOn** | **DateTime** | The date the record was updated | [optional] [default to "1900-01-01T00:00Z"]
**ModifiedBy** | [**FieldType**](FieldType.md) |  | [optional] 
**CreatedBy** | [**FieldType**](FieldType.md) |  | [optional] 
**CreatedOn** | **DateTime** | The date the record was created | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

