# Agile.Now.AccessHub

Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.

**Key Features:**

1. **Accounts Management:**
   - Manage user accounts with secure authentication and authorization.

2. **Access Groups:**
   - Define and manage access groups for access control.
   - Assign users to access groups based on roles and permissions.

3. **User Groups:**
   - Create and manage user groups for better organization and collaboration.

4. **Organizations & Locations:**
   - Manage multiple organizations and locations within a single platform.
   - Attribute-based access control (ABAC) for settings.

5. **Applications:**
   - Centralized management of applications within the platform.
   - Assign and monitor application usage and access.

6. **Roles:**
   - Define and manage roles for different access levels.
   - Role-based access control to ensure appropriate permissions.

7. **Webhooks:**
   - Integration with external services and applications.
   - Configure and manage webhooks for real-time notifications and data syncing.

**Benefits:**

- **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.
- **Scalability:** Designed for growing organizations.
- **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.
- **Flexibility:** Multi-tenant architecture allows easy customization.
- **Integration:** Webhook support facilitates seamless integration with external systems.

**Conclusion:**

Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.


## Installation & Usage

### Requirements

PHP 7.4 and later.
Should also work with PHP 8.0.

### Composer

To install the bindings via [Composer](https://getcomposer.org/), add the following to `composer.json`:

```json
{
  "repositories": [
    {
      "type": "vcs",
      "url": "https://github.com/GIT_USER_ID/GIT_REPO_ID.git"
    }
  ],
  "require": {
    "GIT_USER_ID/GIT_REPO_ID": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
<?php
require_once('/path/to/Agile.Now.AccessHub/vendor/autoload.php');
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');



// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$account_data = new \OpenAPI\Client\Model\AccountData(); // \OpenAPI\Client\Model\AccountData | `Account` information to insert.  The input parameter must be used in the `AccountData` record structure inside the `FieldType` parameter in the foreign key fields.

try {
    $result = $apiInstance->createAccount($account_data);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->createAccount: ', $e->getMessage(), PHP_EOL;
}

```

## API Endpoints

All URIs are relative to *https://dev.esystems.fi*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**createAccount**](docs/Api/AccountsApi.md#createaccount) | **POST** /Endpoint/rest/api/v1/Account | 
*AccountsApi* | [**deleteAccount**](docs/Api/AccountsApi.md#deleteaccount) | **DELETE** /Endpoint/rest/api/v1/Account/{Id} | 
*AccountsApi* | [**deleteAccountTenant**](docs/Api/AccountsApi.md#deleteaccounttenant) | **DELETE** /Endpoint/rest/api/v1/Account/{Id}/Tenant/{SubId} | 
*AccountsApi* | [**getAccount**](docs/Api/AccountsApi.md#getaccount) | **GET** /Endpoint/rest/api/v1/Account/{Id} | 
*AccountsApi* | [**listAccountTenants**](docs/Api/AccountsApi.md#listaccounttenants) | **GET** /Endpoint/rest/api/v1/Account/{Id}/Tenants | 
*AccountsApi* | [**listAccounts**](docs/Api/AccountsApi.md#listaccounts) | **GET** /Endpoint/rest/api/v1/Accounts | 
*AccountsApi* | [**updateAccount**](docs/Api/AccountsApi.md#updateaccount) | **PUT** /Endpoint/rest/api/v1/Account/{Id} | 
*AccountsApi* | [**upsertAccount**](docs/Api/AccountsApi.md#upsertaccount) | **PATCH** /Endpoint/rest/api/v1/Account | 
*AccountsApi* | [**upsertAccountTenant**](docs/Api/AccountsApi.md#upsertaccounttenant) | **POST** /Endpoint/rest/api/v1/Account/{Id}/Tenant | 
*ConnectionsApi* | [**createConnection**](docs/Api/ConnectionsApi.md#createconnection) | **POST** /Endpoint/rest/api/v1/Connection | 
*ConnectionsApi* | [**deleteConnection**](docs/Api/ConnectionsApi.md#deleteconnection) | **DELETE** /Endpoint/rest/api/v1/Connection/{Id} | 
*ConnectionsApi* | [**deleteConnectionConfig**](docs/Api/ConnectionsApi.md#deleteconnectionconfig) | **DELETE** /Endpoint/rest/api/v1/Connection/{Id}/Config/{SubId} | 
*ConnectionsApi* | [**getConnection**](docs/Api/ConnectionsApi.md#getconnection) | **GET** /Endpoint/rest/api/v1/Connection/{Id} | 
*ConnectionsApi* | [**listConnectionConfigs**](docs/Api/ConnectionsApi.md#listconnectionconfigs) | **GET** /Endpoint/rest/api/v1/Connection/{Id}/Configs | 
*ConnectionsApi* | [**listConnections**](docs/Api/ConnectionsApi.md#listconnections) | **GET** /Endpoint/rest/api/v1/Connections | 
*ConnectionsApi* | [**patchConnectionConfigs**](docs/Api/ConnectionsApi.md#patchconnectionconfigs) | **PATCH** /Endpoint/rest/api/v1/Connection/{Id}/Configs | 
*ConnectionsApi* | [**updateConnection**](docs/Api/ConnectionsApi.md#updateconnection) | **PUT** /Endpoint/rest/api/v1/Connection/{Id} | 
*ConnectionsApi* | [**upsertConnection**](docs/Api/ConnectionsApi.md#upsertconnection) | **PATCH** /Endpoint/rest/api/v1/Connection | 
*ConnectionsApi* | [**upsertConnectionConfig**](docs/Api/ConnectionsApi.md#upsertconnectionconfig) | **POST** /Endpoint/rest/api/v1/Connection/{Id}/Config | 
*DepartmentsApi* | [**createDepartment**](docs/Api/DepartmentsApi.md#createdepartment) | **POST** /Endpoint/rest/api/v1/Department | 
*DepartmentsApi* | [**deleteDepartment**](docs/Api/DepartmentsApi.md#deletedepartment) | **DELETE** /Endpoint/rest/api/v1/Department/{Id} | 
*DepartmentsApi* | [**deleteDepartmentUser**](docs/Api/DepartmentsApi.md#deletedepartmentuser) | **DELETE** /Endpoint/rest/api/v1/Department/{Id}/User/{SubId} | 
*DepartmentsApi* | [**getDepartment**](docs/Api/DepartmentsApi.md#getdepartment) | **GET** /Endpoint/rest/api/v1/Department/{Id} | 
*DepartmentsApi* | [**listDepartmentUsers**](docs/Api/DepartmentsApi.md#listdepartmentusers) | **GET** /Endpoint/rest/api/v1/Department/{Id}/Users | 
*DepartmentsApi* | [**listDepartments**](docs/Api/DepartmentsApi.md#listdepartments) | **GET** /Endpoint/rest/api/v1/Departments | 
*DepartmentsApi* | [**patchDepartmentUsers**](docs/Api/DepartmentsApi.md#patchdepartmentusers) | **PATCH** /Endpoint/rest/api/v1/Department/{Id}/Users | 
*DepartmentsApi* | [**patchDepartments**](docs/Api/DepartmentsApi.md#patchdepartments) | **PATCH** /Endpoint/rest/api/v1/Departments/Json | 
*DepartmentsApi* | [**updateDepartment**](docs/Api/DepartmentsApi.md#updatedepartment) | **PUT** /Endpoint/rest/api/v1/Department/{Id} | 
*DepartmentsApi* | [**upsertDepartment**](docs/Api/DepartmentsApi.md#upsertdepartment) | **PATCH** /Endpoint/rest/api/v1/Department | 
*DepartmentsApi* | [**upsertDepartmentUser**](docs/Api/DepartmentsApi.md#upsertdepartmentuser) | **POST** /Endpoint/rest/api/v1/Department/{Id}/User | 
*EntitiesApi* | [**getEntity**](docs/Api/EntitiesApi.md#getentity) | **GET** /Endpoint/rest/api/v1/Entity/{Id} | 
*EntitiesApi* | [**listEntities**](docs/Api/EntitiesApi.md#listentities) | **GET** /Endpoint/rest/api/v1/Entities | 
*LocationsApi* | [**createLocation**](docs/Api/LocationsApi.md#createlocation) | **POST** /Endpoint/rest/api/v1/Location | 
*LocationsApi* | [**deleteLocation**](docs/Api/LocationsApi.md#deletelocation) | **DELETE** /Endpoint/rest/api/v1/Location/{Id} | 
*LocationsApi* | [**deleteLocationUser**](docs/Api/LocationsApi.md#deletelocationuser) | **DELETE** /Endpoint/rest/api/v1/Location/{Id}/User/{SubId} | 
*LocationsApi* | [**getLocation**](docs/Api/LocationsApi.md#getlocation) | **GET** /Endpoint/rest/api/v1/Location/{Id} | 
*LocationsApi* | [**listLocationUsers**](docs/Api/LocationsApi.md#listlocationusers) | **GET** /Endpoint/rest/api/v1/Location/{Id}/Users | 
*LocationsApi* | [**listLocations**](docs/Api/LocationsApi.md#listlocations) | **GET** /Endpoint/rest/api/v1/Locations | 
*LocationsApi* | [**patchLocationUsers**](docs/Api/LocationsApi.md#patchlocationusers) | **PATCH** /Endpoint/rest/api/v1/Location/{Id}/Users | 
*LocationsApi* | [**patchLocations**](docs/Api/LocationsApi.md#patchlocations) | **PATCH** /Endpoint/rest/api/v1/Locations/Json | 
*LocationsApi* | [**updateLocation**](docs/Api/LocationsApi.md#updatelocation) | **PUT** /Endpoint/rest/api/v1/Location/{Id} | 
*LocationsApi* | [**upsertLocation**](docs/Api/LocationsApi.md#upsertlocation) | **PATCH** /Endpoint/rest/api/v1/Location | 
*LocationsApi* | [**upsertLocationUser**](docs/Api/LocationsApi.md#upsertlocationuser) | **POST** /Endpoint/rest/api/v1/Location/{Id}/User | 

## Models

- [AbstractLong](docs/Model/AbstractLong.md)
- [AbstractText](docs/Model/AbstractText.md)
- [Account](docs/Model/Account.md)
- [AccountData](docs/Model/AccountData.md)
- [Accounts](docs/Model/Accounts.md)
- [Config](docs/Model/Config.md)
- [ConfigData](docs/Model/ConfigData.md)
- [ConfigText](docs/Model/ConfigText.md)
- [Configs](docs/Model/Configs.md)
- [ConfigsData](docs/Model/ConfigsData.md)
- [Connection](docs/Model/Connection.md)
- [ConnectionData](docs/Model/ConnectionData.md)
- [Connections](docs/Model/Connections.md)
- [Department](docs/Model/Department.md)
- [DepartmentInsertData](docs/Model/DepartmentInsertData.md)
- [DepartmentText](docs/Model/DepartmentText.md)
- [DepartmentUpdateData](docs/Model/DepartmentUpdateData.md)
- [DepartmentUpsertData](docs/Model/DepartmentUpsertData.md)
- [Departments](docs/Model/Departments.md)
- [DepartmentsData](docs/Model/DepartmentsData.md)
- [Entities](docs/Model/Entities.md)
- [Entity](docs/Model/Entity.md)
- [Error](docs/Model/Error.md)
- [FieldType](docs/Model/FieldType.md)
- [ListValidation](docs/Model/ListValidation.md)
- [Location](docs/Model/Location.md)
- [LocationData](docs/Model/LocationData.md)
- [LocationText](docs/Model/LocationText.md)
- [Locations](docs/Model/Locations.md)
- [LocationsData](docs/Model/LocationsData.md)
- [Meta](docs/Model/Meta.md)
- [Meta1](docs/Model/Meta1.md)
- [Meta2](docs/Model/Meta2.md)
- [Tenant](docs/Model/Tenant.md)
- [TenantData](docs/Model/TenantData.md)
- [Tenants](docs/Model/Tenants.md)
- [User](docs/Model/User.md)
- [UserData](docs/Model/UserData.md)
- [UserText](docs/Model/UserText.md)
- [Users](docs/Model/Users.md)
- [UsersData](docs/Model/UsersData.md)

## Authorization

Authentication schemes defined for the API:
### OAuth2

- **Type**: `OAuth`
- **Flow**: `application`
- **Authorization URL**: ``
- **Scopes**: 
    - **AccessManager:Read**: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessUser:Read**: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessManager:Create, Update**: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessUser:Create, Update**: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessManager:Create**: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessUser:Create**: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessManager:Update**: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessUser:Update**: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessManager:Delete**: Allows to edit access groups and all related data. (ABAC) permissions required to perform a function.
    - **AccessUser:Delete**: Allows to review access groups and all related data. (ABAC) permissions required to perform a function.

## Tests

To run the tests, use:

```bash
composer install
vendor/bin/phpunit
```

## Author



## About this package

This PHP package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: `3.0.20`
    - Generator version: `7.6.0`
- Build package: `org.openapitools.codegen.languages.PhpClientCodegen`
