# Agile.Now.AccessHub.Api.EntitiesApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEntity**](EntitiesApi.md#getentity) | **GET** /Endpoint/rest/api/v1/Entity/{Id} |  |
| [**ListEntities**](EntitiesApi.md#listentities) | **GET** /Endpoint/rest/api/v1/Entities |  |

<a id="getentity"></a>
# **GetEntity**
> Entity GetEntity (string id, string name = null)

The method returns one record of the `Entity`.

Method returns an extended `Entity` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `InternalConfigId`

### Get a record of Entity
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class GetEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EntitiesApi(config);
            var id = "id_example";  // string | The identifier of the Entity record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                Entity result = apiInstance.GetEntity(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesApi.GetEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Entity> response = apiInstance.GetEntityWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesApi.GetEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Entity record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Entity**](Entity.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of &#x60;Entity&#x60; information |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listentities"></a>
# **ListEntities**
> Entities ListEntities (string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `Entity` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `InternalConfigId`

### Example
It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.

```http
fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000
```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class ListEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EntitiesApi(config);
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Application, InternalConfigId, Is_Active, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Entities result = apiInstance.ListEntities(fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesApi.ListEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Entities> response = apiInstance.ListEntitiesWithHttpInfo(fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesApi.ListEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, Application, InternalConfigId, Is_Active, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Entities**](Entities.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Entities |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

