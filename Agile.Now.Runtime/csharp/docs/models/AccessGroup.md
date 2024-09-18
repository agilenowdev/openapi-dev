# Agile.Now.Runtime.Model.AccessGroup
The record of AccessGroup information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of access group | 
**Name** | **string** | The name of access group | 
**ExternalId** | **string** | The external system code of the access group | [optional] 
**Description** | **string** | The description of access group | [optional] 
**IsActive** | **bool** | Defines if record is active | [optional] [default to false]
**IsSystem** | **bool** | Defines if access group is system and end-user cannot change it general, permissions and applications. | [optional] [default to false]
**AccessGroupTypeId** | [**AbstractText**](AbstractText.md) | The AbstractText object structure | [optional] 
**ModifiedOn** | **DateTime** | The date the record was updated | [optional] [default to "1900-01-01T00:00Z"]
**CreatedOn** | **DateTime** | The date the record was created | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

