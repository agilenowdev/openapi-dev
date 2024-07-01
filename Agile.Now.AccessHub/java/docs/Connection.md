

# Connection

The record of Connection information.

## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**id** | **String** | The identifier of the module that owns the entity that is being processed |  |
|**name** | **String** | Name of connection |  |
|**description** | **String** | Description of connection |  [optional] |
|**apiKey** | **String** | An API key is a unique identifier used to authenticate a user, developer, or calling program to an API |  [optional] |
|**secretKey** | **String** | A secret key for signing payloads, enhancing security. |  [optional] |
|**URL** | **String** | Webhook external service URL-address |  |
|**isActive** | **Boolean** | If true, the configuration is active |  [optional] |
|**isSystem** | **Boolean** | If true, the configuration is internal to the system and not visible in the user interface |  [optional] |
|**modifiedBy** | [**AbstractLong**](AbstractLong.md) |  |  [optional] |
|**modifiedOn** | **OffsetDateTime** | The date the record was updated. |  [optional] |
|**createdBy** | [**AbstractLong**](AbstractLong.md) |  |  [optional] |
|**createdOn** | **OffsetDateTime** | The date the record was created. |  [optional] |



