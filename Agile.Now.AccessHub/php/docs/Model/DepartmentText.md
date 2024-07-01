# # DepartmentText

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **string** | The guid to identify the department |
**external_id** | **string** | The external identifier of the department | [optional]
**name** | **string** | The name of the department |
**department_type_id** | **string** | The  type of department |
**parent_department_id** | **string** | The identifier of the parent department | [optional]
**hierarchical_name** | **string** | The hierarchical name of the department | [optional]
**level** | **int** | The department level at the hierarchy | [optional] [default to 0]
**contact_name** | **string** | The contact name of company or department | [optional]
**contact_email** | **string** | The contact email of external company or department | [optional]
**contact_phone** | **string** |  | [optional]
**owner_id** | **string** | The identifier of the user who own the department | [optional]
**country_id** | **string** | The country of the department | [optional]
**is_active** | **bool** | Defines if the department is active and can be used | [default to false]
**modified_on** | **\DateTime** | The date the record was updated | [optional]
**modified_by** | **string** | The Identifier of the user who updated the record | [optional]
**created_by** | **string** | The Identifier of the user who created the record | [optional]
**created_on** | **\DateTime** | The date the record was created | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
