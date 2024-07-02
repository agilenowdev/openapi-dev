

# Meta

The object provides metadata about the list of items returned in the API response. It typically includes information that helps clients understand and work with the data.

## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**totalItems** | **Integer** | This field represents the total number of items available in the entire dataset, not just the items returned in the current response. It&#39;s useful for implementing pagination, as clients can use it to calculate the number of pages or total available items. |  |
|**currentPage** | **Integer** | This field specifies the current page of results being returned. It&#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. |  |
|**pageSize** | **Integer** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed. |  |
|**type** | **String** | The type of the record |  |



