# Agile.Now.AccessHub.Model.DepartmentData
The record of Department information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The guid to identify the department. | [optional] 
**ExternalId** | **string** | The external identifier of the department. | [optional] 
**Name** | **string** | The name of the department. | 
**DepartmentTypeId** | [**EnumDepartmentType**](EnumDepartmentType.md) | The EnumDepartmentType enumeration | 
**ParentDepartmentId** | [**FieldType**](FieldType.md) | The FieldType object structure | [optional] 
**Level** | **int** | The department level at the hierarchy. | [optional] [default to 0]
**ContactName** | **string** | The contact name of company or department. | [optional] 
**ContactEmail** | **string** | The contact email of external company or department. | [optional] 
**ContactPhone** | **string** | The  object structure | [optional] 
**OwnerId** | [**FieldType**](FieldType.md) | The FieldType object structure | [optional] 
**CountryId** | [**EnumCountry**](EnumCountry.md) | The EnumCountry enumeration | [optional] 
**IsActive** | **bool** | Defines if the department is active and can be used. | [default to false]
**IsDeleted** | **bool** | Defines if the department is deleted and cannot be used. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

