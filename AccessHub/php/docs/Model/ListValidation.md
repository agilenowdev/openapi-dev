# # ListValidation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** | The name of the entity field. |
**field_name** | **string** | The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field. | [optional]
**required** | **bool** | If True, the value is required. | [optional] [default to false]
**unique** | **bool** | If True, the value must be unique in the database and you cannot add multiple values. | [optional] [default to false]
**max** | **string** | The max value of input value. | [optional]
**min** | **string** | The min value of input value. | [optional]
**pattern** | **string** | The pattern of the validation. Searches the input string for an occurrence of a regular expression. | [optional]
**default_value** | **string** | The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
