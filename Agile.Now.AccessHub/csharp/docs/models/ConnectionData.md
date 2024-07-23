# Agile.Now.AccessHub.Model.ConnectionData
The record of Connection information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the module that owns the entity that is being processed. | [optional] 
**Name** | **string** | Name of connection. The value must be unique in the system and you cannot add multiple values. | 
**Description** | **string** | Description of connection. | [optional] 
**ApiKey** | **string** | An API key is a unique identifier used to authenticate a user, developer, or calling program to an API. The pattern of the value (Secure). The default of the value (Generate password). | [optional] 
**SecretKey** | **string** | A secret key for signing payloads, enhancing security. The pattern of the value (Secure). The default of the value (Generate password). | [optional] 
**URL** | **string** | Webhook external service URL-address. The value must be unique in the system and you cannot add multiple values. The pattern of the value (^(http(s)://.)[-a-zA-Z0-9@:%._\\+~#&#x3D;]{2,256}\\.[a-z]{2,6}\\b([-a-zA-Z0-9@:%_\\+.~#?&amp;//&#x3D;]*)$). | 
**IsActive** | **bool** | If true, the configuration is active. | [optional] [default to false]
**IsSystem** | **bool** | If true, the configuration is internal to the system and not visible in the user interface. | [optional] [default to false]
**ModifiedBy** | [**FieldType**](FieldType.md) | The FieldType object structure | [optional] 
**ModifiedOn** | **DateTime** | The date the record was updated. | [optional] [default to "1900-01-01T00:00Z"]
**CreatedBy** | [**FieldType**](FieldType.md) | The FieldType object structure | [optional] 
**CreatedOn** | **DateTime** | The date the record was created. | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

