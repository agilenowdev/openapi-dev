# Agile.Now.AccessHub.Model.Application1
The record of Application information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the access application | 
**Name** | **string** | Name of application | [optional] 
**ApplicationKey** | **string** | The key used to identify the application must be unique within each workspace. | [optional] 
**ExternalId** | **string** | The external system code of the application | [optional] 
**Description** | **string** | The description of access group | [optional] 
**WebSiteURL** | **string** | Web Site URL of application | [optional] 
**IsSystem** | **bool** | Defines if application is system (setting menu) | [optional] [default to false]
**IsEndUser** | **bool** | Specifies whether the application is an end-user application | [optional] [default to false]
**IsActive** | **bool** | Defines if the application is active and can be used | [default to false]
**ModifiedOn** | **DateTime** | The date the record was updated | [optional] [default to "1900-01-01T00:00Z"]
**ModifiedBy** | [**AbstractLong**](AbstractLong.md) | The AbstractLong object structure | [optional] 
**CreatedBy** | [**AbstractLong**](AbstractLong.md) | The AbstractLong object structure | [optional] 
**CreatedOn** | **DateTime** | The date the record was created | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

