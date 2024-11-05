# Agile.Now.AccessHub.Model.ApplicationData1
The record of Application information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the access application. | [optional] 
**Name** | **string** | Name of application. The value must be unique in the system and you cannot add multiple values. | [optional] 
**ApplicationKey** | **string** | The key used to identify the application must be unique within each workspace. The value must be unique in the system and you cannot add multiple values. | [optional] 
**ExternalId** | **string** | The external system code of the application. The value must be unique in the system and you cannot add multiple values. | [optional] 
**Description** | **string** | The description of access group. | [optional] 
**WebSiteURL** | **string** | Web Site URL of application. | [optional] 
**IsSystem** | **bool** | Defines if application is system (setting menu). | [optional] [default to false]
**IsEndUser** | **bool** | Specifies whether the application is an end-user application. | [optional] [default to false]
**IsActive** | **bool** | Defines if the application is active and can be used. | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

