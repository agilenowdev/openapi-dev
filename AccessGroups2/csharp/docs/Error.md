# Agile.Now.ApiAccessGroups2.Model.Error
The list of errors. Throw specific exceptions based on the received error.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | **List&lt;string&gt;** | Human-readable explanation of the errors | 
**Type** | **string** | URI identifier that categorizes the error | [optional] [default to ""]
**Title** | **string** | Brief, human-readable message about the error | [optional] [default to ""]
**StatusCode** | **int** | The HTTP response code | 
**Instance** | **string** | URI that identifies the specific occurrence of the error | [optional] [default to ""]
**RequestKey** | **string** | Provides a request key that identifies the current request. | [optional] [default to ""]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

