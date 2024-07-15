# ListValidation
## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
| **Name** | **String** | The name of the entity field. | [default to null] |
| **FieldName** | **String** | The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field. | [optional] [default to null] |
| **Required** | **Boolean** | If True, the value is required. | [optional] [default to false] |
| **Unique** | **Boolean** | If True, the value must be unique in the database and you cannot add multiple values. | [optional] [default to false] |
| **Max** | **String** | The max value of input value. | [optional] [default to null] |
| **Min** | **String** | The min value of input value. | [optional] [default to null] |
| **Pattern** | **String** | The pattern of the validation. Searches the input string for an occurrence of a regular expression. | [optional] [default to null] |
| **DefaultValue** | **String** | The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types. | [optional] [default to null] |

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

