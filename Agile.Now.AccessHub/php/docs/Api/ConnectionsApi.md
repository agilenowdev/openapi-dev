# OpenAPI\Client\ConnectionsApi

All URIs are relative to https://dev.esystems.fi, except if the operation defines another base path.

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**createConnection()**](ConnectionsApi.md#createConnection) | **POST** /Endpoint/rest/api/v1/Connection |  |
| [**deleteConnection()**](ConnectionsApi.md#deleteConnection) | **DELETE** /Endpoint/rest/api/v1/Connection/{Id} |  |
| [**deleteConnectionConfig()**](ConnectionsApi.md#deleteConnectionConfig) | **DELETE** /Endpoint/rest/api/v1/Connection/{Id}/Config/{SubId} |  |
| [**getConnection()**](ConnectionsApi.md#getConnection) | **GET** /Endpoint/rest/api/v1/Connection/{Id} |  |
| [**listConnectionConfigs()**](ConnectionsApi.md#listConnectionConfigs) | **GET** /Endpoint/rest/api/v1/Connection/{Id}/Configs |  |
| [**listConnections()**](ConnectionsApi.md#listConnections) | **GET** /Endpoint/rest/api/v1/Connections |  |
| [**patchConnectionConfigs()**](ConnectionsApi.md#patchConnectionConfigs) | **PATCH** /Endpoint/rest/api/v1/Connection/{Id}/Configs |  |
| [**updateConnection()**](ConnectionsApi.md#updateConnection) | **PUT** /Endpoint/rest/api/v1/Connection/{Id} |  |
| [**upsertConnection()**](ConnectionsApi.md#upsertConnection) | **PATCH** /Endpoint/rest/api/v1/Connection |  |
| [**upsertConnectionConfig()**](ConnectionsApi.md#upsertConnectionConfig) | **POST** /Endpoint/rest/api/v1/Connection/{Id}/Config |  |


## `createConnection()`

```php
createConnection($connection_data): \OpenAPI\Client\Model\Connection
```



Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connection_data = new \OpenAPI\Client\Model\ConnectionData(); // \OpenAPI\Client\Model\ConnectionData | `Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.

try {
    $result = $apiInstance->createConnection($connection_data);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->createConnection: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connection_data** | [**\OpenAPI\Client\Model\ConnectionData**](../Model/ConnectionData.md)| &#x60;Connection&#x60; information to insert.  The input parameter must be used in the &#x60;ConnectionData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |

### Return type

[**\OpenAPI\Client\Model\Connection**](../Model/Connection.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `deleteConnection()`

```php
deleteConnection($id, $name): \OpenAPI\Client\Model\Connection
```



Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ```

try {
    $result = $apiInstance->deleteConnection($id, $name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->deleteConnection: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Connection**](../Model/Connection.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `deleteConnectionConfig()`

```php
deleteConnectionConfig($id, $sub_id, $name, $sub_name): \OpenAPI\Client\Model\Config
```



Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$sub_id = 'sub_id_example'; // string | The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ```
$sub_name = 'sub_name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ```

try {
    $result = $apiInstance->deleteConnectionConfig($id, $sub_id, $name, $sub_name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->deleteConnectionConfig: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **sub_id** | **string**| The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] |
| **sub_name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Config**](../Model/Config.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `getConnection()`

```php
getConnection($id, $name): \OpenAPI\Client\Model\Connection
```



The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ```

try {
    $result = $apiInstance->getConnection($id, $name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->getConnection: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Connection**](../Model/Connection.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `listConnectionConfigs()`

```php
listConnectionConfigs($id, $name, $fields, $filters, $orders, $current_page, $page_size): \OpenAPI\Client\Model\Configs
```



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ```
$fields = 'fields_example'; // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ```
$filters = 'filters_example'; // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```
$orders = 'orders_example'; // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ```
$current_page = 0; // int | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved.
$page_size = 0; // int | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`.

try {
    $result = $apiInstance->listConnectionConfigs($id, $name, $fields, $filters, $orders, $current_page, $page_size);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->listConnectionConfigs: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] |
| **fields** | **string**| Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional] |
| **filters** | **string**| In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60; | [optional] |
| **orders** | **string**| The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional] |
| **current_page** | **int**| This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **page_size** | **int**| The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**\OpenAPI\Client\Model\Configs**](../Model/Configs.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `listConnections()`

```php
listConnections($fields, $filters, $orders, $current_page, $page_size): \OpenAPI\Client\Model\Connections
```



Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$fields = 'fields_example'; // string | Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ```
$filters = 'filters_example'; // string | In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```
$orders = 'orders_example'; // string | The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ```
$current_page = 0; // int | This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved.
$page_size = 0; // int | The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`.

try {
    $result = $apiInstance->listConnections($fields, $filters, $orders, $current_page, $page_size);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->listConnections: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **fields** | **string**| Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional] |
| **filters** | **string**| In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60; | [optional] |
| **orders** | **string**| The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional] |
| **current_page** | **int**| This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **page_size** | **int**| The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**\OpenAPI\Client\Model\Connections**](../Model/Connections.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `patchConnectionConfigs()`

```php
patchConnectionConfigs($id, $configs_data, $name, $delete_not_exists): \OpenAPI\Client\Model\Config
```



Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$configs_data = new \OpenAPI\Client\Model\ConfigsData(); // \OpenAPI\Client\Model\ConfigsData | The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ```
$delete_not_exists = 'false'; // string | The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table.

try {
    $result = $apiInstance->patchConnectionConfigs($id, $configs_data, $name, $delete_not_exists);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->patchConnectionConfigs: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **configs_data** | [**\OpenAPI\Client\Model\ConfigsData**](../Model/ConfigsData.md)| The list of Config information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] |
| **delete_not_exists** | **string**| The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to &#39;false&#39;] |

### Return type

[**\OpenAPI\Client\Model\Config**](../Model/Config.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `updateConnection()`

```php
updateConnection($id, $connection_data, $name): \OpenAPI\Client\Model\Connection
```



Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$connection_data = new \OpenAPI\Client\Model\ConnectionData(); // \OpenAPI\Client\Model\ConnectionData | Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ```

try {
    $result = $apiInstance->updateConnection($id, $connection_data, $name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->updateConnection: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **connection_data** | [**\OpenAPI\Client\Model\ConnectionData**](../Model/ConnectionData.md)| Connection information to update.  The input parameter must be used in the &#x60;ConnectionData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Connection**](../Model/Connection.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `upsertConnection()`

```php
upsertConnection($connection_data): \OpenAPI\Client\Model\Connection
```



Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$connection_data = new \OpenAPI\Client\Model\ConnectionData(); // \OpenAPI\Client\Model\ConnectionData | `Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.

try {
    $result = $apiInstance->upsertConnection($connection_data);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->upsertConnection: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **connection_data** | [**\OpenAPI\Client\Model\ConnectionData**](../Model/ConnectionData.md)| &#x60;Connection&#x60; information to insert or update.  The input parameter must be used in the &#x60;ConnectionData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |

### Return type

[**\OpenAPI\Client\Model\Connection**](../Model/Connection.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)

## `upsertConnectionConfig()`

```php
upsertConnectionConfig($id, $config_data, $name): \OpenAPI\Client\Model\Config
```



Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure OAuth2 access token for authorization: OAuth2
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ConnectionsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t
$config_data = new \OpenAPI\Client\Model\ConfigData(); // \OpenAPI\Client\Model\ConfigData | `Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.
$name = 'name_example'; // string | The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ```

try {
    $result = $apiInstance->upsertConnectionConfig($id, $config_data, $name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ConnectionsApi->upsertConnectionConfig: ', $e->getMessage(), PHP_EOL;
}
```

### Parameters

| Name | Type | Description  | Notes |
| ------------- | ------------- | ------------- | ------------- |
| **id** | **string**| The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | |
| **config_data** | [**\OpenAPI\Client\Model\ConfigData**](../Model/ConfigData.md)| &#x60;Config&#x60; information to insert or update.  The input parameter must be used in the &#x60;ConfigData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |
| **name** | **string**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] |

### Return type

[**\OpenAPI\Client\Model\Config**](../Model/Config.md)

### Authorization

[OAuth2](../../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: `application/json`
- **Accept**: `application/json`

[[Back to top]](#) [[Back to API list]](../../README.md#endpoints)
[[Back to Model list]](../../README.md#models)
[[Back to README]](../../README.md)
