# Agile.Now.AccessHub.Model.RoleData1
The record of Role information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the role. | [optional] 
**Name** | **string** | Name of role. The value must be unique in the system and you cannot add multiple values. | [optional] 
**RoleKey** | **string** |  The key used to identify the role must be unique within each workspace. The value must be unique in the system and you cannot add multiple values. | [optional] 
**FullName** | **string** | Full name of role. Example Application 1 \\ Espace 1 \\ Role 1. | [optional] 
**Description** | **string** | The description of access group. | [optional] 
**ExternalId** | **string** | The external system code of the role. | [optional] 
**AccessApplicationId** | [**FieldType**](FieldType.md) | The FieldType object structure | [optional] 
**IsActive** | **bool** | Defines if record is active. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

