# Agile.Now.AccessHub.Api.DepartmentsApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDepartment**](DepartmentsApi.md#createdepartment) | **POST** /Endpoint/rest/api/v1/Department |  |
| [**DeleteDepartment**](DepartmentsApi.md#deletedepartment) | **DELETE** /Endpoint/rest/api/v1/Department/{Id} |  |
| [**DeleteDepartmentUser**](DepartmentsApi.md#deletedepartmentuser) | **DELETE** /Endpoint/rest/api/v1/Department/{Id}/User/{SubId} |  |
| [**GetDepartment**](DepartmentsApi.md#getdepartment) | **GET** /Endpoint/rest/api/v1/Department/{Id} |  |
| [**ListDepartmentUsers**](DepartmentsApi.md#listdepartmentusers) | **GET** /Endpoint/rest/api/v1/Department/{Id}/Users |  |
| [**ListDepartments**](DepartmentsApi.md#listdepartments) | **GET** /Endpoint/rest/api/v1/Departments |  |
| [**PatchDepartmentUsers**](DepartmentsApi.md#patchdepartmentusers) | **PATCH** /Endpoint/rest/api/v1/Department/{Id}/Users |  |
| [**UpdateDepartment**](DepartmentsApi.md#updatedepartment) | **PUT** /Endpoint/rest/api/v1/Department/{Id} |  |
| [**UpsertDepartment**](DepartmentsApi.md#upsertdepartment) | **PATCH** /Endpoint/rest/api/v1/Department |  |
| [**UpsertDepartmentUser**](DepartmentsApi.md#upsertdepartmentuser) | **POST** /Endpoint/rest/api/v1/Department/{Id}/User |  |

<a id="createdepartment"></a>
# **CreateDepartment**
> Department CreateDepartment (DepartmentInsertData departmentInsertData)

Use the `DepartmentInsertData` object resource to create new records.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `DepartmentInsertData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy`

### Create a new record of Department
* If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentInsertData`).
* If the value in the `Name, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentInsertData`).
* If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

The response body will contain the object of the created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class CreateDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var departmentInsertData = new DepartmentInsertData(); // DepartmentInsertData | `Department` information to insert.  The input parameter must be used in the `DepartmentInsertData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                Department result = apiInstance.CreateDepartment(departmentInsertData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.CreateDepartment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDepartmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Department> response = apiInstance.CreateDepartmentWithHttpInfo(departmentInsertData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.CreateDepartment: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **departmentInsertData** | [**DepartmentInsertData**](models/DepartmentInsertData.md) | &#x60;Department&#x60; information to insert.  The input parameter must be used in the &#x60;DepartmentInsertData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**Department**](models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted &#x60;Department&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedepartment"></a>
# **DeleteDepartment**
> Department DeleteDepartment (string id, string name = null)

Use the query string resource to delete `Department` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy`

### Delete a record of Department
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

The response body will contain the object of the deleted record if the call is successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class DeleteDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var id = "id_example";  // string | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId ``` (optional) 

            try
            {
                Department result = apiInstance.DeleteDepartment(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.DeleteDepartment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDepartmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Department> response = apiInstance.DeleteDepartmentWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.DeleteDepartment: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Department**](models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;Department&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedepartmentuser"></a>
# **DeleteDepartmentUser**
> User DeleteDepartmentUser (string id, string subId, string name = null, string subName = null)

Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`

### Delete a record of User
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

The response body will contain the object of the deleted record if the call is successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class DeleteDepartmentUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var id = "id_example";  // string | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                User result = apiInstance.DeleteDepartmentUser(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.DeleteDepartmentUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDepartmentUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<User> response = apiInstance.DeleteDepartmentUserWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.DeleteDepartmentUser: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**User**](models/User.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;User&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdepartment"></a>
# **GetDepartment**
> Department GetDepartment (string id, string name = null)

The method returns one record of the `Department`.

Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy`

### Get a record of Department
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class GetDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var id = "id_example";  // string | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId ``` (optional) 

            try
            {
                Department result = apiInstance.GetDepartment(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.GetDepartment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDepartmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Department> response = apiInstance.GetDepartmentWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.GetDepartment: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Department**](models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of &#x60;Department&#x60; information |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdepartmentusers"></a>
# **ListDepartmentUsers**
> Users ListDepartmentUsers (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`

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
    public class ListDepartmentUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var id = "id_example";  // string | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Users result = apiInstance.ListDepartmentUsers(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.ListDepartmentUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDepartmentUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Users> response = apiInstance.ListDepartmentUsersWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.ListDepartmentUsers: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Users**](models/Users.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Users |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdepartments"></a>
# **ListDepartments**
> Departments ListDepartments (string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy`

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
    public class ListDepartmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, DepartmentTypeId, ParentDepartmentId, HierarchicalName, Level, ContactName, ContactEmail, ContactPhone, OwnerId, CountryId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Departments result = apiInstance.ListDepartments(fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.ListDepartments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDepartmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Departments> response = apiInstance.ListDepartmentsWithHttpInfo(fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.ListDepartments: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, ExternalId, Name, DepartmentTypeId, ParentDepartmentId, HierarchicalName, Level, ContactName, ContactEmail, ContactPhone, OwnerId, CountryId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Departments**](models/Departments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Departments |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchdepartmentusers"></a>
# **PatchDepartmentUsers**
> Users PatchDepartmentUsers (string id, UsersData1 usersData1, string name = null, string deleteNotExists = null)

Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.

Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`

### Update a record of User
* When the Id field value is not provided, the system will automatically initiate the insertion of a new record.

**Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.

### Create a new record of User
* If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).

The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class PatchDepartmentUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var id = "id_example";  // string | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var usersData1 = new UsersData1(); // UsersData1 | The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var deleteNotExists = "\"false\"";  // string | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional)  (default to "false")

            try
            {
                Users result = apiInstance.PatchDepartmentUsers(id, usersData1, name, deleteNotExists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.PatchDepartmentUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchDepartmentUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Users> response = apiInstance.PatchDepartmentUsersWithHttpInfo(id, usersData1, name, deleteNotExists);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.PatchDepartmentUsers: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **usersData1** | [**UsersData1**](models/UsersData1.md) | The list of User information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **deleteNotExists** | **string** | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to &quot;false&quot;] |

### Return type

[**Users**](models/Users.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated list of User information.   |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedepartment"></a>
# **UpdateDepartment**
> Department UpdateDepartment (string id, DepartmentUpdateData departmentUpdateData, string name = null)

Use the `DepartmentUpdateData` object resource to update `Department` using `Id, Name, ExternalId` field(s) value.

Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record. 

The input parameter must be used in the `DepartmentUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy`

### Update a record of Department
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

The response body will contain the object of the updated record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpdateDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var id = "id_example";  // string | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var departmentUpdateData = new DepartmentUpdateData(); // DepartmentUpdateData | Department information to update.  The input parameter must be used in the `DepartmentUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId ``` (optional) 

            try
            {
                Department result = apiInstance.UpdateDepartment(id, departmentUpdateData, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.UpdateDepartment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDepartmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Department> response = apiInstance.UpdateDepartmentWithHttpInfo(id, departmentUpdateData, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.UpdateDepartment: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **departmentUpdateData** | [**DepartmentUpdateData**](models/DepartmentUpdateData.md) | Department information to update.  The input parameter must be used in the &#x60;DepartmentUpdateData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Department**](models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated &#x60;Department&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertdepartment"></a>
# **UpsertDepartment**
> Department UpsertDepartment (DepartmentData departmentData)

Use the `DepartmentData` object resource to insert or update (Upsert) `Department` using `Id, Name, ExternalId` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy`

### Update a record of Department
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `Name, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId` field value (if set, the value is a unique identifier).

### Create a new record of Department
* If the value in the `Name, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).

The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpsertDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var departmentData = new DepartmentData(); // DepartmentData | `Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                Department result = apiInstance.UpsertDepartment(departmentData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.UpsertDepartment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertDepartmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Department> response = apiInstance.UpsertDepartmentWithHttpInfo(departmentData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.UpsertDepartment: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **departmentData** | [**DepartmentData**](models/DepartmentData.md) | &#x60;Department&#x60; information to insert or update.  The input parameter must be used in the &#x60;DepartmentData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**Department**](models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;Department&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertdepartmentuser"></a>
# **UpsertDepartmentUser**
> User UpsertDepartmentUser (string id, UserData userData, string name = null)

Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`

### Update a record of User
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* When the Id field value is not provided, the system will automatically initiate the insertion of a new record.

### Create a new record of User
* If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).

The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpsertDepartmentUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentsApi(config);
            var id = "id_example";  // string | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var userData = new UserData(); // UserData | `User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                User result = apiInstance.UpsertDepartmentUser(id, userData, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.UpsertDepartmentUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
                Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
                Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
                Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
                Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
                // Human-readable explanation of the errors
                Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertDepartmentUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<User> response = apiInstance.UpsertDepartmentUserWithHttpInfo(id, userData, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.UpsertDepartmentUser: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);         // The HTTP response code
    Debug.Print("Title: " + e.Error.Title);             // Brief, human-readable message about the error
    Debug.Print("Type: " + e.Error.Type);               // URI identifier that categorizes the error
    Debug.Print("Instance: " + e.Error.Instance);       // URI that identifies the specific occurrence of the error
    Debug.Print("RequestKey: " + e.Error.RequestKey);   // Provides a request key that identifies the current request.
    // Human-readable explanation of the errors
    Debug.Print("Errors: " + string.Join(", ", e.Error.Errors));
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **userData** | [**UserData**](models/UserData.md) | &#x60;User&#x60; information to insert or update.  The input parameter must be used in the &#x60;UserData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**User**](models/User.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;User&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

