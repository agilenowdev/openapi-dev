# Agile.Now.AccessHub.Model.ListValidation
List validation for entity attribute

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the entity field. | 
**FieldName** | **string** | The field name of relation database table.  Example;  The field name is &quot;TenantId&quot; and is associated with the &quot;Tenant&quot; table. You want to use in the &quot;Tenant&quot; table &quot;Name&quot; field fetching data. Once &quot;Name&quot; is specified, the validation service retrieves the tenant identifier from the &quot;Tenant&quot; table based on the &quot;Name&quot; field. | [optional] 
**Required** | **bool** | If True, the value is required. | [optional] [default to false]
**Unique** | **bool** | If True, the value must be unique in the database and you cannot add multiple values. | [optional] [default to false]
**Max** | **string** | The max value of input value. | [optional] 
**Min** | **string** | The min value of input value. | [optional] 
**Pattern** | **string** | The pattern of the validation. Searches the input string for an occurrence of a regular expression. | [optional] 
**DefaultValue** | **string** | The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

