/*
 * Agile.Now.AccessHub API
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: dev@agilenow.io
 *
 * BSD 3-Clause License
 * 
 * Copyright (c) 2024, eSystems Nordic Ltd.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice, this list
 *    of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright notice, this
 *    list of conditions and the following disclaimer in the documentation and/or other
 *    materials provided with the distribution.
 * 3. Neither the name of the copyright holder nor the names of its contributors may be
 *    used to endorse or promote products derived from this software without specific
 *    prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT
 * SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT,
 * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
 * TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR
 * BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN
 * ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
 * DAMAGE.
 */

using System;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectionsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        Connection CreateConnection(ConnectionData connectionData, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        ApiResponse<Connection> CreateConnectionWithHttpInfo(ConnectionData connectionData, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        Connection DeleteConnection(string id, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        ApiResponse<Connection> DeleteConnectionWithHttpInfo(string id, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Config</returns>
        Config DeleteConnectionConfig(string id, string subId, string name = default, string subName = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Config</returns>
        ApiResponse<Config> DeleteConnectionConfigWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        Connection GetConnection(string id, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        ApiResponse<Connection> GetConnectionWithHttpInfo(string id, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Configs</returns>
        Configs ListConnectionConfigs(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Configs</returns>
        ApiResponse<Configs> ListConnectionConfigsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connections</returns>
        Connections ListConnections(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connections</returns>
        ApiResponse<Connections> ListConnectionsWithHttpInfo(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configsData">The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Config</returns>
        Config PatchConnectionConfigs(string id, ConfigsData configsData, string name = default, string deleteNotExists = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configsData">The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Config</returns>
        ApiResponse<Config> PatchConnectionConfigsWithHttpInfo(string id, ConfigsData configsData, string name = default, string deleteNotExists = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="connectionData">Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        Connection UpdateConnection(string id, ConnectionData connectionData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="connectionData">Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        ApiResponse<Connection> UpdateConnectionWithHttpInfo(string id, ConnectionData connectionData, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        Connection UpsertConnection(ConnectionData connectionData, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        ApiResponse<Connection> UpsertConnectionWithHttpInfo(ConnectionData connectionData, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configData">`Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Config</returns>
        Config UpsertConnectionConfig(string id, ConfigData configData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configData">`Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Config</returns>
        ApiResponse<Config> UpsertConnectionConfigWithHttpInfo(string id, ConfigData configData, string name = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectionsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        System.Threading.Tasks.Task<Connection> CreateConnectionAsync(ConnectionData connectionData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        System.Threading.Tasks.Task<ApiResponse<Connection>> CreateConnectionWithHttpInfoAsync(ConnectionData connectionData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        System.Threading.Tasks.Task<Connection> DeleteConnectionAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        System.Threading.Tasks.Task<ApiResponse<Connection>> DeleteConnectionWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Config</returns>
        System.Threading.Tasks.Task<Config> DeleteConnectionConfigAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Config)</returns>
        System.Threading.Tasks.Task<ApiResponse<Config>> DeleteConnectionConfigWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        System.Threading.Tasks.Task<Connection> GetConnectionAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        System.Threading.Tasks.Task<ApiResponse<Connection>> GetConnectionWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Configs</returns>
        System.Threading.Tasks.Task<Configs> ListConnectionConfigsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Configs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Configs>> ListConnectionConfigsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connections</returns>
        System.Threading.Tasks.Task<Connections> ListConnectionsAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connections)</returns>
        System.Threading.Tasks.Task<ApiResponse<Connections>> ListConnectionsWithHttpInfoAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configsData">The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Config</returns>
        System.Threading.Tasks.Task<Config> PatchConnectionConfigsAsync(string id, ConfigsData configsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configsData">The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Config)</returns>
        System.Threading.Tasks.Task<ApiResponse<Config>> PatchConnectionConfigsWithHttpInfoAsync(string id, ConfigsData configsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="connectionData">Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        System.Threading.Tasks.Task<Connection> UpdateConnectionAsync(string id, ConnectionData connectionData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="connectionData">Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        System.Threading.Tasks.Task<ApiResponse<Connection>> UpdateConnectionWithHttpInfoAsync(string id, ConnectionData connectionData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        System.Threading.Tasks.Task<Connection> UpsertConnectionAsync(ConnectionData connectionData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        System.Threading.Tasks.Task<ApiResponse<Connection>> UpsertConnectionWithHttpInfoAsync(ConnectionData connectionData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configData">`Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Config</returns>
        System.Threading.Tasks.Task<Config> UpsertConnectionConfigAsync(string id, ConfigData configData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configData">`Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Config)</returns>
        System.Threading.Tasks.Task<ApiResponse<Config>> UpsertConnectionConfigWithHttpInfoAsync(string id, ConfigData configData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectionsApi : IConnectionsApiSync, IConnectionsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConnectionsApi : IConnectionsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionsApi(string basePath)
        {
            Configuration = Agile.Now.AccessHub.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            Client = new ApiClient(Configuration.BasePath);
            AsynchronousClient = new ApiClient(Configuration.BasePath);
            ExceptionFactory = Agile.Now.AccessHub.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConnectionsApi(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            Configuration = Agile.Now.AccessHub.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            Client = new ApiClient(Configuration.BasePath);
            AsynchronousClient = new ApiClient(Configuration.BasePath);
            ExceptionFactory = Agile.Now.AccessHub.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ConnectionsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            Client = client ?? throw new ArgumentNullException("client");
            AsynchronousClient = asyncClient ?? throw new ArgumentNullException("asyncClient");
            Configuration = configuration ?? throw new ArgumentNullException("configuration");
            ExceptionFactory = Agile.Now.AccessHub.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        public Connection CreateConnection(ConnectionData connectionData, int operationIndex = 0)
        {
            ApiResponse<Connection> localVarResponse = CreateConnectionWithHttpInfo(connectionData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        public ApiResponse<Connection> CreateConnectionWithHttpInfo(ConnectionData connectionData, int operationIndex = 0)
        {
            // verify the required parameter 'connectionData' is set
            connectionData = connectionData ?? throw new ApiException(400, "Missing required parameter 'connectionData' when calling ConnectionsApi->CreateConnection");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = connectionData;

            localVarRequestOptions.Operation = "ConnectionsApi.CreateConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Post<Connection>("/Endpoint/rest/api/v1/Connection", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CreateConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        public async System.Threading.Tasks.Task<Connection> CreateConnectionAsync(ConnectionData connectionData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Connection> localVarResponse = await CreateConnectionWithHttpInfoAsync(connectionData, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Create a new record of Connection * If the value in the `Id,Name` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`). * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Connection>> CreateConnectionWithHttpInfoAsync(ConnectionData connectionData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'connectionData' is set
            connectionData = connectionData ?? throw new ApiException(400, "Missing required parameter 'connectionData' when calling ConnectionsApi->CreateConnection");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = connectionData;

            localVarRequestOptions.Operation = "ConnectionsApi.CreateConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<Connection>("/Endpoint/rest/api/v1/Connection", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CreateConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        public Connection DeleteConnection(string id, string name = default, int operationIndex = 0)
        {
            ApiResponse<Connection> localVarResponse = DeleteConnectionWithHttpInfo(id, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        public ApiResponse<Connection> DeleteConnectionWithHttpInfo(string id, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->DeleteConnection");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.DeleteConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Delete<Connection>("/Endpoint/rest/api/v1/Connection/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        public async System.Threading.Tasks.Task<Connection> DeleteConnectionAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Connection> localVarResponse = await DeleteConnectionWithHttpInfoAsync(id, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Connection` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id,Name` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Delete a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Connection>> DeleteConnectionWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->DeleteConnection");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.DeleteConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<Connection>("/Endpoint/rest/api/v1/Connection/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Config</returns>
        public Config DeleteConnectionConfig(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            ApiResponse<Config> localVarResponse = DeleteConnectionConfigWithHttpInfo(id, subId, name, subName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Config</returns>
        public ApiResponse<Config> DeleteConnectionConfigWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->DeleteConnectionConfig");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling ConnectionsApi->DeleteConnectionConfig");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.PathParameters.Add("SubId", ClientUtils.ParameterToString(subId)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            if (subName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "SubName", subName));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.DeleteConnectionConfig";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Delete<Config>("/Endpoint/rest/api/v1/Connection/{Id}/Config/{SubId}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteConnectionConfig", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Config</returns>
        public async System.Threading.Tasks.Task<Config> DeleteConnectionConfigAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Config> localVarResponse = await DeleteConnectionConfigWithHttpInfoAsync(id, subId, name, subName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Config` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Delete a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Config record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Config)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Config>> DeleteConnectionConfigWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->DeleteConnectionConfig");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling ConnectionsApi->DeleteConnectionConfig");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.PathParameters.Add("SubId", ClientUtils.ParameterToString(subId)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            if (subName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "SubName", subName));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.DeleteConnectionConfig";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.DeleteAsync<Config>("/Endpoint/rest/api/v1/Connection/{Id}/Config/{SubId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteConnectionConfig", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        public Connection GetConnection(string id, string name = default, int operationIndex = 0)
        {
            ApiResponse<Connection> localVarResponse = GetConnectionWithHttpInfo(id, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        public ApiResponse<Connection> GetConnectionWithHttpInfo(string id, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->GetConnection");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.GetConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Get<Connection>("/Endpoint/rest/api/v1/Connection/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        public async System.Threading.Tasks.Task<Connection> GetConnectionAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Connection> localVarResponse = await GetConnectionWithHttpInfoAsync(id, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The method returns one record of the `Connection`.  Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Get a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Connection>> GetConnectionWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->GetConnection");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.GetConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<Connection>("/Endpoint/rest/api/v1/Connection/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Configs</returns>
        public Configs ListConnectionConfigs(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Configs> localVarResponse = ListConnectionConfigsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Configs</returns>
        public ApiResponse<Configs> ListConnectionConfigsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->ListConnectionConfigs");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Fields", fields));
            }
            if (filters != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Filters", filters));
            }
            if (orders != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Orders", orders));
            }
            if (currentPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "CurrentPage", currentPage));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "PageSize", pageSize));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.ListConnectionConfigs";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Get<Configs>("/Endpoint/rest/api/v1/Connection/{Id}/Configs", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListConnectionConfigs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Configs</returns>
        public async System.Threading.Tasks.Task<Configs> ListConnectionConfigsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Configs> localVarResponse = await ListConnectionConfigsWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, WebhookConnectionId, WebhookEntityId, HasCreateAccess, HasUpdateAccess, HasDeleteAccess, Is_Active, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Configs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Configs>> ListConnectionConfigsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->ListConnectionConfigs");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Fields", fields));
            }
            if (filters != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Filters", filters));
            }
            if (orders != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Orders", orders));
            }
            if (currentPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "CurrentPage", currentPage));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "PageSize", pageSize));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.ListConnectionConfigs";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<Configs>("/Endpoint/rest/api/v1/Connection/{Id}/Configs", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListConnectionConfigs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connections</returns>
        public Connections ListConnections(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Connections> localVarResponse = ListConnectionsWithHttpInfo(fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connections</returns>
        public ApiResponse<Connections> ListConnectionsWithHttpInfo(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Fields", fields));
            }
            if (filters != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Filters", filters));
            }
            if (orders != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Orders", orders));
            }
            if (currentPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "CurrentPage", currentPage));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "PageSize", pageSize));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.ListConnections";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Get<Connections>("/Endpoint/rest/api/v1/Connections", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListConnections", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connections</returns>
        public async System.Threading.Tasks.Task<Connections> ListConnectionsAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Connections> localVarResponse = await ListConnectionsWithHttpInfoAsync(fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Connection` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Description, ApiKey, SecretKey, URL, Is_Active, Is_System, ModifiedBy, ModifiedOn, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connections)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Connections>> ListConnectionsWithHttpInfoAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Fields", fields));
            }
            if (filters != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Filters", filters));
            }
            if (orders != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Orders", orders));
            }
            if (currentPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "CurrentPage", currentPage));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "PageSize", pageSize));
            }

            localVarRequestOptions.Operation = "ConnectionsApi.ListConnections";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.GetAsync<Connections>("/Endpoint/rest/api/v1/Connections", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListConnections", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configsData">The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Config</returns>
        public Config PatchConnectionConfigs(string id, ConfigsData configsData, string name = default, string deleteNotExists = default, int operationIndex = 0)
        {
            ApiResponse<Config> localVarResponse = PatchConnectionConfigsWithHttpInfo(id, configsData, name, deleteNotExists);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configsData">The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Config</returns>
        public ApiResponse<Config> PatchConnectionConfigsWithHttpInfo(string id, ConfigsData configsData, string name = default, string deleteNotExists = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->PatchConnectionConfigs");

            // verify the required parameter 'configsData' is set
            configsData = configsData ?? throw new ApiException(400, "Missing required parameter 'configsData' when calling ConnectionsApi->PatchConnectionConfigs");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            if (deleteNotExists != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "DeleteNotExists", deleteNotExists));
            }
            localVarRequestOptions.Data = configsData;

            localVarRequestOptions.Operation = "ConnectionsApi.PatchConnectionConfigs";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Patch<Config>("/Endpoint/rest/api/v1/Connection/{Id}/Configs", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PatchConnectionConfigs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configsData">The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Config</returns>
        public async System.Threading.Tasks.Task<Config> PatchConnectionConfigsAsync(string id, ConfigsData configsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Config> localVarResponse = await PatchConnectionConfigsWithHttpInfoAsync(id, configsData, name, deleteNotExists, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConfigsData` object resource to insert or update (Upsert) a list of `ConfigData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigList` record structure as text fields in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Config` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configsData">The list of Config information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Config)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Config>> PatchConnectionConfigsWithHttpInfoAsync(string id, ConfigsData configsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->PatchConnectionConfigs");

            // verify the required parameter 'configsData' is set
            configsData = configsData ?? throw new ApiException(400, "Missing required parameter 'configsData' when calling ConnectionsApi->PatchConnectionConfigs");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            if (deleteNotExists != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "DeleteNotExists", deleteNotExists));
            }
            localVarRequestOptions.Data = configsData;

            localVarRequestOptions.Operation = "ConnectionsApi.PatchConnectionConfigs";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PatchAsync<Config>("/Endpoint/rest/api/v1/Connection/{Id}/Configs", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PatchConnectionConfigs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="connectionData">Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        public Connection UpdateConnection(string id, ConnectionData connectionData, string name = default, int operationIndex = 0)
        {
            ApiResponse<Connection> localVarResponse = UpdateConnectionWithHttpInfo(id, connectionData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="connectionData">Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        public ApiResponse<Connection> UpdateConnectionWithHttpInfo(string id, ConnectionData connectionData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->UpdateConnection");

            // verify the required parameter 'connectionData' is set
            connectionData = connectionData ?? throw new ApiException(400, "Missing required parameter 'connectionData' when calling ConnectionsApi->UpdateConnection");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            localVarRequestOptions.Data = connectionData;

            localVarRequestOptions.Operation = "ConnectionsApi.UpdateConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Put<Connection>("/Endpoint/rest/api/v1/Connection/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpdateConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="connectionData">Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        public async System.Threading.Tasks.Task<Connection> UpdateConnectionAsync(string id, ConnectionData connectionData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Connection> localVarResponse = await UpdateConnectionWithHttpInfoAsync(id, connectionData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to update `Connection` using `Id,Name` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id,Name` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="connectionData">Connection information to update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Connection>> UpdateConnectionWithHttpInfoAsync(string id, ConnectionData connectionData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->UpdateConnection");

            // verify the required parameter 'connectionData' is set
            connectionData = connectionData ?? throw new ApiException(400, "Missing required parameter 'connectionData' when calling ConnectionsApi->UpdateConnection");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            localVarRequestOptions.Data = connectionData;

            localVarRequestOptions.Operation = "ConnectionsApi.UpdateConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PutAsync<Connection>("/Endpoint/rest/api/v1/Connection/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpdateConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Connection</returns>
        public Connection UpsertConnection(ConnectionData connectionData, int operationIndex = 0)
        {
            ApiResponse<Connection> localVarResponse = UpsertConnectionWithHttpInfo(connectionData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Connection</returns>
        public ApiResponse<Connection> UpsertConnectionWithHttpInfo(ConnectionData connectionData, int operationIndex = 0)
        {
            // verify the required parameter 'connectionData' is set
            connectionData = connectionData ?? throw new ApiException(400, "Missing required parameter 'connectionData' when calling ConnectionsApi->UpsertConnection");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = connectionData;

            localVarRequestOptions.Operation = "ConnectionsApi.UpsertConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Patch<Connection>("/Endpoint/rest/api/v1/Connection", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Connection</returns>
        public async System.Threading.Tasks.Task<Connection> UpsertConnectionAsync(ConnectionData connectionData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Connection> localVarResponse = await UpsertConnectionWithHttpInfoAsync(connectionData, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConnectionData` object resource to insert or update (Upsert) `Connection` using `Id,Name` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ModifiedBy, CreatedBy`  ### Update a record of Connection * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name` field value is not empty and `Id` field value is empty, action try insert record according `Name` field value (if set, the value is a unique identifier).  ### Create a new record of Connection * If the value in the `Name` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ConnectionData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Connection` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="connectionData">`Connection` information to insert or update.  The input parameter must be used in the `ConnectionData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Connection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Connection>> UpsertConnectionWithHttpInfoAsync(ConnectionData connectionData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'connectionData' is set
            connectionData = connectionData ?? throw new ApiException(400, "Missing required parameter 'connectionData' when calling ConnectionsApi->UpsertConnection");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = connectionData;

            localVarRequestOptions.Operation = "ConnectionsApi.UpsertConnection";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PatchAsync<Connection>("/Endpoint/rest/api/v1/Connection", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertConnection", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configData">`Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Config</returns>
        public Config UpsertConnectionConfig(string id, ConfigData configData, string name = default, int operationIndex = 0)
        {
            ApiResponse<Config> localVarResponse = UpsertConnectionConfigWithHttpInfo(id, configData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configData">`Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Config</returns>
        public ApiResponse<Config> UpsertConnectionConfigWithHttpInfo(string id, ConfigData configData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->UpsertConnectionConfig");

            // verify the required parameter 'configData' is set
            configData = configData ?? throw new ApiException(400, "Missing required parameter 'configData' when calling ConnectionsApi->UpsertConnectionConfig");

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            localVarRequestOptions.Data = configData;

            localVarRequestOptions.Operation = "ConnectionsApi.UpsertConnectionConfig";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = Client.Post<Config>("/Endpoint/rest/api/v1/Connection/{Id}/Config", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertConnectionConfig", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configData">`Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Config</returns>
        public async System.Threading.Tasks.Task<Config> UpsertConnectionConfigAsync(string id, ConfigData configData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Config> localVarResponse = await UpsertConnectionConfigWithHttpInfoAsync(id, configData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ConfigPost` object resource to insert or update (Upsert) `Config` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `WebhookConnectionId, WebhookEntityId, ModifiedBy, CreatedBy`  ### Update a record of Config * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of Config * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`ConfigData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Config` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Connection record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="configData">`Config` information to insert or update.  The input parameter must be used in the `ConfigData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Config)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Config>> UpsertConnectionConfigWithHttpInfoAsync(string id, ConfigData configData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ConnectionsApi->UpsertConnectionConfig");

            // verify the required parameter 'configData' is set
            configData = configData ?? throw new ApiException(400, "Missing required parameter 'configData' when calling ConnectionsApi->UpsertConnectionConfig");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("Id", ClientUtils.ParameterToString(id)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Name", name));
            }
            localVarRequestOptions.Data = configData;

            localVarRequestOptions.Operation = "ConnectionsApi.UpsertConnectionConfig";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (OAuth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(Configuration.OAuthClientSecret) &&
                         Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await AsynchronousClient.PostAsync<Config>("/Endpoint/rest/api/v1/Connection/{Id}/Config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertConnectionConfig", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
