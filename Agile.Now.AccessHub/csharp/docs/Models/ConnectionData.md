# ConnectionData
## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
| **Id** | **String** | The identifier of the module that owns the entity that is being processed | [default to null] |
| **Name** | **String** | Name of connection | [default to null] |
| **Description** | **String** | Description of connection | [optional] [default to null] |
| **ApiKey** | **String** | An API key is a unique identifier used to authenticate a user, developer, or calling program to an API | [optional] [default to null] |
| **SecretKey** | **String** | A secret key for signing payloads, enhancing security. | [optional] [default to null] |
| **URL** | **String** | Webhook external service URL-address | [default to null] |
| **Is\_Active** | **Boolean** | If true, the configuration is active | [optional] [default to false] |
| **Is\_System** | **Boolean** | If true, the configuration is internal to the system and not visible in the user interface | [optional] [default to false] |
| **ModifiedBy** | [**FieldType**](FieldType.md) |  | [optional] [default to null] |
| **ModifiedOn** | **Date** | The date the record was updated. | [optional] [default to 1900-01-01T00:00Z] |
| **CreatedBy** | [**FieldType**](FieldType.md) |  | [optional] [default to null] |
| **CreatedOn** | **Date** | The date the record was created. | [optional] [default to 1900-01-01T00:00Z] |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

