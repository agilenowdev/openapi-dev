# Agile\.Now\.AccessHub.Api.ConnectionsApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateConnection**](ConnectionsApi.md#createconnection) | **POST** /Endpoint/rest/api/v1/Connection |  |
| [**DeleteConnection**](ConnectionsApi.md#deleteconnection) | **DELETE** /Endpoint/rest/api/v1/Connection/{Id} |  |
| [**DeleteConnectionConfig**](ConnectionsApi.md#deleteconnectionconfig) | **DELETE** /Endpoint/rest/api/v1/Connection/{Id}/Config/{SubId} |  |
| [**GetConnection**](ConnectionsApi.md#getconnection) | **GET** /Endpoint/rest/api/v1/Connection/{Id} |  |
| [**ListConnectionConfigs**](ConnectionsApi.md#listconnectionconfigs) | **GET** /Endpoint/rest/api/v1/Connection/{Id}/Configs |  |
| [**ListConnections**](ConnectionsApi.md#listconnections) | **GET** /Endpoint/rest/api/v1/Connections |  |
| [**PatchConnectionConfigs**](ConnectionsApi.md#patchconnectionconfigs) | **PATCH** /Endpoint/rest/api/v1/Connection/{Id}/Configs |  |
| [**UpdateConnection**](ConnectionsApi.md#updateconnection) | **PUT** /Endpoint/rest/api/v1/Connection/{Id} |  |
| [**UpsertConnection**](ConnectionsApi.md#upsertconnection) | **PATCH** /Endpoint/rest/api/v1/Connection |  |
| [**UpsertConnectionConfig**](ConnectionsApi.md#upsertconnectionconfig) | **POST** /Endpoint/rest/api/v1/Connection/{Id}/Config |  |

<a id="createconnection"></a>
# **CreateConnection**
> Connection CreateConnection (ConnectionData connectionData)



Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class CreateConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var connectionData = new ConnectionData(); // ConnectionData | `Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                Connection result = apiInstance.CreateConnection(connectionData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.CreateConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Connection> response = apiInstance.CreateConnectionWithHttpInfo(connectionData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.CreateConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectionData** | [**ConnectionData**](ConnectionData.md) | &#x60;Connection&#x60; information to insert.  The input parameter must be used in the &#x60;ConnectionData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**Connection**](Connection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted &#x60;Connection&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteconnection"></a>
# **DeleteConnection**
> Connection DeleteConnection (string id, string? name = null)



Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class DeleteConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var id = "id_example";  // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional) 

            try
            {
                Connection result = apiInstance.DeleteConnection(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.DeleteConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Connection> response = apiInstance.DeleteConnectionWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.DeleteConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Connection**](Connection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;Connection&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteconnectionconfig"></a>
# **DeleteConnectionConfig**
> Config DeleteConnectionConfig (string id, string subId, string? name = null, string? subName = null)



Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class DeleteConnectionConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var id = "id_example";  // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                Config result = apiInstance.DeleteConnectionConfig(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.DeleteConnectionConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteConnectionConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Config> response = apiInstance.DeleteConnectionConfigWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.DeleteConnectionConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Config**](Config.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;Config&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getconnection"></a>
# **GetConnection**
> Connection GetConnection (string id, string? name = null)



The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class GetConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var id = "id_example";  // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional) 

            try
            {
                Connection result = apiInstance.GetConnection(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.GetConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Connection> response = apiInstance.GetConnectionWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.GetConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Connection**](Connection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of &#x60;Connection&#x60; information |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listconnectionconfigs"></a>
# **ListConnectionConfigs**
> Configs ListConnectionConfigs (string id, string? name = null, string? fields = null, string? filters = null, string? orders = null, int? currentPage = null, int? pageSize = null)



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class ListConnectionConfigsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var id = "id_example";  // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string? | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string? | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string? | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Configs result = apiInstance.ListConnectionConfigs(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.ListConnectionConfigs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConnectionConfigsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Configs> response = apiInstance.ListConnectionConfigsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.ListConnectionConfigsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string?** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string?** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string?** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Configs**](Configs.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Configs |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listconnections"></a>
# **ListConnections**
> Connections ListConnections (string? fields = null, string? filters = null, string? orders = null, int? currentPage = null, int? pageSize = null)



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class ListConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var fields = "fields_example";  // string? | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string? | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string? | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Connections result = apiInstance.ListConnections(fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.ListConnections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConnectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Connections> response = apiInstance.ListConnectionsWithHttpInfo(fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.ListConnectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fields** | **string?** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string?** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string?** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Connections**](Connections.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Connections |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchconnectionconfigs"></a>
# **PatchConnectionConfigs**
> Config PatchConnectionConfigs (string id, ConfigsData configsData, string? name = null, string? deleteNotExists = null)



Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class PatchConnectionConfigsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var id = "id_example";  // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var configsData = new ConfigsData(); // ConfigsData | The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var deleteNotExists = "\"false\"";  // string? | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional)  (default to "false")

            try
            {
                Config result = apiInstance.PatchConnectionConfigs(id, configsData, name, deleteNotExists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.PatchConnectionConfigs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchConnectionConfigsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Config> response = apiInstance.PatchConnectionConfigsWithHttpInfo(id, configsData, name, deleteNotExists);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.PatchConnectionConfigsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **configsData** | [**ConfigsData**](ConfigsData.md) | The list of Config information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **deleteNotExists** | **string?** | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to &quot;false&quot;] |

### Return type

[**Config**](Config.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated list of Config information.   |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateconnection"></a>
# **UpdateConnection**
> Connection UpdateConnection (string id, ConnectionData connectionData, string? name = null)



Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class UpdateConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var id = "id_example";  // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var connectionData = new ConnectionData(); // ConnectionData | Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional) 

            try
            {
                Connection result = apiInstance.UpdateConnection(id, connectionData, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.UpdateConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Connection> response = apiInstance.UpdateConnectionWithHttpInfo(id, connectionData, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.UpdateConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **connectionData** | [**ConnectionData**](ConnectionData.md) | Connection information to update.  The input parameter must be used in the &#x60;ConnectionData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Connection**](Connection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated &#x60;Connection&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertconnection"></a>
# **UpsertConnection**
> Connection UpsertConnection (ConnectionData connectionData)



Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class UpsertConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var connectionData = new ConnectionData(); // ConnectionData | `Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                Connection result = apiInstance.UpsertConnection(connectionData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.UpsertConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Connection> response = apiInstance.UpsertConnectionWithHttpInfo(connectionData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.UpsertConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectionData** | [**ConnectionData**](ConnectionData.md) | &#x60;Connection&#x60; information to insert or update.  The input parameter must be used in the &#x60;ConnectionData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**Connection**](Connection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;Connection&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertconnectionconfig"></a>
# **UpsertConnectionConfig**
> Config UpsertConnectionConfig (string id, ConfigData configData, string? name = null)



Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile\.Now\.AccessHub.Api;
using Agile\.Now\.AccessHub.Client;
using Agile\.Now\.AccessHub.Model;

namespace Example
{
    public class UpsertConnectionConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var id = "id_example";  // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var configData = new ConfigData(); // ConfigData | `Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                Config result = apiInstance.UpsertConnectionConfig(id, configData, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.UpsertConnectionConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertConnectionConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Config> response = apiInstance.UpsertConnectionConfigWithHttpInfo(id, configData, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.UpsertConnectionConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **configData** | [**ConfigData**](ConfigData.md) | &#x60;Config&#x60; information to insert or update.  The input parameter must be used in the &#x60;ConfigData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Config**](Config.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;Config&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

