# Agile.Now.AccessHub.Api.RolesApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRole**](RolesApi.md#createrole) | **POST** /Endpoint/rest/api/v1/Role |  |
| [**DeleteRole**](RolesApi.md#deleterole) | **DELETE** /Endpoint/rest/api/v1/Role/{Id} |  |
| [**DeleteRolePermission**](RolesApi.md#deleterolepermission) | **DELETE** /Endpoint/rest/api/v1/Role/{Id}/Permission/{SubId} |  |
| [**GetRole**](RolesApi.md#getrole) | **GET** /Endpoint/rest/api/v1/Role/{Id} |  |
| [**ListRolePermissions**](RolesApi.md#listrolepermissions) | **GET** /Endpoint/rest/api/v1/Role/{Id}/Permissions |  |
| [**ListRoles**](RolesApi.md#listroles) | **GET** /Endpoint/rest/api/v1/Roles |  |
| [**PatchRolePermissions**](RolesApi.md#patchrolepermissions) | **PATCH** /Endpoint/rest/api/v1/Role/{Id}/Permissions |  |
| [**UpdateRole**](RolesApi.md#updaterole) | **PUT** /Endpoint/rest/api/v1/Role/{Id} |  |
| [**UpsertRole**](RolesApi.md#upsertrole) | **PATCH** /Endpoint/rest/api/v1/Role |  |
| [**UpsertRolePermission**](RolesApi.md#upsertrolepermission) | **POST** /Endpoint/rest/api/v1/Role/{Id}/Permission |  |

<a id="createrole"></a>
# **CreateRole**
> Role1 CreateRole (RoleData1 roleData1)

Use the `RoleData` object resource to create new records.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`

### Create a new record of Role
* If the value in the `Id, Name, RoleKey` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).
* If the value in the `Name, RoleKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).
* If the `Id, Name, RoleKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

The response body will contain the object of the created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class CreateRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var roleData1 = new RoleData1(); // RoleData1 | `Role` information to insert.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                Role1 result = apiInstance.CreateRole(roleData1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.CreateRole: " + e.Message);
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

#### Using the CreateRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Role1> response = apiInstance.CreateRoleWithHttpInfo(roleData1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.CreateRole: " + e.Message);
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
| **roleData1** | [**RoleData1**](models/RoleData1.md) | &#x60;Role&#x60; information to insert.  The input parameter must be used in the &#x60;RoleData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**Role1**](models/Role1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted &#x60;Role&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterole"></a>
# **DeleteRole**
> Role1 DeleteRole (string id, string name = null)

Use the query string resource to delete `Role` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, RoleKey` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`

### Delete a record of Role
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, RoleKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

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
    public class DeleteRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var id = "id_example";  // string | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey ``` (optional) 

            try
            {
                Role1 result = apiInstance.DeleteRole(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRole: " + e.Message);
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

#### Using the DeleteRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Role1> response = apiInstance.DeleteRoleWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.DeleteRole: " + e.Message);
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
| **id** | **string** | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, RoleKey &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Role1**](models/Role1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;Role&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterolepermission"></a>
# **DeleteRolePermission**
> Permission1 DeleteRolePermission (string id, string subId, string name = null, string subName = null)

Use the query string resource to delete `Permission` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, PermissionId` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `Permission` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `AccessRoleId, RoleId, PermissionId`

### Delete a record of Permission
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, PermissionId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

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
    public class DeleteRolePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var id = "id_example";  // string | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the Permission record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` PermissionId ``` (optional) 

            try
            {
                Permission1 result = apiInstance.DeleteRolePermission(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.DeleteRolePermission: " + e.Message);
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

#### Using the DeleteRolePermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Permission1> response = apiInstance.DeleteRolePermissionWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.DeleteRolePermission: " + e.Message);
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
| **id** | **string** | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the Permission record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; PermissionId &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Permission1**](models/Permission1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;Permission&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrole"></a>
# **GetRole**
> Role1 GetRole (string id, string name = null)

The method returns one record of the `Role`.

Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`

### Get a record of Role
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, RoleKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class GetRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var id = "id_example";  // string | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey ``` (optional) 

            try
            {
                Role1 result = apiInstance.GetRole(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.GetRole: " + e.Message);
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

#### Using the GetRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Role1> response = apiInstance.GetRoleWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.GetRole: " + e.Message);
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
| **id** | **string** | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, RoleKey &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Role1**](models/Role1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of &#x60;Role&#x60; information |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrolepermissions"></a>
# **ListRolePermissions**
> Permissions1 ListRolePermissions (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `Permission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `AccessRoleId, RoleId, PermissionId`

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
    public class ListRolePermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var id = "id_example";  // string | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessRoleId, PermissionId, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Permissions1 result = apiInstance.ListRolePermissions(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.ListRolePermissions: " + e.Message);
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

#### Using the ListRolePermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Permissions1> response = apiInstance.ListRolePermissionsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.ListRolePermissions: " + e.Message);
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
| **id** | **string** | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, AccessRoleId, PermissionId, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Permissions1**](models/Permissions1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Permissions |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listroles"></a>
# **ListRoles**
> Roles1 ListRoles (string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`

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
    public class ListRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, Is_Custom, Is_ReadOnly, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Roles1 result = apiInstance.ListRoles(fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.ListRoles: " + e.Message);
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

#### Using the ListRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Roles1> response = apiInstance.ListRolesWithHttpInfo(fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.ListRoles: " + e.Message);
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
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, Is_Custom, Is_ReadOnly, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Roles1**](models/Roles1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Roles |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchrolepermissions"></a>
# **PatchRolePermissions**
> Permissions1 PatchRolePermissions (string id, PermissionsData1 permissionsData1, string name = null, string deleteNotExists = null)

Use the `PermissionsData` object resource to insert or update (Upsert) a list of `PermissionData` using `Id, PermissionId` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `PermissionList` record structure as text fields in the foreign key fields.

Foreign key fields are: `AccessRoleId, RoleId, PermissionId`

### Update a record of Permission
* If the `PermissionId` field value is not empty and `Id` field value is empty, action try insert record according `PermissionId` field value (if set, the value is a unique identifier).

**Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.

### Create a new record of Permission
* If the value in the `PermissionId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`PermissionData`).

The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Permission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class PatchRolePermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var id = "id_example";  // string | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var permissionsData1 = new PermissionsData1(); // PermissionsData1 | The list of Permission information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var deleteNotExists = "\"false\"";  // string | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional)  (default to "false")

            try
            {
                Permissions1 result = apiInstance.PatchRolePermissions(id, permissionsData1, name, deleteNotExists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.PatchRolePermissions: " + e.Message);
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

#### Using the PatchRolePermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Permissions1> response = apiInstance.PatchRolePermissionsWithHttpInfo(id, permissionsData1, name, deleteNotExists);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.PatchRolePermissions: " + e.Message);
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
| **id** | **string** | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **permissionsData1** | [**PermissionsData1**](models/PermissionsData1.md) | The list of Permission information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **deleteNotExists** | **string** | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to &quot;false&quot;] |

### Return type

[**Permissions1**](models/Permissions1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated list of Permission information.   |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updaterole"></a>
# **UpdateRole**
> Role1 UpdateRole (string id, RoleData1 roleData1, string name = null)

Use the `RoleData` object resource to update `Role` using `Id, Name, RoleKey` field(s) value.

Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record. 

The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`

### Update a record of Role
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, RoleKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

The response body will contain the object of the updated record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpdateRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var id = "id_example";  // string | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var roleData1 = new RoleData1(); // RoleData1 | Role information to update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey ``` (optional) 

            try
            {
                Role1 result = apiInstance.UpdateRole(id, roleData1, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.UpdateRole: " + e.Message);
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

#### Using the UpdateRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Role1> response = apiInstance.UpdateRoleWithHttpInfo(id, roleData1, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.UpdateRole: " + e.Message);
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
| **id** | **string** | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **roleData1** | [**RoleData1**](models/RoleData1.md) | Role information to update.  The input parameter must be used in the &#x60;RoleData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, RoleKey &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Role1**](models/Role1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated &#x60;Role&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertrole"></a>
# **UpsertRole**
> Role1 UpsertRole (RoleData1 roleData1)

Use the `RoleData` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`

### Update a record of Role
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `Name, RoleKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey` field value (if set, the value is a unique identifier).

### Create a new record of Role
* If the value in the `Name, RoleKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).

The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpsertRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var roleData1 = new RoleData1(); // RoleData1 | `Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                Role1 result = apiInstance.UpsertRole(roleData1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.UpsertRole: " + e.Message);
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

#### Using the UpsertRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Role1> response = apiInstance.UpsertRoleWithHttpInfo(roleData1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.UpsertRole: " + e.Message);
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
| **roleData1** | [**RoleData1**](models/RoleData1.md) | &#x60;Role&#x60; information to insert or update.  The input parameter must be used in the &#x60;RoleData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**Role1**](models/Role1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;Role&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertrolepermission"></a>
# **UpsertRolePermission**
> Permission1 UpsertRolePermission (string id, PermissionData1 permissionData1, string name = null)

Use the `PermissionPost` object resource to insert or update (Upsert) `Permission` using `Id, PermissionId` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `PermissionData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `AccessRoleId, RoleId, PermissionId`

### Update a record of Permission
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `PermissionId` field value is not empty and `Id` field value is empty, action try insert record according `PermissionId` field value (if set, the value is a unique identifier).

### Create a new record of Permission
* If the value in the `PermissionId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`PermissionData`).

The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Permission` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpsertRolePermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RolesApi(config);
            var id = "id_example";  // string | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var permissionData1 = new PermissionData1(); // PermissionData1 | `Permission` information to insert or update.  The input parameter must be used in the `PermissionData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                Permission1 result = apiInstance.UpsertRolePermission(id, permissionData1, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RolesApi.UpsertRolePermission: " + e.Message);
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

#### Using the UpsertRolePermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Permission1> response = apiInstance.UpsertRolePermissionWithHttpInfo(id, permissionData1, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RolesApi.UpsertRolePermission: " + e.Message);
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
| **id** | **string** | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **permissionData1** | [**PermissionData1**](models/PermissionData1.md) | &#x60;Permission&#x60; information to insert or update.  The input parameter must be used in the &#x60;PermissionData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Permission1**](models/Permission1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;Permission&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

