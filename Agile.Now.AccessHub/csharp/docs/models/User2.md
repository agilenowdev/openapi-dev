# Agile.Now.AccessHub.Model.User2
The record of User information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier of the user. | [default to 0]
**Name** | **string** | Full name of the user. | [optional] 
**Username** | **string** | Login name of the user. | [optional] 
**Email** | **string** | Email contact of the user. | [optional] 
**MobilePhone** | **string** | Mobile phone number of the user. | [optional] 
**ExternalId** | **string** | The user identifier in an external system to the Platform. | [optional] 
**CreationDate** | **DateTime** | The date the user was created. | [default to "1900-01-01T00:00Z"]
**LastLogin** | **DateTime** | Last time the user logged in the application. | [optional] [default to "1900-01-01T00:00Z"]
**IsActive** | **bool** | Indicates if the user is still active. | [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

