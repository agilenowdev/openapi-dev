# Agile.Now.AccessHub.Api.ApplicationsApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApplication**](ApplicationsApi.md#createapplication) | **POST** /Endpoint/rest/api/v1/Application |  |
| [**DeleteApplication**](ApplicationsApi.md#deleteapplication) | **DELETE** /Endpoint/rest/api/v1/Application/{Id} |  |
| [**DeleteApplicationRole**](ApplicationsApi.md#deleteapplicationrole) | **DELETE** /Endpoint/rest/api/v1/Application/{Id}/Role/{SubId} |  |
| [**GetApplication**](ApplicationsApi.md#getapplication) | **GET** /Endpoint/rest/api/v1/Application/{Id} |  |
| [**ListApplicationRoles**](ApplicationsApi.md#listapplicationroles) | **GET** /Endpoint/rest/api/v1/Application/{Id}/Roles |  |
| [**ListApplications**](ApplicationsApi.md#listapplications) | **GET** /Endpoint/rest/api/v1/Applications |  |
| [**UpdateApplication**](ApplicationsApi.md#updateapplication) | **PUT** /Endpoint/rest/api/v1/Application/{Id} |  |
| [**UpsertApplication**](ApplicationsApi.md#upsertapplication) | **PATCH** /Endpoint/rest/api/v1/Application |  |
| [**UpsertApplicationRole**](ApplicationsApi.md#upsertapplicationrole) | **POST** /Endpoint/rest/api/v1/Application/{Id}/Role |  |

<a id="createapplication"></a>
# **CreateApplication**
> Application CreateApplication (ApplicationData1 applicationData1)

Use the `ApplicationData` object resource to create new records.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`

### Create a new record of Application
* If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).
* If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).
* If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class CreateApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var applicationData1 = new ApplicationData1(); // ApplicationData1 | `Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                Application result = apiInstance.CreateApplication(applicationData1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.CreateApplication: " + e.Message);
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

#### Using the CreateApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Application> response = apiInstance.CreateApplicationWithHttpInfo(applicationData1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.CreateApplication: " + e.Message);
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
| **applicationData1** | [**ApplicationData1**](models/ApplicationData1.md) | &#x60;Application&#x60; information to insert.  The input parameter must be used in the &#x60;ApplicationData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**Application**](models/Application.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted &#x60;Application&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapplication"></a>
# **DeleteApplication**
> Application DeleteApplication (string id, string name = null)

Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`

### Delete a record of Application
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

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
    public class DeleteApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = "id_example";  // string | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional) 

            try
            {
                Application result = apiInstance.DeleteApplication(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.DeleteApplication: " + e.Message);
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

#### Using the DeleteApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Application> response = apiInstance.DeleteApplicationWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.DeleteApplication: " + e.Message);
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
| **id** | **string** | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId, ApplicationKey &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Application**](models/Application.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted &#x60;Application&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapplicationrole"></a>
# **DeleteApplicationRole**
> Role DeleteApplicationRole (string id, string subId, string name = null, string subName = null)

Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.

Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`

### Delete a record of Role
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

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
    public class DeleteApplicationRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = "id_example";  // string | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var subId = "subId_example";  // string | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var subName = "subName_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional) 

            try
            {
                Role result = apiInstance.DeleteApplicationRole(id, subId, name, subName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.DeleteApplicationRole: " + e.Message);
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

#### Using the DeleteApplicationRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Role> response = apiInstance.DeleteApplicationRoleWithHttpInfo(id, subId, name, subName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.DeleteApplicationRole: " + e.Message);
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
| **id** | **string** | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **subId** | **string** | The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **subName** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, RoleKey, ExternalId &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Role**](models/Role.md)

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

<a id="getapplication"></a>
# **GetApplication**
> Application GetApplication (string id, string name = null)

The method returns one record of the `Application`.

Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`

### Get a record of Application
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class GetApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = "id_example";  // string | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional) 

            try
            {
                Application result = apiInstance.GetApplication(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.GetApplication: " + e.Message);
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

#### Using the GetApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Application> response = apiInstance.GetApplicationWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.GetApplication: " + e.Message);
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
| **id** | **string** | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId, ApplicationKey &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Application**](models/Application.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of &#x60;Application&#x60; information |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listapplicationroles"></a>
# **ListApplicationRoles**
> Roles ListApplicationRoles (string id, string name = null, string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

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
    public class ListApplicationRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = "id_example";  // string | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, RoleId, ApplicationId, EspaceId, Is_Active, Is_Custom, Is_ReadOnly, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Roles result = apiInstance.ListApplicationRoles(id, name, fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ListApplicationRoles: " + e.Message);
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

#### Using the ListApplicationRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Roles> response = apiInstance.ListApplicationRolesWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.ListApplicationRoles: " + e.Message);
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
| **id** | **string** | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, RoleId, ApplicationId, EspaceId, Is_Active, Is_Custom, Is_ReadOnly, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Roles**](models/Roles.md)

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

<a id="listapplications"></a>
# **ListApplications**
> Applications ListApplications (string fields = null, string filters = null, string orders = null, int? currentPage = null, int? pageSize = null)

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
    public class ListApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var fields = "fields_example";  // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ApplicationId, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_TestApp, Is_Active, Is_ReadOnly, AuthenticationId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional) 
            var filters = "filters_example";  // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional) 
            var orders = "orders_example";  // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional) 
            var currentPage = 0;  // int? | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional)  (default to 0)
            var pageSize = 0;  // int? | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional)  (default to 0)

            try
            {
                Applications result = apiInstance.ListApplications(fields, filters, orders, currentPage, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.ListApplications: " + e.Message);
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

#### Using the ListApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Applications> response = apiInstance.ListApplicationsWithHttpInfo(fields, filters, orders, currentPage, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.ListApplications: " + e.Message);
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
| **fields** | **string** | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, ApplicationId, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_TestApp, Is_Active, Is_ReadOnly, AuthenticationId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional]  |
| **filters** | **string** | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional]  |
| **orders** | **string** | The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional]  |
| **currentPage** | **int?** | This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **pageSize** | **int?** | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Applications**](models/Applications.md)

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

<a id="updateapplication"></a>
# **UpdateApplication**
> Application UpdateApplication (string id, ApplicationData1 applicationData1, string name = null)

Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.

Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record. 

The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`

### Update a record of Application
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
* If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpdateApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = "id_example";  // string | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var applicationData1 = new ApplicationData1(); // ApplicationData1 | Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional) 

            try
            {
                Application result = apiInstance.UpdateApplication(id, applicationData1, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.UpdateApplication: " + e.Message);
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

#### Using the UpdateApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Application> response = apiInstance.UpdateApplicationWithHttpInfo(id, applicationData1, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.UpdateApplication: " + e.Message);
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
| **id** | **string** | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **applicationData1** | [**ApplicationData1**](models/ApplicationData1.md) | Application information to update.  The input parameter must be used in the &#x60;ApplicationData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId, ApplicationKey &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Application**](models/Application.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated &#x60;Application&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertapplication"></a>
# **UpsertApplication**
> Application UpsertApplication (ApplicationData1 applicationData1)

Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`

### Update a record of Application
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).

### Create a new record of Application
* If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).

The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Example
{
    public class UpsertApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var applicationData1 = new ApplicationData1(); // ApplicationData1 | `Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                Application result = apiInstance.UpsertApplication(applicationData1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.UpsertApplication: " + e.Message);
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

#### Using the UpsertApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Application> response = apiInstance.UpsertApplicationWithHttpInfo(applicationData1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.UpsertApplication: " + e.Message);
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
| **applicationData1** | [**ApplicationData1**](models/ApplicationData1.md) | &#x60;Application&#x60; information to insert or update.  The input parameter must be used in the &#x60;ApplicationData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |

### Return type

[**Application**](models/Application.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted or updated &#x60;Application&#x60; information. |  -  |
| **400** | Bad Request - The user has provided input that the browser is unable to convert. |  -  |
| **401** | Unauthorized - The response status code indicates that the client request has not been completed because it lacks valid authentication credentials for the requested resource. |  -  |
| **403** | Forbidden - The user does not have access to execute operation |  -  |
| **500** | Internal Server Error - An internal server error is an error on the web server you&#39;re trying to access. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertapplicationrole"></a>
# **UpsertApplicationRole**
> Role UpsertApplicationRole (string id, RoleData roleData, string name = null)

Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.

You can supply the required field values in the request data, and then use the `POST` method of the resource.

The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.

Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`

### Update a record of Role
* If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key).
* If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).

### Create a new record of Role
* If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).

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
    public class UpsertApplicationRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://dev.esystems.fi";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = "id_example";  // string | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t
            var roleData = new RoleData(); // RoleData | `Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.
            var name = "name_example";  // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional) 

            try
            {
                Role result = apiInstance.UpsertApplicationRole(id, roleData, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.UpsertApplicationRole: " + e.Message);
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

#### Using the UpsertApplicationRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Role> response = apiInstance.UpsertApplicationRoleWithHttpInfo(id, roleData, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.UpsertApplicationRole: " + e.Message);
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
| **id** | **string** | The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t |  |
| **roleData** | [**RoleData**](models/RoleData.md) | &#x60;Role&#x60; information to insert or update.  The input parameter must be used in the &#x60;RoleData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. |  |
| **name** | **string** | The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional]  |

### Return type

[**Role**](models/Role.md)

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

