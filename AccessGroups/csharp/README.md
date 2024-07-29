# Agile.Now.ApiAccessGroups - the C# library for the AccessGroups API documentation

## Introduction
The OpenAPI Specification (OAS) defines a standard, language-agnostic interface to RESTful APIs which allows both humans and computers to discover and understand the capabilities of the service without access to source code, documentation, or through network traffic inspection. When properly defined, a consumer can understand and interact with the remote service with a minimal amount of implementation logic.

An OpenAPI definition can then be used by documentation generation tools to display the API, code generation tools to generate servers and clients in various programming languages, testing tools, and many other use cases.

| Version | URL | Description |
| - -- | - -- | - -- |
| v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |
| v3 | https://dev.esystems.fi/Endpoint/rest/Doc/v3/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents all patches of OpenAPI V3.0 spec (e.g. 3.0.0, 3.0.1). |
| v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Json/AccessGroups | Serializes to the Open API document as a string in the JSON format and represents OpenAPI V2.0 spec.|
| v2 | https://dev.esystems.fi/Endpoint/rest/Doc/v2/Yaml/AccessGroups | Serializes to the Open API document as a string in the Yaml format and represents OpenAPI V2.0 spec. |

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 3.0.8
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
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Agile.Now.ApiAccessGroups.csproj
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
using Agile.Now.ApiAccessGroups.Api;
using Agile.Now.ApiAccessGroups.Client;
using Agile.Now.ApiAccessGroups.Model;

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

            var apiInstance = new AccessGroupsApi(config);
            var accessGroupData = new AccessGroupData(); // AccessGroupData | `AccessGroup` information to insert.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.

            try
            {
                AccessGroup result = apiInstance.CreateAccessGroup(accessGroupData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccessGroupsApi.CreateAccessGroup: " + e.Message );
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
*AccessGroupsApi* | [**CreateAccessGroup**](docs/AccessGroupsApi.md#createaccessgroup) | **POST** /Endpoint/rest/api/v1/AccessGroup | 
*AccessGroupsApi* | [**DeleteAccessGroup**](docs/AccessGroupsApi.md#deleteaccessgroup) | **DELETE** /Endpoint/rest/api/v1/AccessGroup/{Id} | 
*AccessGroupsApi* | [**DeleteAccessGroupAccessApplication**](docs/AccessGroupsApi.md#deleteaccessgroupaccessapplication) | **DELETE** /Endpoint/rest/api/v1/AccessGroup/{Id}/AccessApplication/{SubId} | 
*AccessGroupsApi* | [**DeleteAccessGroupPermission**](docs/AccessGroupsApi.md#deleteaccessgrouppermission) | **DELETE** /Endpoint/rest/api/v1/AccessGroup/{Id}/Permission/{SubId} | 
*AccessGroupsApi* | [**GetAccessGroup**](docs/AccessGroupsApi.md#getaccessgroup) | **GET** /Endpoint/rest/api/v1/AccessGroup/{Id} | 
*AccessGroupsApi* | [**ListAccessGroupAccessApplications**](docs/AccessGroupsApi.md#listaccessgroupaccessapplications) | **GET** /Endpoint/rest/api/v1/AccessGroup/{Id}/AccessApplications | 
*AccessGroupsApi* | [**ListAccessGroupPermissions**](docs/AccessGroupsApi.md#listaccessgrouppermissions) | **GET** /Endpoint/rest/api/v1/AccessGroup/{Id}/Permissions | 
*AccessGroupsApi* | [**ListAccessGroups**](docs/AccessGroupsApi.md#listaccessgroups) | **GET** /Endpoint/rest/api/v1/AccessGroups | 
*AccessGroupsApi* | [**PatchAccessGroupAccessApplications**](docs/AccessGroupsApi.md#patchaccessgroupaccessapplications) | **PATCH** /Endpoint/rest/api/v1/AccessGroup/{Id}/AccessApplications | 
*AccessGroupsApi* | [**PatchAccessGroupPermissions**](docs/AccessGroupsApi.md#patchaccessgrouppermissions) | **PATCH** /Endpoint/rest/api/v1/AccessGroup/{Id}/Permissions | 
*AccessGroupsApi* | [**UpdateAccessGroup**](docs/AccessGroupsApi.md#updateaccessgroup) | **PUT** /Endpoint/rest/api/v1/AccessGroup/{Id} | 
*AccessGroupsApi* | [**UpsertAccessGroup**](docs/AccessGroupsApi.md#upsertaccessgroup) | **PATCH** /Endpoint/rest/api/v1/AccessGroup | 
*AccessGroupsApi* | [**UpsertAccessGroupAccessApplication**](docs/AccessGroupsApi.md#upsertaccessgroupaccessapplication) | **POST** /Endpoint/rest/api/v1/AccessGroup/{Id}/AccessApplication | 
*AccessGroupsApi* | [**UpsertAccessGroupPermission**](docs/AccessGroupsApi.md#upsertaccessgrouppermission) | **POST** /Endpoint/rest/api/v1/AccessGroup/{Id}/Permission | 
*GroupsApi* | [**CreateGroup**](docs/GroupsApi.md#creategroup) | **POST** /Endpoint/rest/api/v1/Group | 
*GroupsApi* | [**DeleteGroup**](docs/GroupsApi.md#deletegroup) | **DELETE** /Endpoint/rest/api/v1/Group/{Id} | 
*GroupsApi* | [**GetGroup**](docs/GroupsApi.md#getgroup) | **GET** /Endpoint/rest/api/v1/Group/{Id} | 
*GroupsApi* | [**ListGroups**](docs/GroupsApi.md#listgroups) | **GET** /Endpoint/rest/api/v1/Groups | 
*GroupsApi* | [**PatchGroups**](docs/GroupsApi.md#patchgroups) | **PATCH** /Endpoint/rest/api/v1/Groups/Json | 
*GroupsApi* | [**UpdateGroup**](docs/GroupsApi.md#updategroup) | **PUT** /Endpoint/rest/api/v1/Group/{Id} | 
*GroupsApi* | [**UpsertGroup**](docs/GroupsApi.md#upsertgroup) | **PATCH** /Endpoint/rest/api/v1/Group | 


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AbstractLong](docs/AbstractLong.md)
 - [Model.AbstractText](docs/AbstractText.md)
 - [Model.AccessApplication](docs/AccessApplication.md)
 - [Model.AccessApplicationData](docs/AccessApplicationData.md)
 - [Model.AccessApplicationText](docs/AccessApplicationText.md)
 - [Model.AccessApplications](docs/AccessApplications.md)
 - [Model.AccessApplicationsData](docs/AccessApplicationsData.md)
 - [Model.AccessGroup](docs/AccessGroup.md)
 - [Model.AccessGroupData](docs/AccessGroupData.md)
 - [Model.AccessGroups](docs/AccessGroups.md)
 - [Model.EnumAccessGroupType](docs/EnumAccessGroupType.md)
 - [Model.EnumPermissionType](docs/EnumPermissionType.md)
 - [Model.Error](docs/Error.md)
 - [Model.FieldType](docs/FieldType.md)
 - [Model.Group](docs/Group.md)
 - [Model.GroupData](docs/GroupData.md)
 - [Model.GroupText](docs/GroupText.md)
 - [Model.Groups](docs/Groups.md)
 - [Model.GroupsData](docs/GroupsData.md)
 - [Model.ListValidation](docs/ListValidation.md)
 - [Model.Meta](docs/Meta.md)
 - [Model.Permission](docs/Permission.md)
 - [Model.PermissionData](docs/PermissionData.md)
 - [Model.PermissionText](docs/PermissionText.md)
 - [Model.Permissions](docs/Permissions.md)
 - [Model.PermissionsData](docs/PermissionsData.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="OAuth2"></a>
### OAuth2

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - AccessManager:Read: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessUser:Read: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessManager:Create, Update: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessUser:Create, Update: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessManager:Create: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessUser:Create: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessManager:Update: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessUser:Update: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessManager:Delete: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessUser:Delete: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessManager:Import: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
  - AccessUser:Import: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
