# EntitiesApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**get Entity**](EntitiesApi.md#get Entity) | **GET** /Endpoint/rest/api/v1/Entity/{Id} |  |
| [**list Entities**](EntitiesApi.md#list Entities) | **GET** /Endpoint/rest/api/v1/Entities |  |


<a name="get Entity"></a>
# **get Entity**
> Entity get Entity(Id, Name)



    The method returns one record of the &#x60;Entity&#x60;.  Method returns an extended &#x60;Entity&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  Foreign key fields are: &#x60;InternalConfigId&#x60;  ### Get a record of Entity * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Id** | **String**| The identifier of the Entity record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **Name** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional] [default to null] |

### Return type

[**Entity**](../Models/Entity.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

<a name="list Entities"></a>
# **list Entities**
> Entities list Entities(Fields, Filters, Orders, CurrentPage, PageSize)



    Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended &#x60;Entity&#x60; representation. In this format, all foreign key fields are depicted as abstract object structures, employing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: &#x60;InternalConfigId&#x60;  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&amp;#39;s name, and a limit is set to return a maximum of 1000 rows.  &#x60;&#x60;&#x60;http fields&#x3D;Name,ExternalId,Email&amp;amp;Filters&#x3D;(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &amp;gt; 2022-01-01)&amp;amp;Orders&#x3D;Name ASC&amp;amp;PageSize&#x3D;1000 &#x60;&#x60;&#x60;

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Fields** | **String**| Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, Application, InternalConfigId, Is_Active, CreatedOn &#x60;&#x60;&#x60; | [optional] [default to null] |
| **Filters** | **String**| In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional] [default to null] |
| **Orders** | **String**| The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional] [default to null] |
| **CurrentPage** | **Integer**| This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **PageSize** | **Integer**| The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Entities**](../Models/Entities.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

