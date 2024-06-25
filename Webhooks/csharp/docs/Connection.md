# Agile.Now.WebhooksApi.Model.Connection
The record of Connection information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the module that owns the entity that is being processed | 
**Name** | **string** | Name of connection | 
**Description** | **string** | Description of connection | [optional] 
**ApiKey** | **string** | An API key is a unique identifier used to authenticate a user, developer, or calling program to an API | [optional] 
**SecretKey** | **string** | A secret key for signing payloads, enhancing security. | [optional] 
**URL** | **string** | Webhook external service URL-address | 
**IsActive** | **bool** | If true, the configuration is active | [optional] [default to false]
**IsSystem** | **bool** | If true, the configuration is internal to the system and not visible in the user interface | [optional] [default to false]
**ModifiedBy** | [**AbstractLong**](AbstractLong.md) |  | [optional] 
**ModifiedOn** | **DateTime** | The date the record was updated. | [optional] [default to "1900-01-01T00:00Z"]
**CreatedBy** | [**AbstractLong**](AbstractLong.md) |  | [optional] 
**CreatedOn** | **DateTime** | The date the record was created. | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

