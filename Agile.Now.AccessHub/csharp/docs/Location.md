# Agile\.Now\.AccessHub.Model.Location
The record of Location information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The guid to identify the location | 
**ExternalId** | **string** | The external identifier of the location | [optional] 
**Name** | **string** | The name of the location | 
**CountryId** | [**AbstractText**](AbstractText.md) |  | [optional] 
**TimezoneId** | [**AbstractText**](AbstractText.md) |  | [optional] 
**CurrencyId** | [**AbstractText**](AbstractText.md) |  | [optional] 
**IsActive** | **bool** | Defines if the location is active and can be used | [default to false]
**ModifiedOn** | **DateTime** | The date the record was updated | [optional] [default to "1900-01-01T00:00Z"]
**ModifiedBy** | [**AbstractLong**](AbstractLong.md) |  | [optional] 
**CreatedBy** | [**AbstractLong**](AbstractLong.md) |  | [optional] 
**CreatedOn** | **DateTime** | The date the record was created | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

