# Agile.Now.AccessHub.Model.FieldType
The field object structure. This structure allows users to specify any related entity field and its corresponding value. When saving data, the system automatically retrieves and assigns the primary key value from the system database table based on the provided field name and value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | The name of the data field. This can be any field name from the related database table, such as &#39;Email&#39; from the User table or &#39;Name&#39; from the Department table. | [optional] 
**Value** | **string** | The value corresponding to the specified data field. This value is used to identify the record in the related database table. For example, it could be an email address, a department name, or an external system&#39;s identifier. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

