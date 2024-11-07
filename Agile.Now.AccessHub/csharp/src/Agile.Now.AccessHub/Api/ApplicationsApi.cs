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
    public interface IApplicationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Create a new record of Application * If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        Application1 CreateApplication(ApplicationData1 applicationData1, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Create a new record of Application * If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        ApiResponse<Application1> CreateApplicationWithHttpInfo(ApplicationData1 applicationData1, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Delete a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        Application1 DeleteApplication(string id, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Delete a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        ApiResponse<Application1> DeleteApplicationWithHttpInfo(string id, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Delete a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Role</returns>
        Role DeleteApplicationRole(string id, string subId, string name = default, string subName = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Delete a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Role</returns>
        ApiResponse<Role> DeleteApplicationRoleWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Application`.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Get a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        Application1 GetApplication(string id, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Application`.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Get a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        ApiResponse<Application1> GetApplicationWithHttpInfo(string id, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Roles</returns>
        Roles ListApplicationRoles(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Roles</returns>
        ApiResponse<Roles> ListApplicationRolesWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Applications1</returns>
        Applications1 ListApplications(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Applications1</returns>
        ApiResponse<Applications1> ListApplicationsWithHttpInfo(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="applicationData1">Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        Application1 UpdateApplication(string id, ApplicationData1 applicationData1, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="applicationData1">Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        ApiResponse<Application1> UpdateApplicationWithHttpInfo(string id, ApplicationData1 applicationData1, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).  ### Create a new record of Application * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        Application1 UpsertApplication(ApplicationData1 applicationData1, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).  ### Create a new record of Application * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        ApiResponse<Application1> UpsertApplicationWithHttpInfo(ApplicationData1 applicationData1, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Update a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Role * If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="roleData">`Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Role</returns>
        Role UpsertApplicationRole(string id, RoleData roleData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Update a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Role * If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="roleData">`Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Role</returns>
        ApiResponse<Role> UpsertApplicationRoleWithHttpInfo(string id, RoleData roleData, string name = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Create a new record of Application * If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        System.Threading.Tasks.Task<Application1> CreateApplicationAsync(ApplicationData1 applicationData1, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Create a new record of Application * If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        System.Threading.Tasks.Task<ApiResponse<Application1>> CreateApplicationWithHttpInfoAsync(ApplicationData1 applicationData1, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Delete a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        System.Threading.Tasks.Task<Application1> DeleteApplicationAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Delete a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        System.Threading.Tasks.Task<ApiResponse<Application1>> DeleteApplicationWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Delete a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Role</returns>
        System.Threading.Tasks.Task<Role> DeleteApplicationRoleAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Delete a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Role)</returns>
        System.Threading.Tasks.Task<ApiResponse<Role>> DeleteApplicationRoleWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Application`.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Get a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        System.Threading.Tasks.Task<Application1> GetApplicationAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `Application`.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Get a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        System.Threading.Tasks.Task<ApiResponse<Application1>> GetApplicationWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Roles</returns>
        System.Threading.Tasks.Task<Roles> ListApplicationRolesAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Roles)</returns>
        System.Threading.Tasks.Task<ApiResponse<Roles>> ListApplicationRolesWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Applications1</returns>
        System.Threading.Tasks.Task<Applications1> ListApplicationsAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Applications1)</returns>
        System.Threading.Tasks.Task<ApiResponse<Applications1>> ListApplicationsWithHttpInfoAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="applicationData1">Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        System.Threading.Tasks.Task<Application1> UpdateApplicationAsync(string id, ApplicationData1 applicationData1, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="applicationData1">Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        System.Threading.Tasks.Task<ApiResponse<Application1>> UpdateApplicationWithHttpInfoAsync(string id, ApplicationData1 applicationData1, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).  ### Create a new record of Application * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        System.Threading.Tasks.Task<Application1> UpsertApplicationAsync(ApplicationData1 applicationData1, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).  ### Create a new record of Application * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        System.Threading.Tasks.Task<ApiResponse<Application1>> UpsertApplicationWithHttpInfoAsync(ApplicationData1 applicationData1, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Update a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Role * If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="roleData">`Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Role</returns>
        System.Threading.Tasks.Task<Role> UpsertApplicationRoleAsync(string id, RoleData roleData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Update a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Role * If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="roleData">`Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Role)</returns>
        System.Threading.Tasks.Task<ApiResponse<Role>> UpsertApplicationRoleWithHttpInfoAsync(string id, RoleData roleData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationsApi : IApplicationsApiSync, IApplicationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplicationsApi : IApplicationsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ApplicationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApplicationsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ApplicationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ApplicationsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Use the `ApplicationData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Create a new record of Application * If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        public Application1 CreateApplication(ApplicationData1 applicationData1, int operationIndex = 0)
        {
            ApiResponse<Application1> localVarResponse = CreateApplicationWithHttpInfo(applicationData1);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Create a new record of Application * If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        public ApiResponse<Application1> CreateApplicationWithHttpInfo(ApplicationData1 applicationData1, int operationIndex = 0)
        {
            // verify the required parameter 'applicationData1' is set
            applicationData1 = applicationData1 ?? throw new ApiException(400, "Missing required parameter 'applicationData1' when calling ApplicationsApi->CreateApplication");

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

            localVarRequestOptions.Data = applicationData1;

            localVarRequestOptions.Operation = "ApplicationsApi.CreateApplication";
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
            var localVarResponse = Client.Post<Application1>("/Endpoint/rest/api/v1/Application", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CreateApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Create a new record of Application * If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        public async System.Threading.Tasks.Task<Application1> CreateApplicationAsync(ApplicationData1 applicationData1, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Application1> localVarResponse = await CreateApplicationWithHttpInfoAsync(applicationData1, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to create new records.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Create a new record of Application * If the value in the `Id, Name, ExternalId, ApplicationKey` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`). * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Application1>> CreateApplicationWithHttpInfoAsync(ApplicationData1 applicationData1, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'applicationData1' is set
            applicationData1 = applicationData1 ?? throw new ApiException(400, "Missing required parameter 'applicationData1' when calling ApplicationsApi->CreateApplication");


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

            localVarRequestOptions.Data = applicationData1;

            localVarRequestOptions.Operation = "ApplicationsApi.CreateApplication";
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
            var localVarResponse = await AsynchronousClient.PostAsync<Application1>("/Endpoint/rest/api/v1/Application", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("CreateApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Delete a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        public Application1 DeleteApplication(string id, string name = default, int operationIndex = 0)
        {
            ApiResponse<Application1> localVarResponse = DeleteApplicationWithHttpInfo(id, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Delete a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        public ApiResponse<Application1> DeleteApplicationWithHttpInfo(string id, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->DeleteApplication");

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

            localVarRequestOptions.Operation = "ApplicationsApi.DeleteApplication";
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
            var localVarResponse = Client.Delete<Application1>("/Endpoint/rest/api/v1/Application/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Delete a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        public async System.Threading.Tasks.Task<Application1> DeleteApplicationAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Application1> localVarResponse = await DeleteApplicationWithHttpInfoAsync(id, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Application` record. The method contains two parameters `Id` and `Name`. Specify the record `{Id}`, `Name` using `Id, Name, ExternalId, ApplicationKey` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Delete a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Application1>> DeleteApplicationWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->DeleteApplication");


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

            localVarRequestOptions.Operation = "ApplicationsApi.DeleteApplication";
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
            var localVarResponse = await AsynchronousClient.DeleteAsync<Application1>("/Endpoint/rest/api/v1/Application/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Delete a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Role</returns>
        public Role DeleteApplicationRole(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            ApiResponse<Role> localVarResponse = DeleteApplicationRoleWithHttpInfo(id, subId, name, subName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Delete a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Role</returns>
        public ApiResponse<Role> DeleteApplicationRoleWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->DeleteApplicationRole");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling ApplicationsApi->DeleteApplicationRole");

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

            localVarRequestOptions.Operation = "ApplicationsApi.DeleteApplicationRole";
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
            var localVarResponse = Client.Delete<Role>("/Endpoint/rest/api/v1/Application/{Id}/Role/{SubId}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteApplicationRole", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Delete a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Role</returns>
        public async System.Threading.Tasks.Task<Role> DeleteApplicationRoleAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Role> localVarResponse = await DeleteApplicationRoleWithHttpInfoAsync(id, subId, name, subName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Role` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, Name, RoleKey, ExternalId` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Delete a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, RoleKey, ExternalId` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Role record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, RoleKey, ExternalId ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Role)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Role>> DeleteApplicationRoleWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->DeleteApplicationRole");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling ApplicationsApi->DeleteApplicationRole");


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

            localVarRequestOptions.Operation = "ApplicationsApi.DeleteApplicationRole";
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
            var localVarResponse = await AsynchronousClient.DeleteAsync<Role>("/Endpoint/rest/api/v1/Application/{Id}/Role/{SubId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteApplicationRole", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// The method returns one record of the `Application`.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Get a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        public Application1 GetApplication(string id, string name = default, int operationIndex = 0)
        {
            ApiResponse<Application1> localVarResponse = GetApplicationWithHttpInfo(id, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The method returns one record of the `Application`.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Get a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        public ApiResponse<Application1> GetApplicationWithHttpInfo(string id, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->GetApplication");

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

            localVarRequestOptions.Operation = "ApplicationsApi.GetApplication";
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
            var localVarResponse = Client.Get<Application1>("/Endpoint/rest/api/v1/Application/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// The method returns one record of the `Application`.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Get a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        public async System.Threading.Tasks.Task<Application1> GetApplicationAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Application1> localVarResponse = await GetApplicationWithHttpInfoAsync(id, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The method returns one record of the `Application`.  Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Get a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Application1>> GetApplicationWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->GetApplication");


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

            localVarRequestOptions.Operation = "ApplicationsApi.GetApplication";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Application1>("/Endpoint/rest/api/v1/Application/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Roles</returns>
        public Roles ListApplicationRoles(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Roles> localVarResponse = ListApplicationRolesWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Roles</returns>
        public ApiResponse<Roles> ListApplicationRolesWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->ListApplicationRoles");

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

            localVarRequestOptions.Operation = "ApplicationsApi.ListApplicationRoles";
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
            var localVarResponse = Client.Get<Roles>("/Endpoint/rest/api/v1/Application/{Id}/Roles", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListApplicationRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Roles</returns>
        public async System.Threading.Tasks.Task<Roles> ListApplicationRolesAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Roles> localVarResponse = await ListApplicationRolesWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Role` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, RoleKey, FullName, Description, ExternalId, AccessApplicationId, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Roles)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Roles>> ListApplicationRolesWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->ListApplicationRoles");


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

            localVarRequestOptions.Operation = "ApplicationsApi.ListApplicationRoles";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Roles>("/Endpoint/rest/api/v1/Application/{Id}/Roles", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListApplicationRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Applications1</returns>
        public Applications1 ListApplications(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Applications1> localVarResponse = ListApplicationsWithHttpInfo(fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Applications1</returns>
        public ApiResponse<Applications1> ListApplicationsWithHttpInfo(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "ApplicationsApi.ListApplications";
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
            var localVarResponse = Client.Get<Applications1>("/Endpoint/rest/api/v1/Applications", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Applications1</returns>
        public async System.Threading.Tasks.Task<Applications1> ListApplicationsAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Applications1> localVarResponse = await ListApplicationsWithHttpInfoAsync(fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, ApplicationKey, ExternalId, Description, WebSiteURL, Is_System, Is_EndUser, Is_Active, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Applications1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Applications1>> ListApplicationsWithHttpInfoAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "ApplicationsApi.ListApplications";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Applications1>("/Endpoint/rest/api/v1/Applications", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="applicationData1">Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        public Application1 UpdateApplication(string id, ApplicationData1 applicationData1, string name = default, int operationIndex = 0)
        {
            ApiResponse<Application1> localVarResponse = UpdateApplicationWithHttpInfo(id, applicationData1, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="applicationData1">Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        public ApiResponse<Application1> UpdateApplicationWithHttpInfo(string id, ApplicationData1 applicationData1, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->UpdateApplication");

            // verify the required parameter 'applicationData1' is set
            applicationData1 = applicationData1 ?? throw new ApiException(400, "Missing required parameter 'applicationData1' when calling ApplicationsApi->UpdateApplication");

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
            localVarRequestOptions.Data = applicationData1;

            localVarRequestOptions.Operation = "ApplicationsApi.UpdateApplication";
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
            var localVarResponse = Client.Put<Application1>("/Endpoint/rest/api/v1/Application/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpdateApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="applicationData1">Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        public async System.Threading.Tasks.Task<Application1> UpdateApplicationAsync(string id, ApplicationData1 applicationData1, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Application1> localVarResponse = await UpdateApplicationWithHttpInfoAsync(id, applicationData1, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to update `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  Provide the updated record information in your request data and use the `PUT` method of the resource with a specific record ID to update that record.   The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, Name, ExternalId, ApplicationKey` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="applicationData1">Application information to update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Name, ExternalId, ApplicationKey ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Application1>> UpdateApplicationWithHttpInfoAsync(string id, ApplicationData1 applicationData1, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->UpdateApplication");

            // verify the required parameter 'applicationData1' is set
            applicationData1 = applicationData1 ?? throw new ApiException(400, "Missing required parameter 'applicationData1' when calling ApplicationsApi->UpdateApplication");


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
            localVarRequestOptions.Data = applicationData1;

            localVarRequestOptions.Operation = "ApplicationsApi.UpdateApplication";
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
            var localVarResponse = await AsynchronousClient.PutAsync<Application1>("/Endpoint/rest/api/v1/Application/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpdateApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).  ### Create a new record of Application * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Application1</returns>
        public Application1 UpsertApplication(ApplicationData1 applicationData1, int operationIndex = 0)
        {
            ApiResponse<Application1> localVarResponse = UpsertApplicationWithHttpInfo(applicationData1);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).  ### Create a new record of Application * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Application1</returns>
        public ApiResponse<Application1> UpsertApplicationWithHttpInfo(ApplicationData1 applicationData1, int operationIndex = 0)
        {
            // verify the required parameter 'applicationData1' is set
            applicationData1 = applicationData1 ?? throw new ApiException(400, "Missing required parameter 'applicationData1' when calling ApplicationsApi->UpsertApplication");

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

            localVarRequestOptions.Data = applicationData1;

            localVarRequestOptions.Operation = "ApplicationsApi.UpsertApplication";
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
            var localVarResponse = Client.Patch<Application1>("/Endpoint/rest/api/v1/Application", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).  ### Create a new record of Application * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Application1</returns>
        public async System.Threading.Tasks.Task<Application1> UpsertApplicationAsync(ApplicationData1 applicationData1, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Application1> localVarResponse = await UpsertApplicationWithHttpInfoAsync(applicationData1, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `ApplicationData` object resource to insert or update (Upsert) `Application` using `Id, Name, ExternalId, ApplicationKey` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `ApplicationId, AuthenticationId, ModifiedBy, CreatedBy`  ### Update a record of Application * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, ExternalId, ApplicationKey` field value is not empty and `Id` field value is empty, action try insert record according `Name, ExternalId, ApplicationKey` field value (if set, the value is a unique identifier).  ### Create a new record of Application * If the value in the `Name, ExternalId, ApplicationKey` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`ApplicationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Application` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationData1">`Application` information to insert or update.  The input parameter must be used in the `ApplicationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Application1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Application1>> UpsertApplicationWithHttpInfoAsync(ApplicationData1 applicationData1, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'applicationData1' is set
            applicationData1 = applicationData1 ?? throw new ApiException(400, "Missing required parameter 'applicationData1' when calling ApplicationsApi->UpsertApplication");


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

            localVarRequestOptions.Data = applicationData1;

            localVarRequestOptions.Operation = "ApplicationsApi.UpsertApplication";
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
            var localVarResponse = await AsynchronousClient.PatchAsync<Application1>("/Endpoint/rest/api/v1/Application", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertApplication", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Update a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Role * If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="roleData">`Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Role</returns>
        public Role UpsertApplicationRole(string id, RoleData roleData, string name = default, int operationIndex = 0)
        {
            ApiResponse<Role> localVarResponse = UpsertApplicationRoleWithHttpInfo(id, roleData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Update a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Role * If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="roleData">`Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Role</returns>
        public ApiResponse<Role> UpsertApplicationRoleWithHttpInfo(string id, RoleData roleData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->UpsertApplicationRole");

            // verify the required parameter 'roleData' is set
            roleData = roleData ?? throw new ApiException(400, "Missing required parameter 'roleData' when calling ApplicationsApi->UpsertApplicationRole");

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
            localVarRequestOptions.Data = roleData;

            localVarRequestOptions.Operation = "ApplicationsApi.UpsertApplicationRole";
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
            var localVarResponse = Client.Post<Role>("/Endpoint/rest/api/v1/Application/{Id}/Role", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertApplicationRole", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Update a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Role * If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="roleData">`Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Role</returns>
        public async System.Threading.Tasks.Task<Role> UpsertApplicationRoleAsync(string id, RoleData roleData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Role> localVarResponse = await UpsertApplicationRoleWithHttpInfoAsync(id, roleData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `RolePost` object resource to insert or update (Upsert) `Role` using `Id, Name, RoleKey, ExternalId` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessApplicationId, RoleId, ApplicationId, EspaceId, ModifiedBy, CreatedBy`  ### Update a record of Role * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `Name, RoleKey, ExternalId` field value is not empty and `Id` field value is empty, action try insert record according `Name, RoleKey, ExternalId` field value (if set, the value is a unique identifier).  ### Create a new record of Role * If the value in the `Name, RoleKey, ExternalId` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`RoleData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Role` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the Application record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64\\|bmFtZUBkb21haW4uY29t</param>
        /// <param name="roleData">`Role` information to insert or update.  The input parameter must be used in the `RoleData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Role)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Role>> UpsertApplicationRoleWithHttpInfoAsync(string id, RoleData roleData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling ApplicationsApi->UpsertApplicationRole");

            // verify the required parameter 'roleData' is set
            roleData = roleData ?? throw new ApiException(400, "Missing required parameter 'roleData' when calling ApplicationsApi->UpsertApplicationRole");


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
            localVarRequestOptions.Data = roleData;

            localVarRequestOptions.Operation = "ApplicationsApi.UpsertApplicationRole";
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
            var localVarResponse = await AsynchronousClient.PostAsync<Role>("/Endpoint/rest/api/v1/Application/{Id}/Role", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertApplicationRole", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
