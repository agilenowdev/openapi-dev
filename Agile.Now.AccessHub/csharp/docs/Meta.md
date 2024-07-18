# Agile.Now.AccessHub.Model.Meta
The object provides metadata about the list of items returned in the API response. It typically includes information that helps clients understand and work with the data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalItems** | **int** | This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It's useful for implementing pagination, as clients can use it to calculate the number of pages or total available items. | [default to 0]
**CurrentPage** | **int** | This field specifies the current page of results being returned. It's often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. | [default to 1]
**PageSize** | **int** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed. | [default to 50]
**Type** | **string** | The type of the record | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

