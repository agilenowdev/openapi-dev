# Agile.Now.ApiOrganizations - the C# library for the Organization API

## Introduction
The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.

An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.

| Version | URL | Description |
| - -- | - -- | - -- |
| v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |
| v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |
| v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/Organizations | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|
| v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/Organizations | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.0.100
- SDK version: 2.0.0
- Generator version: 7.6.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Agile.Now.ApiOrganizations.Api;
using Agile.Now.ApiOrganizations.Client;
using Agile.Now.ApiOrganizations.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Agile.Now.ApiOrganizations.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Agile.Now.ApiOrganizations.Api;
using Agile.Now.ApiOrganizations.Client;
using Agile.Now.ApiOrganizations.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DepartmentsApi.CreateDepartment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://dev.esystems.fi*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DepartmentsApi* | [**CreateDepartment**](docs/DepartmentsApi.md#createdepartment) | **POST** /Endpoint/rest/api/v1/Department | 
*DepartmentsApi* | [**DeleteDepartment**](docs/DepartmentsApi.md#deletedepartment) | **DELETE** /Endpoint/rest/api/v1/Department/{Id} | 
*DepartmentsApi* | [**DeleteDepartmentUser**](docs/DepartmentsApi.md#deletedepartmentuser) | **DELETE** /Endpoint/rest/api/v1/Department/{Id}/User/{SubId} | 
*DepartmentsApi* | [**GetDepartment**](docs/DepartmentsApi.md#getdepartment) | **GET** /Endpoint/rest/api/v1/Department/{Id} | 
*DepartmentsApi* | [**ListDepartmentUsers**](docs/DepartmentsApi.md#listdepartmentusers) | **GET** /Endpoint/rest/api/v1/Department/{Id}/Users | 
*DepartmentsApi* | [**ListDepartments**](docs/DepartmentsApi.md#listdepartments) | **GET** /Endpoint/rest/api/v1/Departments | 
*DepartmentsApi* | [**PatchDepartmentUsers**](docs/DepartmentsApi.md#patchdepartmentusers) | **PATCH** /Endpoint/rest/api/v1/Department/{Id}/Users | 
*DepartmentsApi* | [**UpdateDepartment**](docs/DepartmentsApi.md#updatedepartment) | **PUT** /Endpoint/rest/api/v1/Department/{Id} | 
*DepartmentsApi* | [**UpsertDepartment**](docs/DepartmentsApi.md#upsertdepartment) | **PATCH** /Endpoint/rest/api/v1/Department | 
*DepartmentsApi* | [**UpsertDepartmentUser**](docs/DepartmentsApi.md#upsertdepartmentuser) | **POST** /Endpoint/rest/api/v1/Department/{Id}/User | 
*LocationsApi* | [**CreateLocation**](docs/LocationsApi.md#createlocation) | **POST** /Endpoint/rest/api/v1/Location | 
*LocationsApi* | [**DeleteLocation**](docs/LocationsApi.md#deletelocation) | **DELETE** /Endpoint/rest/api/v1/Location/{Id} | 
*LocationsApi* | [**DeleteLocationUser**](docs/LocationsApi.md#deletelocationuser) | **DELETE** /Endpoint/rest/api/v1/Location/{Id}/User/{SubId} | 
*LocationsApi* | [**GetLocation**](docs/LocationsApi.md#getlocation) | **GET** /Endpoint/rest/api/v1/Location/{Id} | 
*LocationsApi* | [**ListLocationUsers**](docs/LocationsApi.md#listlocationusers) | **GET** /Endpoint/rest/api/v1/Location/{Id}/Users | 
*LocationsApi* | [**ListLocations**](docs/LocationsApi.md#listlocations) | **GET** /Endpoint/rest/api/v1/Locations | 
*LocationsApi* | [**PatchLocationUsers**](docs/LocationsApi.md#patchlocationusers) | **PATCH** /Endpoint/rest/api/v1/Location/{Id}/Users | 
*LocationsApi* | [**UpdateLocation**](docs/LocationsApi.md#updatelocation) | **PUT** /Endpoint/rest/api/v1/Location/{Id} | 
*LocationsApi* | [**UpsertLocation**](docs/LocationsApi.md#upsertlocation) | **PATCH** /Endpoint/rest/api/v1/Location | 
*LocationsApi* | [**UpsertLocationUser**](docs/LocationsApi.md#upsertlocationuser) | **POST** /Endpoint/rest/api/v1/Location/{Id}/User | 


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AbstractLong](docs/AbstractLong.md)
 - [Model.AbstractText](docs/AbstractText.md)
 - [Model.Department](docs/Department.md)
 - [Model.DepartmentData](docs/DepartmentData.md)
 - [Model.DepartmentInsertData](docs/DepartmentInsertData.md)
 - [Model.DepartmentUpdateData](docs/DepartmentUpdateData.md)
 - [Model.Departments](docs/Departments.md)
 - [Model.EnumCountry](docs/EnumCountry.md)
 - [Model.EnumCurrency](docs/EnumCurrency.md)
 - [Model.EnumDepartmentType](docs/EnumDepartmentType.md)
 - [Model.EnumTimezone](docs/EnumTimezone.md)
 - [Model.Error](docs/Error.md)
 - [Model.FieldType](docs/FieldType.md)
 - [Model.ListValidation](docs/ListValidation.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationData](docs/LocationData.md)
 - [Model.LocationInsertData](docs/LocationInsertData.md)
 - [Model.LocationUpdateData](docs/LocationUpdateData.md)
 - [Model.Locations](docs/Locations.md)
 - [Model.Meta](docs/Meta.md)
 - [Model.User](docs/User.md)
 - [Model.UserData](docs/UserData.md)
 - [Model.UserText](docs/UserText.md)
 - [Model.Users](docs/Users.md)
 - [Model.UsersData](docs/UsersData.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="OAuth2"></a>
### OAuth2

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - Department:Read: The role of department concept. (ABAC) permissions required to perform a function.
  - Department:Create, Update: The role of department concept. (ABAC) permissions required to perform a function.
  - Department:Create: The role of department concept. (ABAC) permissions required to perform a function.
  - Department:Update: The role of department concept. (ABAC) permissions required to perform a function.
  - Department:Delete: The role of department concept. (ABAC) permissions required to perform a function.
  - Location:Read: The role of location concept. (ABAC) permissions required to perform a function.
  - Location:Create, Update: The role of location concept. (ABAC) permissions required to perform a function.
  - Location:Create: The role of location concept. (ABAC) permissions required to perform a function.
  - Location:Update: The role of location concept. (ABAC) permissions required to perform a function.
  - Location:Delete: The role of location concept. (ABAC) permissions required to perform a function.
