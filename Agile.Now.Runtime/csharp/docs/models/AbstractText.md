# Agile.Now.Runtime.Model.AbstractText
This structure represents an abstract object with a primary key of type Text. It is used to encapsulate detailed information about related entities.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The primary key of the record. It uniquely identifies each record within the dataset. This attribute is required and must be unique across all records. | [optional] 
**ExternalId** | **string** | An external identifier for the record, which can be used to link the record to external systems or datasets. This attribute is optional but should be unique if provided. | [optional] 
**Name** | **string** | The name of the record. This attribute provides a human-readable identifier for the record, making it easier to recognize and differentiate records in lists or other displays. This attribute is optional. | [optional] 
**Type** | **string** | The type of the record object. This attribute is used to classify the record into specific categories or types, helping to organize and manage different kinds of records. This attribute is optional. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

