# Agile.Now.Runtime.Model.EffectivePermission
The record of EffectivePermission information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of entity | 
**AccessRoleId** | [**AbstractText**](AbstractText.md) | The AbstractText object structure | 
**AccessGroupTypeId** | [**AbstractText**](AbstractText.md) | The AbstractText object structure | [optional] 
**Create** | **bool** | Create access of role | [optional] [default to false]
**Read** | **bool** | Read access of role | [optional] [default to false]
**Update** | **bool** | Update access of role | [optional] [default to false]
**Delete** | **bool** | Delete access of role | [optional] [default to false]
**Details** | **bool** | Details access of role | [optional] [default to false]
**Export** | **bool** | Export access of role | [optional] [default to false]
**Import** | **bool** | Import access of role | [optional] [default to false]
**Generic** | **bool** | Generic access without CRUD of role | [optional] [default to false]
**CreatedOn** | **DateTime** | The date the record was created | [optional] [default to "1900-01-01T00:00Z"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

