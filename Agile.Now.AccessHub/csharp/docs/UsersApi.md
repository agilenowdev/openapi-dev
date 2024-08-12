# Agile.Now.AccessHub.Api.UsersApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteUserAccessGroup**](UsersApi.md#deleteuseraccessgroup) | **DELETE** /Endpoint/rest/api/v1/User/{Id}/AccessGroup/{SubId} |  |
| [**DeleteUserDepartment**](UsersApi.md#deleteuserdepartment) | **DELETE** /Endpoint/rest/api/v1/User/{Id}/Department/{SubId} |  |
| [**DeleteUserGroup**](UsersApi.md#deleteusergroup) | **DELETE** /Endpoint/rest/api/v1/User/{Id}/Group/{SubId} |  |
| [**DeleteUserLocation**](UsersApi.md#deleteuserlocation) | **DELETE** /Endpoint/rest/api/v1/User/{Id}/Location/{SubId} |  |
| [**GetUser**](UsersApi.md#getuser) | **GET** /Endpoint/rest/api/v1/User/{Id} |  |
| [**ListUserAccessGroups**](UsersApi.md#listuseraccessgroups) | **GET** /Endpoint/rest/api/v1/User/{Id}/AccessGroups |  |
| [**ListUserAccessRoles**](UsersApi.md#listuseraccessroles) | **GET** /Endpoint/rest/api/v1/User/{Id}/AccessRoles |  |
| [**ListUserApplications**](UsersApi.md#listuserapplications) | **GET** /Endpoint/rest/api/v1/User/{Id}/Applications |  |
| [**ListUserDepartments**](UsersApi.md#listuserdepartments) | **GET** /Endpoint/rest/api/v1/User/{Id}/Departments |  |
| [**ListUserEffectivePermissions**](UsersApi.md#listusereffectivepermissions) | **GET** /Endpoint/rest/api/v1/User/{Id}/EffectivePermissions |  |
| [**ListUserGroups**](UsersApi.md#listusergroups) | **GET** /Endpoint/rest/api/v1/User/{Id}/Groups |  |
| [**ListUserLocations**](UsersApi.md#listuserlocations) | **GET** /Endpoint/rest/api/v1/User/{Id}/Locations |  |
| [**ListUsers**](UsersApi.md#listusers) | **GET** /Endpoint/rest/api/v1/Users |  |
| [**PatchUserDepartments**](UsersApi.md#patchuserdepartments) | **PATCH** /Endpoint/rest/api/v1/User/{Id}/Departments |  |
| [**PatchUserLocations**](UsersApi.md#patchuserlocations) | **PATCH** /Endpoint/rest/api/v1/User/{Id}/Locations |  |
| [**UpsertUserAccessGroup**](UsersApi.md#upsertuseraccessgroup) | **POST** /Endpoint/rest/api/v1/User/{Id}/AccessGroup |  |
| [**UpsertUserDepartment**](UsersApi.md#upsertuserdepartment) | **POST** /Endpoint/rest/api/v1/User/{Id}/Department |  |
| [**UpsertUserGroup**](UsersApi.md#upsertusergroup) | **POST** /Endpoint/rest/api/v1/User/{Id}/Group |  |
| [**UpsertUserLocation**](UsersApi.md#upsertuserlocation) | **POST** /Endpoint/rest/api/v1/User/{Id}/Location |  |

<a id="deleteuseraccessgroup"></a>
# **DeleteUserAccessGroup**
> AccessGroup1 DeleteUserAccessGroup (string id, string subId, string name = null, string subName = null)

Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `AccessGroupId, UserId`

### Delete a record of AccessGroup
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

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
    public class DeleteUserAccessGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional) 

            try
            {
                AccessGroup1 result = apiInstance.DeleteUserAccessGroup(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserAccessGroup: " + e.Message);
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

#### Using the DeleteUserAccessGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroup1> response = apiInstance.DeleteUserAccessGroupWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteUserAccessGroup: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; UserId.Email, UserId.Username &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**AccessGroup1**](models/AccessGroup1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;AccessGroup&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuserdepartment"></a>
# **DeleteUserDepartment**
> Department1 DeleteUserDepartment (string id, string subId, string name = null, string subName = null)

Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`

### Delete a record of Department
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

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
    public class DeleteUserDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional) 

            try
            {
                Department1 result = apiInstance.DeleteUserDepartment(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserDepartment: " + e.Message);
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

#### Using the DeleteUserDepartmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Department1> response = apiInstance.DeleteUserDepartmentWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteUserDepartment: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; UserId.Email, UserId.Username &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Department1**](models/Department1.md)

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

<a id="deleteusergroup"></a>
# **DeleteUserGroup**
> Group1 DeleteUserGroup (string id, string subId, string name = null, string subName = null)

Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `User_Id, Group_Id`

### Delete a record of Group
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

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
    public class DeleteUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional) 

            try
            {
                Group1 result = apiInstance.DeleteUserGroup(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserGroup: " + e.Message);
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

#### Using the DeleteUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Group1> response = apiInstance.DeleteUserGroupWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteUserGroup: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; UserId.Email, UserId.Username &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Group1**](models/Group1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;Group&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuserlocation"></a>
# **DeleteUserLocation**
> Location1 DeleteUserLocation (string id, string subId, string name = null, string subName = null)

Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`

### Delete a record of Location
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

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
    public class DeleteUserLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional) 

            try
            {
                Location1 result = apiInstance.DeleteUserLocation(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserLocation: " + e.Message);
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

#### Using the DeleteUserLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Location1> response = apiInstance.DeleteUserLocationWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteUserLocation: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; UserId.Email, UserId.Username &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Location1**](models/Location1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;Location&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuser"></a>
# **GetUser**
> User2 GetUser (string id, string name = null)

The method returns one record of the `User`.

Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: ``

### Get a record of User
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
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                User2 result = apiInstance.GetUser(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message);
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

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<User2> response = apiInstance.GetUserWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**User2**](models/User2.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of &#x60;User&#x60; information |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listuseraccessgroups"></a>
# **ListUserAccessGroups**
> AccessGroups1 ListUserAccessGroups (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `AccessGroupId, UserId`

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
    public class ListUserAccessGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                AccessGroups1 result = apiInstance.ListUserAccessGroups(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ListUserAccessGroups: " + e.Message);
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

#### Using the ListUserAccessGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroups1> response = apiInstance.ListUserAccessGroupsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ListUserAccessGroups: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, AccessGroupId, UserId, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**AccessGroups1**](models/AccessGroups1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of AccessGroups |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listuseraccessroles"></a>
# **ListUserAccessRoles**
> AccessRoles ListUserAccessRoles (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

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
    public class ListUserAccessRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, RoleId, ApplicationId, EspaceId, Is_Active, Is_Custom, Is_ReadOnly, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                AccessRoles result = apiInstance.ListUserAccessRoles(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ListUserAccessRoles: " + e.Message);
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

#### Using the ListUserAccessRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessRoles> response = apiInstance.ListUserAccessRolesWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ListUserAccessRoles: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, RoleId, ApplicationId, EspaceId, Is_Active, Is_Custom, Is_ReadOnly, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**AccessRoles**](models/AccessRoles.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of AccessRoles |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listuserapplications"></a>
# **ListUserApplications**
> Applications1 ListUserApplications (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`

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
    public class ListUserApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ApplicationId, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_TestApp, Is_Active, Is_ReadOnly, AuthenticationId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Applications1 result = apiInstance.ListUserApplications(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ListUserApplications: " + e.Message);
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

#### Using the ListUserApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Applications1> response = apiInstance.ListUserApplicationsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ListUserApplications: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, ApplicationId, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_TestApp, Is_Active, Is_ReadOnly, AuthenticationId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Applications1**](models/Applications1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Applications |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listuserdepartments"></a>
# **ListUserDepartments**
> Departments1 ListUserDepartments (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

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
    public class ListUserDepartmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Departments1 result = apiInstance.ListUserDepartments(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ListUserDepartments: " + e.Message);
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

#### Using the ListUserDepartmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Departments1> response = apiInstance.ListUserDepartmentsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ListUserDepartments: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Departments1**](models/Departments1.md)

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

<a id="listusereffectivepermissions"></a>
# **ListUserEffectivePermissions**
> EffectivePermissions ListUserEffectivePermissions (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`

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
    public class ListUserEffectivePermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                EffectivePermissions result = apiInstance.ListUserEffectivePermissions(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ListUserEffectivePermissions: " + e.Message);
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

#### Using the ListUserEffectivePermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EffectivePermissions> response = apiInstance.ListUserEffectivePermissionsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ListUserEffectivePermissions: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**EffectivePermissions**](models/EffectivePermissions.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of EffectivePermissions |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listusergroups"></a>
# **ListUserGroups**
> Groups1 ListUserGroups (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `User_Id, Group_Id`

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
    public class ListUserGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Groups1 result = apiInstance.ListUserGroups(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ListUserGroups: " + e.Message);
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

#### Using the ListUserGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Groups1> response = apiInstance.ListUserGroupsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ListUserGroups: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, User_Id, Group_Id &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Groups1**](models/Groups1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Groups |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listuserlocations"></a>
# **ListUserLocations**
> Locations1 ListUserLocations (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`

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
    public class ListUserLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Locations1 result = apiInstance.ListUserLocations(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ListUserLocations: " + e.Message);
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

#### Using the ListUserLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Locations1> response = apiInstance.ListUserLocationsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ListUserLocations: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Locations1**](models/Locations1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of Locations |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listusers"></a>
# **ListUsers**
> Users2 ListUsers (string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.

Leverage the search service to extract the requisite information from the system effectively.

The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

The foreign key fields involved are: ``

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
    public class ListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Users2 result = apiInstance.ListUsers(fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ListUsers: " + e.Message);
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

#### Using the ListUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Users2> response = apiInstance.ListUsersWithHttpInfo(fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ListUsers: " + e.Message);
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
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Users2**](models/Users2.md)

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

<a id="patchuserdepartments"></a>
# **PatchUserDepartments**
> Department1 PatchUserDepartments (string id, DepartmentsData departmentsData, string name = null, string deleteNotExists = null)

Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.

Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`

### Update a record of Department
* If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).

**Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.

### Create a new record of Department
* If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).

The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class PatchUserDepartmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var departmentsData = new DepartmentsData(); // DepartmentsData | The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var deleteNotExists = "\"false\"";  // string | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional)  (default to "false")

            try
            {
                Department1 result = apiInstance.PatchUserDepartments(id, departmentsData, name, deleteNotExists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserDepartments: " + e.Message);
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

#### Using the PatchUserDepartmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Department1> response = apiInstance.PatchUserDepartmentsWithHttpInfo(id, departmentsData, name, deleteNotExists);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.PatchUserDepartments: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **departmentsData** | [**DepartmentsData**](models/DepartmentsData.md) | The list of Department information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **deleteNotExists** | **string** | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to &quot;false&quot;] |

### Return type

[**Department1**](models/Department1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated list of Department information.   |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchuserlocations"></a>
# **PatchUserLocations**
> Location1 PatchUserLocations (string id, LocationsData locationsData, string name = null, string deleteNotExists = null)

Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.

Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`

### Update a record of Location
* If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).

**Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.

### Create a new record of Location
* If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).

The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class PatchUserLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var locationsData = new LocationsData(); // LocationsData | The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var deleteNotExists = "\"false\"";  // string | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional)  (default to "false")

            try
            {
                Location1 result = apiInstance.PatchUserLocations(id, locationsData, name, deleteNotExists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUserLocations: " + e.Message);
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

#### Using the PatchUserLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Location1> response = apiInstance.PatchUserLocationsWithHttpInfo(id, locationsData, name, deleteNotExists);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.PatchUserLocations: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **locationsData** | [**LocationsData**](models/LocationsData.md) | The list of Location information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **deleteNotExists** | **string** | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to &quot;false&quot;] |

### Return type

[**Location1**](models/Location1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated list of Location information.   |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertuseraccessgroup"></a>
# **UpsertUserAccessGroup**
> AccessGroup1 UpsertUserAccessGroup (string id, AccessGroupData1 accessGroupData1, string name = null)

Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `AccessGroupId, UserId`

### Update a record of AccessGroup
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).

### Create a new record of AccessGroup
* If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).

The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpsertUserAccessGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var accessGroupData1 = new AccessGroupData1(); // AccessGroupData1 | `AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                AccessGroup1 result = apiInstance.UpsertUserAccessGroup(id, accessGroupData1, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpsertUserAccessGroup: " + e.Message);
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

#### Using the UpsertUserAccessGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroup1> response = apiInstance.UpsertUserAccessGroupWithHttpInfo(id, accessGroupData1, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpsertUserAccessGroup: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **accessGroupData1** | [**AccessGroupData1**](models/AccessGroupData1.md) | &#x60;AccessGroup&#x60; information to insert or update.  The input parameter must be used in the &#x60;AccessGroupData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**AccessGroup1**](models/AccessGroup1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;AccessGroup&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertuserdepartment"></a>
# **UpsertUserDepartment**
> Department1 UpsertUserDepartment (string id, DepartmentData1 departmentData1, string name = null)

Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`

### Update a record of Department
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).

### Create a new record of Department
* If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).

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
    public class UpsertUserDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var departmentData1 = new DepartmentData1(); // DepartmentData1 | `Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                Department1 result = apiInstance.UpsertUserDepartment(id, departmentData1, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpsertUserDepartment: " + e.Message);
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

#### Using the UpsertUserDepartmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Department1> response = apiInstance.UpsertUserDepartmentWithHttpInfo(id, departmentData1, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpsertUserDepartment: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **departmentData1** | [**DepartmentData1**](models/DepartmentData1.md) | &#x60;Department&#x60; information to insert or update.  The input parameter must be used in the &#x60;DepartmentData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Department1**](models/Department1.md)

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

<a id="upsertusergroup"></a>
# **UpsertUserGroup**
> Group1 UpsertUserGroup (string id, GroupData1 groupData1, string name = null)

Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `User_Id, Group_Id`

### Update a record of Group
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).

### Create a new record of Group
* If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).

The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpsertUserGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var groupData1 = new GroupData1(); // GroupData1 | `Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                Group1 result = apiInstance.UpsertUserGroup(id, groupData1, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpsertUserGroup: " + e.Message);
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

#### Using the UpsertUserGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Group1> response = apiInstance.UpsertUserGroupWithHttpInfo(id, groupData1, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpsertUserGroup: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **groupData1** | [**GroupData1**](models/GroupData1.md) | &#x60;Group&#x60; information to insert or update.  The input parameter must be used in the &#x60;GroupData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Group1**](models/Group1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;Group&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertuserlocation"></a>
# **UpsertUserLocation**
> Location1 UpsertUserLocation (string id, LocationData1 locationData1, string name = null)

Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`

### Update a record of Location
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).

### Create a new record of Location
* If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).

The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpsertUserLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var id = "id_example";  // string | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var locationData1 = new LocationData1(); // LocationData1 | `Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                Location1 result = apiInstance.UpsertUserLocation(id, locationData1, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpsertUserLocation: " + e.Message);
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

#### Using the UpsertUserLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Location1> response = apiInstance.UpsertUserLocationWithHttpInfo(id, locationData1, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpsertUserLocation: " + e.Message);
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
| **id** | **string** | The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **locationData1** | [**LocationData1**](models/LocationData1.md) | &#x60;Location&#x60; information to insert or update.  The input parameter must be used in the &#x60;LocationData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Location1**](models/Location1.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;Location&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

