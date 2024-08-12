# Agile.Now.Runtime.Model.ListValidation
List validation for entity attribute

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the entity field. | 
**FieldName** | **string** | The field name of relation database table.  Example;  The field name is &#39;TenantId&#39; and is associated with the &#39;Tenant&#39; table. You want to use in the &#39;Tenant&#39; table &#39;Name&#39; field fetching data. Once &#39;Name&#39; is specified, the validation service retrieves the tenant identifier from the &#39;Tenant&#39; table based on the &#39;Name&#39; field. | [optional] 
**Required** | **bool** | If True, the value is required. | [optional] [default to false]
**Unique** | **bool** | If True, the value must be unique in the database and you cannot add multiple values. | [optional] [default to false]
**Max** | **string** | The max value of input value. | [optional] 
**Min** | **string** | The min value of input value. | [optional] 
**Pattern** | **string** | The pattern of the validation. Searches the input string for an occurrence of a regular expression. | [optional] 
**DefaultValue** | **string** | The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

