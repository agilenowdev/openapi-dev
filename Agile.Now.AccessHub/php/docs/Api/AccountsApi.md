# OpenAPI\Client\AccountsApi

All URIs are relative to https://dev.esystems.fi, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**createAccount()**](AccountsApi.md#createAccount) | **POST** /Endpoint/rest/api/v1/Account |  |
| [**deleteAccount()**](AccountsApi.md#deleteAccount) | **DELETE** /Endpoint/rest/api/v1/Account/{Id} |  |
| [**deleteAccountTenant()**](AccountsApi.md#deleteAccountTenant) | **DELETE** /Endpoint/rest/api/v1/Account/{Id}/Tenant/{SubId} |  |
| [**getAccount()**](AccountsApi.md#getAccount) | **GET** /Endpoint/rest/api/v1/Account/{Id} |  |
| [**listAccountTenants()**](AccountsApi.md#listAccountTenants) | **GET** /Endpoint/rest/api/v1/Account/{Id}/Tenants |  |
| [**listAccounts()**](AccountsApi.md#listAccounts) | **GET** /Endpoint/rest/api/v1/Accounts |  |
| [**updateAccount()**](AccountsApi.md#updateAccount) | **PUT** /Endpoint/rest/api/v1/Account/{Id} |  |
| [**upsertAccount()**](AccountsApi.md#upsertAccount) | **PATCH** /Endpoint/rest/api/v1/Account |  |
| [**upsertAccountTenant()**](AccountsApi.md#upsertAccountTenant) | **POST** /Endpoint/rest/api/v1/Account/{Id}/Tenant |  |


## `createAccount()`

```php
createAccount($account_data): \OpenAPI\Client\Model\Account
```



Use the `AccountData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccountData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `TenantId, LanguageId, TimezoneId, DateFormatId`  ### Create a new record of Account * If the value in the `Id,Username, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`AccountData`). * If the value in the `Username, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccountData`). * If the `Id,Username, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Account` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example

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

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **account_data** | [**\OpenAPI\Client\Model\AccountData**](../Model/AccountData.md)| &#x60;Account&#x60; information to insert.  The input parameter must be used in the &#x60;AccountData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |

### Return type

[**\OpenAPI\Client\Model\Account**](../Model/Account.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `deleteAccount()`

```php
deleteAccount($id, $name): \OpenAPI\Client\Model\Account
```



Use the query string resource to delete `Account` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Username, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Account` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `TenantId, LanguageId, TimezoneId, DateFormatId`  ### Delete a record of Account * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Username, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example

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
$id = 'id_example'; // string | The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Username, ExternalId ```

try {
    $result = $apiInstance->deleteAccount($id, $name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->deleteAccount: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Username, ExternalId &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Account**](../Model/Account.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `deleteAccountTenant()`

```php
deleteAccountTenant($id, $sub_id, $name, $sub_name): \OpenAPI\Client\Model\Tenant
```



Use the query string resource to delete `Tenant` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `UserId,AccountId.Username, AccountId.ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Tenant` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `UserId, TenantId, AccountId`  ### Delete a record of Tenant * If the `UserId` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `UserId,AccountId.Username, AccountId.ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example

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
$id = 'id_example'; // string | The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$sub_id = 'sub_id_example'; // string | The identifier of the Tenant record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ```
$sub_name = 'sub_name_example'; // string | The name of the database field. If empty, the entity `UserId` field is used.  Example:  ``` AccountId.Username, AccountId.ExternalId ```

try {
    $result = $apiInstance->deleteAccountTenant($id, $sub_id, $name, $sub_name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->deleteAccountTenant: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **sub_id** | **string**| The identifier of the Tenant record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] |
| **sub_name** | **string**| The name of the database field. If empty, the entity &#x60;UserId&#x60; field is used.  Example:  &#x60;&#x60;&#x60; AccountId.Username, AccountId.ExternalId &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Tenant**](../Model/Tenant.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getAccount()`

```php
getAccount($id, $name, $select_include, $select_exclude): \OpenAPI\Client\Model\Account
```



The method returns one record of the `Account`.  Method returns an extended `Account` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `TenantId, LanguageId, TimezoneId, DateFormatId`  ### Get a record of Account * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Username, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

### Example

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
$id = 'id_example'; // string | The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Username, ExternalId ```
$select_include = 'select_include_example'; // string | Mentioned fields will be returned from database, overwise if value is empty all database record fields will be returned from database.
$select_exclude = 'select_exclude_example'; // string | Mentioned fields will be excluded from returned database record, overwise if value is empty all database record fields will be returned from database.

try {
    $result = $apiInstance->getAccount($id, $name, $select_include, $select_exclude);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->getAccount: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Username, ExternalId &#x60;&#x60;&#x60; | [optional] |
| **select_include** | **string**| Mentioned fields will be returned from database, overwise if value is empty all database record fields will be returned from database. | [optional] |
| **select_exclude** | **string**| Mentioned fields will be excluded from returned database record, overwise if value is empty all database record fields will be returned from database. | [optional] |

### Return type

[**\OpenAPI\Client\Model\Account**](../Model/Account.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `listAccountTenants()`

```php
listAccountTenants($id, $name, $fields, $filters, $orders, $current_page, $page_size): \OpenAPI\Client\Model\Tenants
```



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Tenant` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, TenantId, AccountId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example

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
$id = 'id_example'; // string | The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ```
$fields = 'fields_example'; // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` UserId, TenantId, AccountId, CreatedOn ```
$filters = 'filters_example'; // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```
$orders = 'orders_example'; // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ```
$current_page = 0; // int | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved.
$page_size = 0; // int | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`.

try {
    $result = $apiInstance->listAccountTenants($id, $name, $fields, $filters, $orders, $current_page, $page_size);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->listAccountTenants: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] |
| **fields** | **string**| Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; UserId, TenantId, AccountId, CreatedOn &#x60;&#x60;&#x60; | [optional] |
| **filters** | **string**| In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60; | [optional] |
| **orders** | **string**| The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional] |
| **current_page** | **int**| This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **page_size** | **int**| The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**\OpenAPI\Client\Model\Tenants**](../Model/Tenants.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `listAccounts()`

```php
listAccounts($fields, $filters, $orders, $current_page, $page_size, $select_include, $select_exclude): \OpenAPI\Client\Model\Accounts
```



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Account` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `TenantId, LanguageId, TimezoneId, DateFormatId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example

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
$fields = 'fields_example'; // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, TenantId, Name, FirstName, LastName, Phone, Email, LanguageId, TimezoneId, DateFormatId, Username, ExternalId, NotifyByEmail, NotifyBySMS, Is_Active, ModifiedOn, CreatedOn ```
$filters = 'filters_example'; // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```
$orders = 'orders_example'; // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ```
$current_page = 0; // int | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved.
$page_size = 0; // int | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`.
$select_include = 'select_include_example'; // string | Mentioned fields will be returned from database, overwise if value is empty all database record fields will be returned from database.
$select_exclude = 'select_exclude_example'; // string | Mentioned fields will be excluded from returned database record, overwise if value is empty all database record fields will be returned from database.

try {
    $result = $apiInstance->listAccounts($fields, $filters, $orders, $current_page, $page_size, $select_include, $select_exclude);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->listAccounts: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fields** | **string**| Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, TenantId, Name, FirstName, LastName, Phone, Email, LanguageId, TimezoneId, DateFormatId, Username, ExternalId, NotifyByEmail, NotifyBySMS, Is_Active, ModifiedOn, CreatedOn &#x60;&#x60;&#x60; | [optional] |
| **filters** | **string**| In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60; | [optional] |
| **orders** | **string**| The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional] |
| **current_page** | **int**| This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **page_size** | **int**| The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |
| **select_include** | **string**| Mentioned fields will be returned from database, overwise if value is empty all database record fields will be returned from database. | [optional] |
| **select_exclude** | **string**| Mentioned fields will be excluded from returned database record, overwise if value is empty all database record fields will be returned from database. | [optional] |

### Return type

[**\OpenAPI\Client\Model\Accounts**](../Model/Accounts.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `updateAccount()`

```php
updateAccount($id, $account_data, $name): \OpenAPI\Client\Model\Account
```



Use the `AccountData` object resource to update `Account` using `Id,Username, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `AccountData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `TenantId, LanguageId, TimezoneId, DateFormatId`  ### Update a record of Account * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Username, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Account` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example

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
$id = 'id_example'; // string | The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$account_data = new \OpenAPI\Client\Model\AccountData(); // \OpenAPI\Client\Model\AccountData | Account information to update.  The input parameter must be used in the `AccountData` record structure inside the `FieldType` parameter in the foreign key fields.
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Username, ExternalId ```

try {
    $result = $apiInstance->updateAccount($id, $account_data, $name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->updateAccount: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **account_data** | [**\OpenAPI\Client\Model\AccountData**](../Model/AccountData.md)| Account information to update.  The input parameter must be used in the &#x60;AccountData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Username, ExternalId &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Account**](../Model/Account.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `upsertAccount()`

```php
upsertAccount($account_data): \OpenAPI\Client\Model\Account
```



Use the `AccountData` object resource to insert or update (Upsert) `Account` using `Id,Username, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccountData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `TenantId, LanguageId, TimezoneId, DateFormatId`  ### Update a record of Account * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Username, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Username, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Account * If the value in the `Username, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccountData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Account` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example

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
$account_data = new \OpenAPI\Client\Model\AccountData(); // \OpenAPI\Client\Model\AccountData | `Account` information to insert or update.  The input parameter must be used in the `AccountData` record structure inside the `FieldType` parameter in the foreign key fields.

try {
    $result = $apiInstance->upsertAccount($account_data);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->upsertAccount: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **account_data** | [**\OpenAPI\Client\Model\AccountData**](../Model/AccountData.md)| &#x60;Account&#x60; information to insert or update.  The input parameter must be used in the &#x60;AccountData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |

### Return type

[**\OpenAPI\Client\Model\Account**](../Model/Account.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `upsertAccountTenant()`

```php
upsertAccountTenant($id, $tenant_data, $name): \OpenAPI\Client\Model\Tenant
```



Use the `TenantPost` object resource to insert or update (Upsert) `Tenant` using `UserId,AccountId.Username, AccountId.ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `TenantData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `UserId, TenantId, AccountId`  ### Update a record of Tenant * If the `UserId` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `UserId` field value (primary key). * If the `AccountId.Username, AccountId.ExternalId` field value is not empty and `UserId` field value is empty, action try insert record according `AccountId.Username, AccountId.ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Tenant * If the value in the `AccountId.Username, AccountId.ExternalId` and `UserId` fields are empty then action insert a new record according input parameter entity record structure (`TenantData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Tenant` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example

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
$id = 'id_example'; // string | The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$tenant_data = new \OpenAPI\Client\Model\TenantData(); // \OpenAPI\Client\Model\TenantData | `Tenant` information to insert or update.  The input parameter must be used in the `TenantData` record structure inside the `FieldType` parameter in the foreign key fields.
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ```

try {
    $result = $apiInstance->upsertAccountTenant($id, $tenant_data, $name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->upsertAccountTenant: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Account record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **tenant_data** | [**\OpenAPI\Client\Model\TenantData**](../Model/TenantData.md)| &#x60;Tenant&#x60; information to insert or update.  The input parameter must be used in the &#x60;TenantData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Tenant**](../Model/Tenant.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
