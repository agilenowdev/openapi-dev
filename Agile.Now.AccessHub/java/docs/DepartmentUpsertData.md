

# DepartmentUpsertData

The record of Department information.

## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**id** | **String** | The guid to identify the department |  |
|**externalId** | **String** | The external identifier of the department |  [optional] |
|**name** | **String** | The name of the department |  |
|**departmentTypeId** | [**FieldType**](FieldType.md) |  |  |
|**parentDepartmentId** | [**FieldType**](FieldType.md) |  |  [optional] |
|**hierarchicalName** | **String** | The hierarchical name of the department |  [optional] |
|**level** | **Integer** | The department level at the hierarchy |  [optional] |
|**contactName** | **String** | The contact name of company or department |  [optional] |
|**contactEmail** | **String** | The contact email of external company or department |  [optional] |
|**contactPhone** | **String** |  |  [optional] |
|**ownerId** | [**FieldType**](FieldType.md) |  |  [optional] |
|**countryId** | [**FieldType**](FieldType.md) |  |  [optional] |
|**isActive** | **Boolean** | Defines if the department is active and can be used |  |
|**modifiedOn** | **OffsetDateTime** | The date the record was updated |  [optional] |
|**modifiedBy** | [**FieldType**](FieldType.md) |  |  [optional] |
|**createdBy** | [**FieldType**](FieldType.md) |  |  [optional] |
|**createdOn** | **OffsetDateTime** | The date the record was created |  [optional] |



