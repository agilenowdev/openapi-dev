# Agile.Now.AccessHub.Model.RoleData
The record of Role information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the role. | [optional] 
**Name** | **string** | Name of role. The value must be unique in the system and you cannot add multiple values. The pattern of the value (/test/). | [optional] 
**RoleKey** | **string** |  The key used to identify the role must be unique within each workspace. The value must be unique in the system and you cannot add multiple values. | [optional] 
**FullName** | **string** | Full name of role. Example Application 1 \\ Espace 1 \\ Role 1. | [optional] 
**Description** | **string** | The description of access group. | [optional] 
**ExternalId** | **string** | The external system code of the role. The value must be unique in the system and you cannot add multiple values. | [optional] 
**RoleId** | [**FieldType**](FieldType.md) | The FieldType object structure | [optional] 
**ApplicationId** | [**FieldType**](FieldType.md) | The FieldType object structure | [optional] 
**EspaceId** | [**FieldType**](FieldType.md) | The FieldType object structure | [optional] 
**IsActive** | **bool** | Defines if record is active. | [optional] [default to false]
**IsCustom** | **bool** | Determines whether the role has been modified externally or whether it is synchronized from the OutSystems structure. | [optional] [default to false]
**IsReadOnly** | **bool** | Determines whether the role is readonly and can be modified. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

