# Agile.Now.ApiOrganizations.Model.LocationData
The record of Location information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The guid to identify the location. | [optional] 
**ExternalId** | **string** | The external identifier of the location. | [optional] 
**Name** | **string** | The name of the location. The value must be unique in the system and you cannot add multiple values. | 
**CountryId** | **EnumCountry** |  | [optional] 
**TimezoneId** | **EnumTimezone** |  | [optional] 
**CurrencyId** | **EnumCurrency** |  | [optional] 
**IsActive** | **bool** | Defines if the location is active and can be used. | [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

