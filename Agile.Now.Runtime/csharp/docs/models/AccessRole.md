# Agile.Now.Runtime.Model.AccessRole
The record of AccessRole information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the role | 
**Name** | **string** | Name of role | [optional] 
**RoleKey** | **string** |  The key used to identify the role must be unique within each workspace. | 
**FullName** | **string** | Full name of role. Example Application 1 \\ Espace 1 \\ Role 1 | [optional] 
**Description** | **string** | The description of access group | [optional] 
**ExternalId** | **string** | The external system code of the role | [optional] 
**AccessApplicationId** | [**AbstractText**](AbstractText.md) | The AbstractText object structure | [optional] 
**RoleId** | [**AbstractLong**](AbstractLong.md) | The AbstractLong object structure | [optional] 
**ApplicationId** | [**AbstractLong**](AbstractLong.md) | The AbstractLong object structure | [optional] 
**EspaceId** | [**AbstractLong**](AbstractLong.md) | The AbstractLong object structure | [optional] 
**IsActive** | **bool** | Defines if record is active | [optional] [default to false]
**IsCustom** | **bool** | Determines whether the role has been modified externally or whether it is synchronized from the OutSystems structure | [optional] [default to false]
**IsReadOnly** | **bool** | Determines whether the role is readonly and can be modified | [default to false]
**ModifiedOn** | **DateTime** | The date the record was updated | [optional] [default to "1900-01-01T00:00Z"]
**CreatedOn** | **DateTime** | The date the record was created | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

