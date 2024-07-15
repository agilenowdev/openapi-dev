# DepartmentsApi

All URIs are relative to *https://dev.esystems.fi*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
| [**create Department**](DepartmentsApi.md#create Department) | **POST** /Endpoint/rest/api/v1/Department |  |
| [**delete Department**](DepartmentsApi.md#delete Department) | **DELETE** /Endpoint/rest/api/v1/Department/{Id} |  |
| [**delete Department User**](DepartmentsApi.md#delete Department User) | **DELETE** /Endpoint/rest/api/v1/Department/{Id}/User/{SubId} |  |
| [**get Department**](DepartmentsApi.md#get Department) | **GET** /Endpoint/rest/api/v1/Department/{Id} |  |
| [**list Department Users**](DepartmentsApi.md#list Department Users) | **GET** /Endpoint/rest/api/v1/Department/{Id}/Users |  |
| [**list Departments**](DepartmentsApi.md#list Departments) | **GET** /Endpoint/rest/api/v1/Departments |  |
| [**patch Department Users**](DepartmentsApi.md#patch Department Users) | **PATCH** /Endpoint/rest/api/v1/Department/{Id}/Users |  |
| [**update Department**](DepartmentsApi.md#update Department) | **PUT** /Endpoint/rest/api/v1/Department/{Id} |  |
| [**upsert Department**](DepartmentsApi.md#upsert Department) | **PATCH** /Endpoint/rest/api/v1/Department |  |
| [**upsert Department User**](DepartmentsApi.md#upsert Department User) | **POST** /Endpoint/rest/api/v1/Department/{Id}/User |  |


<a name="create Department"></a>
# **create Department**
> Department create Department(DepartmentInsertData)



    Use the &#x60;DepartmentInsertData&#x60; object resource to create new records.  You can supply the required field values in the request data, and then use the &#x60;POST&#x60; method of the resource.  The input parameter must be used in the &#x60;DepartmentInsertData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields.  Foreign key fields are: &#x60;DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy&#x60;  ### Create a new record of Department * If the value in the &#x60;Id, Name, ExternalId&#x60; fields are empty then action insert a new record according input parameter entity record structure (&#x60;DepartmentInsertData&#x60;). * If the value in the &#x60;Name, ExternalId&#x60; and &#x60;Id&#x60; fields are empty then action insert a new record according input parameter entity record structure (&#x60;DepartmentInsertData&#x60;). * If the &#x60;Id, Name, ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended &#x60;Department&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **DepartmentInsertData** | [**DepartmentInsertData**](../Models/DepartmentInsertData.md)| &#x60;Department&#x60; information to insert.  The input parameter must be used in the &#x60;DepartmentInsertData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |

### Return type

[**Department**](../Models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

<a name="delete Department"></a>
# **delete Department**
> Department delete Department(Id, Name)



    Use the query string resource to delete &#x60;Department&#x60; record. The method contains two parameters &#x60;Id&#x60; and &#x60;Name&#x60;. Specify the record &#x60;{Id}&#x60;, &#x60;Name&#x60; using &#x60;Id, Name, ExternalId&#x60; field(s) value and use the &#x60;DELETE&#x60; method of the resource to delete a record.  Method returns an extended &#x60;Department&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  Foreign key fields are: &#x60;DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy&#x60;  ### Delete a record of Department * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;Id, Name, ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Id** | **String**| The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **Name** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId &#x60;&#x60;&#x60; | [optional] [default to null] |

### Return type

[**Department**](../Models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

<a name="delete Department User"></a>
# **delete Department User**
> User delete Department User(Id, SubId, Name, SubName)



    Use the query string resource to delete &#x60;User&#x60; record. The method contains two parameters &#x60;SubId&#x60; and &#x60;SubName&#x60;. Specify the record &#x60;SubId&#x60;, &#x60;SubName&#x60; using &#x60;Id&#x60; field(s) value and use the &#x60;DELETE&#x60; method of the resource to delete a record.  Method returns an extended &#x60;User&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  Foreign key fields are: &#x60;DepartmentId, UserId, ModifiedBy, CreatedBy&#x60;  ### Delete a record of User * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Id** | **String**| The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **SubId** | **String**| The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **Name** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] [default to null] |
| **SubName** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60;  &#x60;&#x60;&#x60; | [optional] [default to null] |

### Return type

[**User**](../Models/User.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

<a name="get Department"></a>
# **get Department**
> Department get Department(Id, Name)



    The method returns one record of the &#x60;Department&#x60;.  Method returns an extended &#x60;Department&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  Foreign key fields are: &#x60;DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy&#x60;  ### Get a record of Department * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;Id, Name, ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Id** | **String**| The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **Name** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId &#x60;&#x60;&#x60; | [optional] [default to null] |

### Return type

[**Department**](../Models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

<a name="list Department Users"></a>
# **list Department Users**
> Users list Department Users(Id, Name, Fields, Filters, Orders, CurrentPage, PageSize)



    Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended &#x60;User&#x60; representation. In this format, all foreign key fields are depicted as abstract object structures, employing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: &#x60;DepartmentId, UserId, ModifiedBy, CreatedBy&#x60;  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&amp;#39;s name, and a limit is set to return a maximum of 1000 rows.  &#x60;&#x60;&#x60;http fields&#x3D;Name,ExternalId,Email&amp;amp;Filters&#x3D;(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &amp;gt; 2022-01-01)&amp;amp;Orders&#x3D;Name ASC&amp;amp;PageSize&#x3D;1000 &#x60;&#x60;&#x60;

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Id** | **String**| The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **Name** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] [default to null] |
| **Fields** | **String**| Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional] [default to null] |
| **Filters** | **String**| In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional] [default to null] |
| **Orders** | **String**| The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional] [default to null] |
| **CurrentPage** | **Integer**| This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **PageSize** | **Integer**| The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Users**](../Models/Users.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

<a name="list Departments"></a>
# **list Departments**
> Departments list Departments(Fields, Filters, Orders, CurrentPage, PageSize)



    Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended &#x60;Department&#x60; representation. In this format, all foreign key fields are depicted as abstract object structures, employing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: &#x60;DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy&#x60;  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&amp;#39;s name, and a limit is set to return a maximum of 1000 rows.  &#x60;&#x60;&#x60;http fields&#x3D;Name,ExternalId,Email&amp;amp;Filters&#x3D;(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &amp;gt; 2022-01-01)&amp;amp;Orders&#x3D;Name ASC&amp;amp;PageSize&#x3D;1000 &#x60;&#x60;&#x60;

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Fields** | **String**| Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &amp;quot;*&amp;quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Id, ExternalId, Name, DepartmentTypeId, ParentDepartmentId, HierarchicalName, Level, ContactName, ContactEmail, ContactPhone, OwnerId, CountryId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn &#x60;&#x60;&#x60; | [optional] [default to null] |
| **Filters** | **String**| In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the &#x60;Employee&#x60; table has a &#x60;DepartmentId&#x60; field, so you can search for a department name using the &#x60;DepartmentId.Name&#x60; field name. All fields in the parent table are available.  The name of the entity field. Example: &#x60;Name&#x60; or relation field &#x60;OwnerId.Name&#x60;  Please refer to the corresponding method&amp;#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator &#x3D;, &amp;lt;&amp;gt;, &amp;gt;, &amp;gt;&#x3D;, &amp;lt;, &amp;lt;&#x3D;, In, Like, NotIn  You can add multiple values separated by comma when using the &#x60;In&#x60;, &#x60;NotIn&#x60; operators. Example of text field; &#x60;USA; FIN; ARE&#x60; Example of numeric field; &#x60;1, 2, 3&#x60;  Example of filters: &#x60;&#x60;&#x60;sql Filters&#x3D;(DepartmentId.Name &#x3D; My Department) AND (DepartmentId.CreatedOn &#x3D; 2021-01-01)  Filters&#x3D;(DepartmentId.Name &#x3D; My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters&#x3D;ExternalId In S100;S101;S120;100  Filters&#x3D;Id &#x3D; 100  &#x60;&#x60;&#x60;  | [optional] [default to null] |
| **Orders** | **String**| The &#x60;Orders&#x60; parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  &#x60;&#x60;&#x60; Name DESC, CreatedOn ASC &#x60;&#x60;&#x60; | [optional] [default to null] |
| **CurrentPage** | **Integer**| This field specifies the current page of results being returned. It&amp;#39;s often used in conjunction with &#x60;PageSize&#x60; to manage pagination by indicating which subset of the total data is currently being retrieved. | [optional] [default to 0] |
| **PageSize** | **Integer**| The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from &#x60;1&#x60; to &#x60;1000&#x60; and defaults to &#x60;50&#x60;. | [optional] [default to 0] |

### Return type

[**Departments**](../Models/Departments.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

<a name="patch Department Users"></a>
# **patch Department Users**
> User patch Department Users(Id, UsersData, Name, DeleteNotExists)



    Use the &#x60;UsersData&#x60; object resource to insert or update (Upsert) a list of &#x60;UserData&#x60; using &#x60;Id&#x60; field(s) value.  You can supply the required field values in the request data, and then use the &#x60;POST&#x60; method of the resource.  The input parameter must be used in the &#x60;UserList&#x60; record structure as text fields in the foreign key fields.  Foreign key fields are: &#x60;DepartmentId, UserId, ModifiedBy, CreatedBy&#x60;  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the &#x60;Id&#x60; field is empty then action insert a new record according input parameter entity record structure (&#x60;UserData&#x60;).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended &#x60;User&#x60; representation. In this format, all foreign key fields are depicted as abstract object structures, employing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types. This offers an enriched and detailed perspective of the data and its associated entities.

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Id** | **String**| The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **UsersData** | [**UsersData**](../Models/UsersData.md)| The list of User information to insert or update.  The input parameter must be used in the &#x60;Extra&#x60; record array structure inside the &#x60;Name&#x60; and &#x60;FieldName&#x60; parameters in the foreign key fields. | |
| **Name** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] [default to null] |
| **DeleteNotExists** | **String**| The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. | [optional] [default to false] |

### Return type

[**User**](../Models/User.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

<a name="update Department"></a>
# **update Department**
> Department update Department(Id, DepartmentUpdateData, Name)



    Use the &#x60;DepartmentUpdateData&#x60; object resource to update &#x60;Department&#x60; using &#x60;Id, Name, ExternalId&#x60; field(s) value.  Provide the updated record information in your request data and use the &#x60;PUT&#x60; method of the resource with a specific record ID to update that record.   The input parameter must be used in the &#x60;DepartmentUpdateData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields.  Foreign key fields are: &#x60;DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy&#x60;  ### Update a record of Department * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned.. You cannot change &#x60;Id&#x60; field value (primary key). * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;Id, Name, ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended &#x60;Department&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Id** | **String**| The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **DepartmentUpdateData** | [**DepartmentUpdateData**](../Models/DepartmentUpdateData.md)| Department information to update.  The input parameter must be used in the &#x60;DepartmentUpdateData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |
| **Name** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Name, ExternalId &#x60;&#x60;&#x60; | [optional] [default to null] |

### Return type

[**Department**](../Models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

<a name="upsert Department"></a>
# **upsert Department**
> Department upsert Department(DepartmentData)



    Use the &#x60;DepartmentData&#x60; object resource to insert or update (Upsert) &#x60;Department&#x60; using &#x60;Id, Name, ExternalId&#x60; field(s) value.  You can supply the required field values in the request data, and then use the &#x60;POST&#x60; method of the resource.  The input parameter must be used in the &#x60;DepartmentData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields.  Foreign key fields are: &#x60;DepartmentTypeId, ParentDepartmentId, OwnerId, CountryId, ModifiedBy, CreatedBy&#x60;  ### Update a record of Department * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned.. You cannot change &#x60;Id&#x60; field value (primary key). * If the &#x60;Name, ExternalId&#x60; field value is not empty and &#x60;Id&#x60; field value is empty, action try insert record according &#x60;Name, ExternalId&#x60; field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the &#x60;Name, ExternalId&#x60; and &#x60;Id&#x60; fields are empty then action insert a new record according input parameter entity record structure (&#x60;DepartmentData&#x60;).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended &#x60;Department&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **DepartmentData** | [**DepartmentData**](../Models/DepartmentData.md)| &#x60;Department&#x60; information to insert or update.  The input parameter must be used in the &#x60;DepartmentData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |

### Return type

[**Department**](../Models/Department.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

<a name="upsert Department User"></a>
# **upsert Department User**
> User upsert Department User(Id, UserData, Name)



    Use the &#x60;UserPost&#x60; object resource to insert or update (Upsert) &#x60;User&#x60; using &#x60;Id&#x60; field(s) value.  You can supply the required field values in the request data, and then use the &#x60;POST&#x60; method of the resource.  The input parameter must be used in the &#x60;UserData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields.  Foreign key fields are: &#x60;DepartmentId, UserId, ModifiedBy, CreatedBy&#x60;  ### Update a record of User * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned.. You cannot change &#x60;Id&#x60; field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the &#x60;Id&#x60; field is empty then action insert a new record according input parameter entity record structure (&#x60;UserData&#x60;).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended &#x60;User&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.

### Parameters

|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **Id** | **String**| The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t | [default to null] |
| **UserData** | [**UserData**](../Models/UserData.md)| &#x60;User&#x60; information to insert or update.  The input parameter must be used in the &#x60;UserData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields. | |
| **Name** | **String**| The name of the database field. If empty, the entity &#x60;Id&#x60; field is used.  Example:  &#x60;&#x60;&#x60; Id &#x60;&#x60;&#x60; | [optional] [default to null] |

### Return type

[**User**](../Models/User.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

