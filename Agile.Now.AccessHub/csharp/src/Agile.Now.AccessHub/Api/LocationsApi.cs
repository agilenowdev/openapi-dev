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
using System.Collections.Generic;
using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationInsertData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Create a new record of Location * If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationInsertData">`Location` information to insert.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        Location CreateLocation(LocationInsertData locationInsertData, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationInsertData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Create a new record of Location * If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationInsertData">`Location` information to insert.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> CreateLocationWithHttpInfo(LocationInsertData locationInsertData, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        Location DeleteLocation(string id, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> DeleteLocationWithHttpInfo(string id, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>User</returns>
        User DeleteLocationUser(string id, string subId, string name = default, string subName = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> DeleteLocationUserWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Location`.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Get a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        Location GetLocation(string id, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Location`.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Get a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> GetLocationWithHttpInfo(string id, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Users</returns>
        Users ListLocationUsers(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Users</returns>
        ApiResponse<Users> ListLocationUsersWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, CountryId, TimezoneId, CurrencyId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Locations</returns>
        Locations ListLocations(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, CountryId, TimezoneId, CurrencyId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Locations</returns>
        ApiResponse<Locations> ListLocationsWithHttpInfo(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="usersData1">The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Users</returns>
        Users PatchLocationUsers(string id, UsersData1 usersData1, string name = default, string deleteNotExists = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="usersData1">The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Users</returns>
        ApiResponse<Users> PatchLocationUsersWithHttpInfo(string id, UsersData1 usersData1, string name = default, string deleteNotExists = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationUpdateData` object resource to update `Location` using `Id, Name, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationUpdateData">Location information to update.  The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        Location UpdateLocation(string id, LocationUpdateData locationUpdateData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationUpdateData` object resource to update `Location` using `Id, Name, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationUpdateData">Location information to update.  The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> UpdateLocationWithHttpInfo(string id, LocationUpdateData locationUpdateData, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationData` object resource to insert or update (Upsert) `Location` using `Id, Name, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name,ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name,ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        Location UpsertLocation(LocationData locationData, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationData` object resource to insert or update (Upsert) `Location` using `Id, Name, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name,ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name,ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> UpsertLocationWithHttpInfo(LocationData locationData, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="userData">`User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>User</returns>
        User UpsertLocationUser(string id, UserData userData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="userData">`User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UpsertLocationUserWithHttpInfo(string id, UserData userData, string name = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationInsertData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Create a new record of Location * If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationInsertData">`Location` information to insert.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> CreateLocationAsync(LocationInsertData locationInsertData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationInsertData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Create a new record of Location * If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationInsertData">`Location` information to insert.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> CreateLocationWithHttpInfoAsync(LocationInsertData locationInsertData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> DeleteLocationAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> DeleteLocationWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> DeleteLocationUserAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> DeleteLocationUserWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Location`.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Get a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> GetLocationAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Location`.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Get a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> GetLocationWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Users</returns>
        System.Threading.Tasks.Task<Users> ListLocationUsersAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        System.Threading.Tasks.Task<ApiResponse<Users>> ListLocationUsersWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, CountryId, TimezoneId, CurrencyId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Locations</returns>
        System.Threading.Tasks.Task<Locations> ListLocationsAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, CountryId, TimezoneId, CurrencyId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Locations)</returns>
        System.Threading.Tasks.Task<ApiResponse<Locations>> ListLocationsWithHttpInfoAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="usersData1">The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Users</returns>
        System.Threading.Tasks.Task<Users> PatchLocationUsersAsync(string id, UsersData1 usersData1, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="usersData1">The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        System.Threading.Tasks.Task<ApiResponse<Users>> PatchLocationUsersWithHttpInfoAsync(string id, UsersData1 usersData1, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationUpdateData` object resource to update `Location` using `Id, Name, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationUpdateData">Location information to update.  The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> UpdateLocationAsync(string id, LocationUpdateData locationUpdateData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationUpdateData` object resource to update `Location` using `Id, Name, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationUpdateData">Location information to update.  The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> UpdateLocationWithHttpInfoAsync(string id, LocationUpdateData locationUpdateData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationData` object resource to insert or update (Upsert) `Location` using `Id, Name, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name,ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name,ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> UpsertLocationAsync(LocationData locationData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationData` object resource to insert or update (Upsert) `Location` using `Id, Name, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name,ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name,ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> UpsertLocationWithHttpInfoAsync(LocationData locationData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="userData">`User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UpsertLocationUserAsync(string id, UserData userData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="userData">`User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UpsertLocationUserWithHttpInfoAsync(string id, UserData userData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocationsApi : ILocationsApiSync, ILocationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LocationsApi : ILocationsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="LocationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="LocationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LocationsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Use the `LocationInsertData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Create a new record of Location * If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationInsertData">`Location` information to insert.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        public Location CreateLocation(LocationInsertData locationInsertData, int operationIndex = 0)
        {
            ApiResponse<Location> localVarResponse = CreateLocationWithHttpInfo(locationInsertData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationInsertData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Create a new record of Location * If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationInsertData">`Location` information to insert.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse<Location> CreateLocationWithHttpInfo(LocationInsertData locationInsertData, int operationIndex = 0)
        {
            // verify the required parameter 'locationInsertData' is set
            locationInsertData = locationInsertData ?? throw new ApiException(400, "Missing required parameter 'locationInsertData' when calling LocationsApi->CreateLocation");

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

            localVarRequestOptions.Data = locationInsertData;

            localVarRequestOptions.Operation = "LocationsApi.CreateLocation";
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
            var localVarResponse = Client.Post<Location>("/Endpoint/rest/api/v1/Location", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CreateLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationInsertData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Create a new record of Location * If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationInsertData">`Location` information to insert.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> CreateLocationAsync(LocationInsertData locationInsertData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Location> localVarResponse = await CreateLocationWithHttpInfoAsync(locationInsertData, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationInsertData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Create a new record of Location * If the value in the `Id, Name, ExternalId` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationInsertData`). * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationInsertData">`Location` information to insert.  The input parameter must be used in the `LocationInsertData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> CreateLocationWithHttpInfoAsync(LocationInsertData locationInsertData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'locationInsertData' is set
            locationInsertData = locationInsertData ?? throw new ApiException(400, "Missing required parameter 'locationInsertData' when calling LocationsApi->CreateLocation");


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

            localVarRequestOptions.Data = locationInsertData;

            localVarRequestOptions.Operation = "LocationsApi.CreateLocation";
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
            var localVarResponse = await AsynchronousClient.PostAsync<Location>("/Endpoint/rest/api/v1/Location", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CreateLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        public Location DeleteLocation(string id, string name = default, int operationIndex = 0)
        {
            ApiResponse<Location> localVarResponse = DeleteLocationWithHttpInfo(id, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse<Location> DeleteLocationWithHttpInfo(string id, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->DeleteLocation");

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

            localVarRequestOptions.Operation = "LocationsApi.DeleteLocation";
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
            var localVarResponse = Client.Delete<Location>("/Endpoint/rest/api/v1/Location/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> DeleteLocationAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Location> localVarResponse = await DeleteLocationWithHttpInfoAsync(id, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> DeleteLocationWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->DeleteLocation");


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

            localVarRequestOptions.Operation = "LocationsApi.DeleteLocation";
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
            var localVarResponse = await AsynchronousClient.DeleteAsync<Location>("/Endpoint/rest/api/v1/Location/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>User</returns>
        public User DeleteLocationUser(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            ApiResponse<User> localVarResponse = DeleteLocationUserWithHttpInfo(id, subId, name, subName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> DeleteLocationUserWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->DeleteLocationUser");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling LocationsApi->DeleteLocationUser");

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

            localVarRequestOptions.Operation = "LocationsApi.DeleteLocationUser";
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
            var localVarResponse = Client.Delete<User>("/Endpoint/rest/api/v1/Location/{Id}/User/{SubId}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteLocationUser", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> DeleteLocationUserAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<User> localVarResponse = await DeleteLocationUserWithHttpInfoAsync(id, subId, name, subName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `User` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> DeleteLocationUserWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->DeleteLocationUser");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling LocationsApi->DeleteLocationUser");


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

            localVarRequestOptions.Operation = "LocationsApi.DeleteLocationUser";
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
            var localVarResponse = await AsynchronousClient.DeleteAsync<User>("/Endpoint/rest/api/v1/Location/{Id}/User/{SubId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteLocationUser", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// The method returns one record of the `Location`.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Get a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        public Location GetLocation(string id, string name = default, int operationIndex = 0)
        {
            ApiResponse<Location> localVarResponse = GetLocationWithHttpInfo(id, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The method returns one record of the `Location`.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Get a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse<Location> GetLocationWithHttpInfo(string id, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->GetLocation");

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

            localVarRequestOptions.Operation = "LocationsApi.GetLocation";
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
            var localVarResponse = Client.Get<Location>("/Endpoint/rest/api/v1/Location/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// The method returns one record of the `Location`.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Get a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> GetLocationAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Location> localVarResponse = await GetLocationWithHttpInfoAsync(id, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The method returns one record of the `Location`.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Get a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> GetLocationWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->GetLocation");


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

            localVarRequestOptions.Operation = "LocationsApi.GetLocation";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Location>("/Endpoint/rest/api/v1/Location/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Users</returns>
        public Users ListLocationUsers(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Users> localVarResponse = ListLocationUsersWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Users</returns>
        public ApiResponse<Users> ListLocationUsersWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->ListLocationUsers");

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

            localVarRequestOptions.Operation = "LocationsApi.ListLocationUsers";
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
            var localVarResponse = Client.Get<Users>("/Endpoint/rest/api/v1/Location/{Id}/Users", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListLocationUsers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Users</returns>
        public async System.Threading.Tasks.Task<Users> ListLocationUsersAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Users> localVarResponse = await ListLocationUsersWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Users>> ListLocationUsersWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->ListLocationUsers");


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

            localVarRequestOptions.Operation = "LocationsApi.ListLocationUsers";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Users>("/Endpoint/rest/api/v1/Location/{Id}/Users", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListLocationUsers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, CountryId, TimezoneId, CurrencyId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Locations</returns>
        public Locations ListLocations(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Locations> localVarResponse = ListLocationsWithHttpInfo(fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, CountryId, TimezoneId, CurrencyId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Locations</returns>
        public ApiResponse<Locations> ListLocationsWithHttpInfo(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "LocationsApi.ListLocations";
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
            var localVarResponse = Client.Get<Locations>("/Endpoint/rest/api/v1/Locations", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListLocations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, CountryId, TimezoneId, CurrencyId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Locations</returns>
        public async System.Threading.Tasks.Task<Locations> ListLocationsAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Locations> localVarResponse = await ListLocationsWithHttpInfoAsync(fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, ExternalId, Name, CountryId, TimezoneId, CurrencyId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Locations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Locations>> ListLocationsWithHttpInfoAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "LocationsApi.ListLocations";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Locations>("/Endpoint/rest/api/v1/Locations", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListLocations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="usersData1">The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Users</returns>
        public Users PatchLocationUsers(string id, UsersData1 usersData1, string name = default, string deleteNotExists = default, int operationIndex = 0)
        {
            ApiResponse<Users> localVarResponse = PatchLocationUsersWithHttpInfo(id, usersData1, name, deleteNotExists);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="usersData1">The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Users</returns>
        public ApiResponse<Users> PatchLocationUsersWithHttpInfo(string id, UsersData1 usersData1, string name = default, string deleteNotExists = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->PatchLocationUsers");

            // verify the required parameter 'usersData1' is set
            usersData1 = usersData1 ?? throw new ApiException(400, "Missing required parameter 'usersData1' when calling LocationsApi->PatchLocationUsers");

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
            localVarRequestOptions.Data = usersData1;

            localVarRequestOptions.Operation = "LocationsApi.PatchLocationUsers";
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
            var localVarResponse = Client.Patch<Users>("/Endpoint/rest/api/v1/Location/{Id}/Users", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PatchLocationUsers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="usersData1">The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Users</returns>
        public async System.Threading.Tasks.Task<Users> PatchLocationUsersAsync(string id, UsersData1 usersData1, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Users> localVarResponse = await PatchLocationUsersWithHttpInfoAsync(id, usersData1, name, deleteNotExists, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `UsersData` object resource to insert or update (Upsert) a list of `UserData` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="usersData1">The list of User information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Users>> PatchLocationUsersWithHttpInfoAsync(string id, UsersData1 usersData1, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->PatchLocationUsers");

            // verify the required parameter 'usersData1' is set
            usersData1 = usersData1 ?? throw new ApiException(400, "Missing required parameter 'usersData1' when calling LocationsApi->PatchLocationUsers");


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
            localVarRequestOptions.Data = usersData1;

            localVarRequestOptions.Operation = "LocationsApi.PatchLocationUsers";
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
            var localVarResponse = await AsynchronousClient.PatchAsync<Users>("/Endpoint/rest/api/v1/Location/{Id}/Users", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PatchLocationUsers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationUpdateData` object resource to update `Location` using `Id, Name, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationUpdateData">Location information to update.  The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        public Location UpdateLocation(string id, LocationUpdateData locationUpdateData, string name = default, int operationIndex = 0)
        {
            ApiResponse<Location> localVarResponse = UpdateLocationWithHttpInfo(id, locationUpdateData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationUpdateData` object resource to update `Location` using `Id, Name, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationUpdateData">Location information to update.  The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse<Location> UpdateLocationWithHttpInfo(string id, LocationUpdateData locationUpdateData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->UpdateLocation");

            // verify the required parameter 'locationUpdateData' is set
            locationUpdateData = locationUpdateData ?? throw new ApiException(400, "Missing required parameter 'locationUpdateData' when calling LocationsApi->UpdateLocation");

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
            localVarRequestOptions.Data = locationUpdateData;

            localVarRequestOptions.Operation = "LocationsApi.UpdateLocation";
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
            var localVarResponse = Client.Put<Location>("/Endpoint/rest/api/v1/Location/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpdateLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationUpdateData` object resource to update `Location` using `Id, Name, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationUpdateData">Location information to update.  The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> UpdateLocationAsync(string id, LocationUpdateData locationUpdateData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Location> localVarResponse = await UpdateLocationWithHttpInfoAsync(id, locationUpdateData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationUpdateData` object resource to update `Location` using `Id, Name, ExternalId` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationUpdateData">Location information to update.  The input parameter must be used in the `LocationUpdateData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name,ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> UpdateLocationWithHttpInfoAsync(string id, LocationUpdateData locationUpdateData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->UpdateLocation");

            // verify the required parameter 'locationUpdateData' is set
            locationUpdateData = locationUpdateData ?? throw new ApiException(400, "Missing required parameter 'locationUpdateData' when calling LocationsApi->UpdateLocation");


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
            localVarRequestOptions.Data = locationUpdateData;

            localVarRequestOptions.Operation = "LocationsApi.UpdateLocation";
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
            var localVarResponse = await AsynchronousClient.PutAsync<Location>("/Endpoint/rest/api/v1/Location/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpdateLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationData` object resource to insert or update (Upsert) `Location` using `Id, Name, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name,ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name,ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        public Location UpsertLocation(LocationData locationData, int operationIndex = 0)
        {
            ApiResponse<Location> localVarResponse = UpsertLocationWithHttpInfo(locationData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationData` object resource to insert or update (Upsert) `Location` using `Id, Name, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name,ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name,ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse<Location> UpsertLocationWithHttpInfo(LocationData locationData, int operationIndex = 0)
        {
            // verify the required parameter 'locationData' is set
            locationData = locationData ?? throw new ApiException(400, "Missing required parameter 'locationData' when calling LocationsApi->UpsertLocation");

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

            localVarRequestOptions.Data = locationData;

            localVarRequestOptions.Operation = "LocationsApi.UpsertLocation";
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
            var localVarResponse = Client.Patch<Location>("/Endpoint/rest/api/v1/Location", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationData` object resource to insert or update (Upsert) `Location` using `Id, Name, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name,ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name,ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> UpsertLocationAsync(LocationData locationData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Location> localVarResponse = await UpsertLocationWithHttpInfoAsync(locationData, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationData` object resource to insert or update (Upsert) `Location` using `Id, Name, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `CountryId, TimezoneId, CurrencyId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name,ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name,ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `Name,ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> UpsertLocationWithHttpInfoAsync(LocationData locationData, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'locationData' is set
            locationData = locationData ?? throw new ApiException(400, "Missing required parameter 'locationData' when calling LocationsApi->UpsertLocation");


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

            localVarRequestOptions.Data = locationData;

            localVarRequestOptions.Operation = "LocationsApi.UpsertLocation";
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
            var localVarResponse = await AsynchronousClient.PatchAsync<Location>("/Endpoint/rest/api/v1/Location", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="userData">`User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>User</returns>
        public User UpsertLocationUser(string id, UserData userData, string name = default, int operationIndex = 0)
        {
            ApiResponse<User> localVarResponse = UpsertLocationUserWithHttpInfo(id, userData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="userData">`User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> UpsertLocationUserWithHttpInfo(string id, UserData userData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->UpsertLocationUser");

            // verify the required parameter 'userData' is set
            userData = userData ?? throw new ApiException(400, "Missing required parameter 'userData' when calling LocationsApi->UpsertLocationUser");

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
            localVarRequestOptions.Data = userData;

            localVarRequestOptions.Operation = "LocationsApi.UpsertLocationUser";
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
            var localVarResponse = Client.Post<User>("/Endpoint/rest/api/v1/Location/{Id}/User", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertLocationUser", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="userData">`User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UpsertLocationUserAsync(string id, UserData userData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<User> localVarResponse = await UpsertLocationUserWithHttpInfoAsync(id, userData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `UserPost` object resource to insert or update (Upsert) `User` using `Id` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * When the Id field value is not provided, the system will automatically initiate the insertion of a new record.  ### Create a new record of User * If the value in the `Id` field is empty then action insert a new record according input parameter entity record structure (`UserData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="userData">`User` information to insert or update.  The input parameter must be used in the `UserData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UpsertLocationUserWithHttpInfoAsync(string id, UserData userData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling LocationsApi->UpsertLocationUser");

            // verify the required parameter 'userData' is set
            userData = userData ?? throw new ApiException(400, "Missing required parameter 'userData' when calling LocationsApi->UpsertLocationUser");


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
            localVarRequestOptions.Data = userData;

            localVarRequestOptions.Operation = "LocationsApi.UpsertLocationUser";
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
            var localVarResponse = await AsynchronousClient.PostAsync<User>("/Endpoint/rest/api/v1/Location/{Id}/User", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertLocationUser", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
