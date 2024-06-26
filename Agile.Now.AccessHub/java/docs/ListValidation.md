

# ListValidation

List validation for entity attribute

## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**name** | **String** | The name of the entity field. |  |
|**fieldName** | **String** | The field name of relation database table.  Example;  The field name is &amp;quot;TenantId&amp;quot; and is associated with the &amp;quot;Tenant&amp;quot; table. You want to use in the &amp;quot;Tenant&amp;quot; table &amp;quot;Name&amp;quot; field fetching data. Once &amp;quot;Name&amp;quot; is specified, the validation service retrieves the tenant identifier from the &amp;quot;Tenant&amp;quot; table based on the &amp;quot;Name&amp;quot; field. |  [optional] |
|**required** | **Boolean** | If True, the value is required. |  [optional] |
|**unique** | **Boolean** | If True, the value must be unique in the database and you cannot add multiple values. |  [optional] |
|**max** | **String** | The max value of input value. |  [optional] |
|**min** | **String** | The min value of input value. |  [optional] |
|**pattern** | **String** | The pattern of the validation. Searches the input string for an occurrence of a regular expression. |  [optional] |
|**defaultValue** | **String** | The default value of row. If the value of the field is empty, the service automatically sets the value in the field. If the value does not match the data type, the value is cleaned. Remember data types. |  [optional] |



