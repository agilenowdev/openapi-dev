# # Meta1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**total_items** | **int** | This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It&#39;s useful for implementing pagination, as clients can use it to calculate the number of pages or total available items. | [default to 0]
**current_page** | **int** | This field specifies the current page of results being returned. It&#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [default to 1]
**page_size** | **int** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed. | [default to 50]
**type** | **string** | The type of the record |

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
