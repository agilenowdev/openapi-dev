# Agile.Now.ApiAccessGroups.Api.AccessGroupApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAccessGroup**](AccessGroupApi.md#createaccessgroup) | **POST** /Endpoint/rest/api/v1/AccessGroup |  |
| [**DeleteAccessGroup**](AccessGroupApi.md#deleteaccessgroup) | **DELETE** /Endpoint/rest/api/v1/AccessGroup/{Id} |  |
| [**DeleteAccessGroupAccessApplication**](AccessGroupApi.md#deleteaccessgroupaccessapplication) | **DELETE** /Endpoint/rest/api/v1/AccessGroup/{Id}/AccessApplication/{SubId} |  |
| [**DeleteAccessGroupPermission**](AccessGroupApi.md#deleteaccessgrouppermission) | **DELETE** /Endpoint/rest/api/v1/AccessGroup/{Id}/Permission/{SubId} |  |
| [**GetAccessGroup**](AccessGroupApi.md#getaccessgroup) | **GET** /Endpoint/rest/api/v1/AccessGroup/{Id} |  |
| [**ListAccessGroup**](AccessGroupApi.md#listaccessgroup) | **GET** /Endpoint/rest/api/v1/AccessGroup |  |
| [**ListAccessGroupAccessApplications**](AccessGroupApi.md#listaccessgroupaccessapplications) | **GET** /Endpoint/rest/api/v1/AccessGroup/{Id}/AccessApplications |  |
| [**ListAccessGroupPermissions**](AccessGroupApi.md#listaccessgrouppermissions) | **GET** /Endpoint/rest/api/v1/AccessGroup/{Id}/Permissions |  |
| [**PatchAccessGroupAccessApplications**](AccessGroupApi.md#patchaccessgroupaccessapplications) | **PATCH** /Endpoint/rest/api/v1/AccessGroup/{Id}/AccessApplications |  |
| [**PatchAccessGroupPermissions**](AccessGroupApi.md#patchaccessgrouppermissions) | **PATCH** /Endpoint/rest/api/v1/AccessGroup/{Id}/Permissions |  |
| [**UpdateAccessGroup**](AccessGroupApi.md#updateaccessgroup) | **PUT** /Endpoint/rest/api/v1/AccessGroup/{Id} |  |
| [**UpsertAccessGroup**](AccessGroupApi.md#upsertaccessgroup) | **PATCH** /Endpoint/rest/api/v1/AccessGroup |  |
| [**UpsertAccessGroupAccessApplication**](AccessGroupApi.md#upsertaccessgroupaccessapplication) | **POST** /Endpoint/rest/api/v1/AccessGroup/{Id}/AccessApplication |  |
| [**UpsertAccessGroupPermission**](AccessGroupApi.md#upsertaccessgrouppermission) | **POST** /Endpoint/rest/api/v1/AccessGroup/{Id}/Permission |  |

<a id="createaccessgroup"></a>
# **CreateAccessGroup**
> AccessGroup CreateAccessGroup (AccessGroupData accessGroupData)



Use the `AccessGroupData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupTypeId, ModifiedBy, CreatedBy`  ### Create a new record of AccessGroup * If the value in the `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`). * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`AccessGroupData`). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class CreateAccessGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var accessGroupData = new AccessGroupData(); // AccessGroupData | `AccessGroup` information to insert.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                AccessGroup result = apiInstance.CreateAccessGroup(accessGroupData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.CreateAccessGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAccessGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroup> response = apiInstance.CreateAccessGroupWithHttpInfo(accessGroupData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.CreateAccessGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accessGroupData** | [**AccessGroupData**](AccessGroupData.md) | &#x60;AccessGroup&#x60; information to insert.  The input parameter must be used in the &#x60;AccessGroupData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**AccessGroup**](AccessGroup.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted &#x60;AccessGroup&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaccessgroup"></a>
# **DeleteAccessGroup**
> AccessGroup DeleteAccessGroup (string id, string? name = null)



Use the query string resource to delete `AccessGroup` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupTypeId, ModifiedBy, CreatedBy`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class DeleteAccessGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                AccessGroup result = apiInstance.DeleteAccessGroup(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.DeleteAccessGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAccessGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroup> response = apiInstance.DeleteAccessGroupWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.DeleteAccessGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**AccessGroup**](AccessGroup.md)

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

<a id="deleteaccessgroupaccessapplication"></a>
# **DeleteAccessGroupAccessApplication**
> AccessApplication DeleteAccessGroupAccessApplication (string id, string subId, string? name = null, string? subName = null)



Use the query string resource to delete `AccessApplication` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessApplication` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, ParentApplicationId, AccessApplicationId`  ### Delete a record of AccessApplication * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class DeleteAccessGroupAccessApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the AccessApplication record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                AccessApplication result = apiInstance.DeleteAccessGroupAccessApplication(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.DeleteAccessGroupAccessApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAccessGroupAccessApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessApplication> response = apiInstance.DeleteAccessGroupAccessApplicationWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.DeleteAccessGroupAccessApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the AccessApplication record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**AccessApplication**](AccessApplication.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;AccessApplication&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaccessgrouppermission"></a>
# **DeleteAccessGroupPermission**
> Permission DeleteAccessGroupPermission (string id, string subId, string? name = null, string? subName = null)



Use the query string resource to delete `Permission` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Permission` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, AccessRoleId, RoleId, PermissionId`  ### Delete a record of Permission * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class DeleteAccessGroupPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the Permission record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                Permission result = apiInstance.DeleteAccessGroupPermission(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.DeleteAccessGroupPermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAccessGroupPermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Permission> response = apiInstance.DeleteAccessGroupPermissionWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.DeleteAccessGroupPermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the Permission record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Permission**](Permission.md)

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

<a id="getaccessgroup"></a>
# **GetAccessGroup**
> AccessGroup GetAccessGroup (string id, string? name = null)



The method returns one record of the `AccessGroup`.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupTypeId, ModifiedBy, CreatedBy`  ### Get a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class GetAccessGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                AccessGroup result = apiInstance.GetAccessGroup(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.GetAccessGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccessGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroup> response = apiInstance.GetAccessGroupWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.GetAccessGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**AccessGroup**](AccessGroup.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of &#x60;AccessGroup&#x60; information |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listaccessgroup"></a>
# **ListAccessGroup**
> AccessGroup ListAccessGroup (string? fields = null, string? filters = null, string? orders = null, int? currentPage = null, int? pageSize = null)



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupTypeId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class ListAccessGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var fields = "fields_example";  // string? | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ExternalId, Description, Is_Active, Is_System, AccessGroupTypeId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string? | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string? | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                AccessGroup result = apiInstance.ListAccessGroup(fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.ListAccessGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccessGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroup> response = apiInstance.ListAccessGroupWithHttpInfo(fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.ListAccessGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fields** | **string?** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, ExternalId, Description, Is_Active, Is_System, AccessGroupTypeId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string?** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string?** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**AccessGroup**](AccessGroup.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of AccessGroup |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listaccessgroupaccessapplications"></a>
# **ListAccessGroupAccessApplications**
> AccessApplications ListAccessGroupAccessApplications (string id, string? name = null, string? fields = null, string? filters = null, string? orders = null, int? currentPage = null, int? pageSize = null)



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessApplication` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, ParentApplicationId, AccessApplicationId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class ListAccessGroupAccessApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string? | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, ParentApplicationId, AccessApplicationId, Is_Active, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string? | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string? | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                AccessApplications result = apiInstance.ListAccessGroupAccessApplications(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.ListAccessGroupAccessApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccessGroupAccessApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessApplications> response = apiInstance.ListAccessGroupAccessApplicationsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.ListAccessGroupAccessApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string?** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, AccessGroupId, ParentApplicationId, AccessApplicationId, Is_Active, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string?** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string?** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**AccessApplications**](AccessApplications.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of AccessApplications |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listaccessgrouppermissions"></a>
# **ListAccessGroupPermissions**
> Permissions ListAccessGroupPermissions (string id, string? name = null, string? fields = null, string? filters = null, string? orders = null, int? currentPage = null, int? pageSize = null)



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Permission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, AccessRoleId, RoleId, PermissionId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class ListAccessGroupPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string? | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, AccessRoleId, RoleId, PermissionId, Is_Active, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string? | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string? | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Permissions result = apiInstance.ListAccessGroupPermissions(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.ListAccessGroupPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccessGroupPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Permissions> response = apiInstance.ListAccessGroupPermissionsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.ListAccessGroupPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string?** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, AccessGroupId, AccessRoleId, RoleId, PermissionId, Is_Active, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string?** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string?** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Permissions**](Permissions.md)

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

<a id="patchaccessgroupaccessapplications"></a>
# **PatchAccessGroupAccessApplications**
> AccessApplication PatchAccessGroupAccessApplications (string id, AccessApplicationsData accessApplicationsData, string? name = null, string? deleteNotExists = null)



Use the `AccessApplicationsData` object resource to insert or update (Upsert) a list of `AccessApplicationData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessApplicationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `AccessGroupId, ParentApplicationId, AccessApplicationId`  ### Update a record of AccessApplication * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of AccessApplication * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`AccessApplicationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `AccessApplication` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class PatchAccessGroupAccessApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var accessApplicationsData = new AccessApplicationsData(); // AccessApplicationsData | The list of AccessApplication information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var deleteNotExists = "\"false\"";  // string? | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional)  (default to "false")

            try
            {
                AccessApplication result = apiInstance.PatchAccessGroupAccessApplications(id, accessApplicationsData, name, deleteNotExists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.PatchAccessGroupAccessApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchAccessGroupAccessApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessApplication> response = apiInstance.PatchAccessGroupAccessApplicationsWithHttpInfo(id, accessApplicationsData, name, deleteNotExists);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.PatchAccessGroupAccessApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **accessApplicationsData** | [**AccessApplicationsData**](AccessApplicationsData.md) | The list of AccessApplication information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **deleteNotExists** | **string?** | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to &quot;false&quot;] |

### Return type

[**AccessApplication**](AccessApplication.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated list of AccessApplication information.   |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchaccessgrouppermissions"></a>
# **PatchAccessGroupPermissions**
> Permission PatchAccessGroupPermissions (string id, PermissionsData permissionsData, string? name = null, string? deleteNotExists = null)



Use the `PermissionsData` object resource to insert or update (Upsert) a list of `PermissionData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `PermissionList` record structure as text fields in the foreign key fields.  Foreign key fields are: `AccessGroupId, AccessRoleId, RoleId, PermissionId`  ### Update a record of Permission * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Permission * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`PermissionData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Permission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class PatchAccessGroupPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var permissionsData = new PermissionsData(); // PermissionsData | The list of Permission information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var deleteNotExists = "\"false\"";  // string? | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional)  (default to "false")

            try
            {
                Permission result = apiInstance.PatchAccessGroupPermissions(id, permissionsData, name, deleteNotExists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.PatchAccessGroupPermissions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchAccessGroupPermissionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Permission> response = apiInstance.PatchAccessGroupPermissionsWithHttpInfo(id, permissionsData, name, deleteNotExists);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.PatchAccessGroupPermissionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **permissionsData** | [**PermissionsData**](PermissionsData.md) | The list of Permission information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **deleteNotExists** | **string?** | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to &quot;false&quot;] |

### Return type

[**Permission**](Permission.md)

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

<a id="updateaccessgroup"></a>
# **UpdateAccessGroup**
> AccessGroup UpdateAccessGroup (string id, AccessGroupData accessGroupData, string? name = null)



Use the `AccessGroupData` object resource to update `AccessGroup` using `Id` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupTypeId, ModifiedBy, CreatedBy`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class UpdateAccessGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var accessGroupData = new AccessGroupData(); // AccessGroupData | AccessGroup information to update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional) 

            try
            {
                AccessGroup result = apiInstance.UpdateAccessGroup(id, accessGroupData, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.UpdateAccessGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAccessGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroup> response = apiInstance.UpdateAccessGroupWithHttpInfo(id, accessGroupData, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.UpdateAccessGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **accessGroupData** | [**AccessGroupData**](AccessGroupData.md) | AccessGroup information to update.  The input parameter must be used in the &#x60;AccessGroupData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**AccessGroup**](AccessGroup.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated &#x60;AccessGroup&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertaccessgroup"></a>
# **UpsertAccessGroup**
> AccessGroup UpsertAccessGroup (AccessGroupData accessGroupData)



Use the `AccessGroupData` object resource to insert or update (Upsert) `AccessGroup` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupTypeId, ModifiedBy, CreatedBy`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of AccessGroup * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class UpsertAccessGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var accessGroupData = new AccessGroupData(); // AccessGroupData | `AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                AccessGroup result = apiInstance.UpsertAccessGroup(accessGroupData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.UpsertAccessGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAccessGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessGroup> response = apiInstance.UpsertAccessGroupWithHttpInfo(accessGroupData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.UpsertAccessGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accessGroupData** | [**AccessGroupData**](AccessGroupData.md) | &#x60;AccessGroup&#x60; information to insert or update.  The input parameter must be used in the &#x60;AccessGroupData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**AccessGroup**](AccessGroup.md)

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

<a id="upsertaccessgroupaccessapplication"></a>
# **UpsertAccessGroupAccessApplication**
> AccessApplication UpsertAccessGroupAccessApplication (string id, AccessApplicationData accessApplicationData, string? name = null)



Use the `AccessApplicationPost` object resource to insert or update (Upsert) `AccessApplication` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, ParentApplicationId, AccessApplicationId`  ### Update a record of AccessApplication * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of AccessApplication * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`AccessApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessApplication` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class UpsertAccessGroupAccessApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var accessApplicationData = new AccessApplicationData(); // AccessApplicationData | `AccessApplication` information to insert or update.  The input parameter must be used in the `AccessApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                AccessApplication result = apiInstance.UpsertAccessGroupAccessApplication(id, accessApplicationData, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.UpsertAccessGroupAccessApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAccessGroupAccessApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessApplication> response = apiInstance.UpsertAccessGroupAccessApplicationWithHttpInfo(id, accessApplicationData, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.UpsertAccessGroupAccessApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **accessApplicationData** | [**AccessApplicationData**](AccessApplicationData.md) | &#x60;AccessApplication&#x60; information to insert or update.  The input parameter must be used in the &#x60;AccessApplicationData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**AccessApplication**](AccessApplication.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;AccessApplication&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertaccessgrouppermission"></a>
# **UpsertAccessGroupPermission**
> Permission UpsertAccessGroupPermission (string id, PermissionData permissionData, string? name = null)



Use the `PermissionPost` object resource to insert or update (Upsert) `Permission` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `PermissionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, AccessRoleId, RoleId, PermissionId`  ### Update a record of Permission * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Permission * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`PermissionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Permission` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

namespace Example
{
    public class UpsertAccessGroupPermissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessGroupApi(config);
            var id = "id_example";  // string | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
            var permissionData = new PermissionData(); // PermissionData | `Permission` information to insert or update.  The input parameter must be used in the `PermissionData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string? | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                Permission result = apiInstance.UpsertAccessGroupPermission(id, permissionData, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessGroupApi.UpsertAccessGroupPermission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAccessGroupPermissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Permission> response = apiInstance.UpsertAccessGroupPermissionWithHttpInfo(id, permissionData, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessGroupApi.UpsertAccessGroupPermissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t |  |
| **permissionData** | [**PermissionData**](PermissionData.md) | &#x60;Permission&#x60; information to insert or update.  The input parameter must be used in the &#x60;PermissionData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string?** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Permission**](Permission.md)

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

