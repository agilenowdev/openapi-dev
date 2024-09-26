/*
 * Agile.Now.Runtime API
 *
 * Agile.Now.Runtime is a dynamic and secure REST API designed to streamline the management of users, their access groups, user groups, organizations, locations, applications, and roles within a single-tenant environment. This API provides a robust, scalable, and secure platform for businesses to manage user access and organizational structures effectively. It supports both Role-Based Access Control (RBAC) and Attribute-Based Access Control (ABAC) to ensure fine-grained security and flexibility.
 *
 * The version of the OpenAPI document: 1.0
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
using Agile.Now.Runtime.Client;
using Agile.Now.Runtime.Model;

namespace Agile.Now.Runtime.Api {

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, UserId`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccessGroup</returns>
        AccessGroup DeleteUserAccessGroup(string id, string subId, string name = default, string subName = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, UserId`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccessGroup</returns>
        ApiResponse<AccessGroup> DeleteUserAccessGroupWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Department</returns>
        Department DeleteUserDepartment(string id, string subId, string name = default, string subName = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Department</returns>
        ApiResponse<Department> DeleteUserDepartmentWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `User_Id, Group_Id`  ### Delete a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Group</returns>
        Group DeleteUserGroup(string id, string subId, string name = default, string subName = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `User_Id, Group_Id`  ### Delete a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Group</returns>
        ApiResponse<Group> DeleteUserGroupWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        Location DeleteUserLocation(string id, string subId, string name = default, string subName = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> DeleteUserLocationWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `User`.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: ``  ### Get a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>User</returns>
        User GetUser(string id, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `User`.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: ``  ### Get a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserWithHttpInfo(string id, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, UserId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccessGroups</returns>
        AccessGroups ListUserAccessGroups(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, UserId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccessGroups</returns>
        ApiResponse<AccessGroups> ListUserAccessGroupsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccessRoles</returns>
        AccessRoles ListUserAccessRoles(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccessRoles</returns>
        ApiResponse<AccessRoles> ListUserAccessRolesWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Applications</returns>
        Applications ListUserApplications(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Applications</returns>
        ApiResponse<Applications> ListUserApplicationsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Departments</returns>
        Departments ListUserDepartments(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Departments</returns>
        ApiResponse<Departments> ListUserDepartmentsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>EffectivePermissions</returns>
        EffectivePermissions ListUserEffectivePermissions(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of EffectivePermissions</returns>
        ApiResponse<EffectivePermissions> ListUserEffectivePermissionsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `User_Id, Group_Id`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Groups</returns>
        Groups ListUserGroups(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `User_Id, Group_Id`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Groups</returns>
        ApiResponse<Groups> ListUserGroupsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Locations</returns>
        Locations ListUserLocations(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Locations</returns>
        ApiResponse<Locations> ListUserLocationsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: ``  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Users</returns>
        Users ListUsers(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: ``  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Users</returns>
        ApiResponse<Users> ListUsersWithHttpInfo(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentsData">The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Departments</returns>
        Departments PatchUserDepartments(string id, DepartmentsData departmentsData, string name = default, string deleteNotExists = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentsData">The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Departments</returns>
        ApiResponse<Departments> PatchUserDepartmentsWithHttpInfo(string id, DepartmentsData departmentsData, string name = default, string deleteNotExists = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationsData">The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Locations</returns>
        Locations PatchUserLocations(string id, LocationsData locationsData, string name = default, string deleteNotExists = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationsData">The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Locations</returns>
        ApiResponse<Locations> PatchUserLocationsWithHttpInfo(string id, LocationsData locationsData, string name = default, string deleteNotExists = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, UserId`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of AccessGroup * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="accessGroupData">`AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccessGroup</returns>
        AccessGroup UpsertUserAccessGroup(string id, AccessGroupData accessGroupData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, UserId`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of AccessGroup * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="accessGroupData">`AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccessGroup</returns>
        ApiResponse<AccessGroup> UpsertUserAccessGroupWithHttpInfo(string id, AccessGroupData accessGroupData, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentData">`Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Department</returns>
        Department UpsertUserDepartment(string id, DepartmentData departmentData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentData">`Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Department</returns>
        ApiResponse<Department> UpsertUserDepartmentWithHttpInfo(string id, DepartmentData departmentData, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `User_Id, Group_Id`  ### Update a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Group * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="groupData">`Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Group</returns>
        Group UpsertUserGroup(string id, GroupData groupData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `User_Id, Group_Id`  ### Update a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Group * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="groupData">`Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Group</returns>
        ApiResponse<Group> UpsertUserGroupWithHttpInfo(string id, GroupData groupData, string name = default, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        Location UpsertUserLocation(string id, LocationData locationData, string name = default, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        ApiResponse<Location> UpsertUserLocationWithHttpInfo(string id, LocationData locationData, string name = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, UserId`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessGroup</returns>
        System.Threading.Tasks.Task<AccessGroup> DeleteUserAccessGroupAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, UserId`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessGroup>> DeleteUserAccessGroupWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Department</returns>
        System.Threading.Tasks.Task<Department> DeleteUserDepartmentAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Department)</returns>
        System.Threading.Tasks.Task<ApiResponse<Department>> DeleteUserDepartmentWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `User_Id, Group_Id`  ### Delete a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Group</returns>
        System.Threading.Tasks.Task<Group> DeleteUserGroupAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `User_Id, Group_Id`  ### Delete a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<Group>> DeleteUserGroupWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> DeleteUserLocationAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> DeleteUserLocationWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `User`.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: ``  ### Get a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The method returns one record of the `User`.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: ``  ### Get a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, UserId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessGroups</returns>
        System.Threading.Tasks.Task<AccessGroups> ListUserAccessGroupsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, UserId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessGroups)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessGroups>> ListUserAccessGroupsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessRoles</returns>
        System.Threading.Tasks.Task<AccessRoles> ListUserAccessRolesAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessRoles)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessRoles>> ListUserAccessRolesWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Applications</returns>
        System.Threading.Tasks.Task<Applications> ListUserApplicationsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Applications)</returns>
        System.Threading.Tasks.Task<ApiResponse<Applications>> ListUserApplicationsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Departments</returns>
        System.Threading.Tasks.Task<Departments> ListUserDepartmentsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Departments)</returns>
        System.Threading.Tasks.Task<ApiResponse<Departments>> ListUserDepartmentsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EffectivePermissions</returns>
        System.Threading.Tasks.Task<EffectivePermissions> ListUserEffectivePermissionsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EffectivePermissions)</returns>
        System.Threading.Tasks.Task<ApiResponse<EffectivePermissions>> ListUserEffectivePermissionsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `User_Id, Group_Id`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Groups</returns>
        System.Threading.Tasks.Task<Groups> ListUserGroupsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `User_Id, Group_Id`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Groups)</returns>
        System.Threading.Tasks.Task<ApiResponse<Groups>> ListUserGroupsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Locations</returns>
        System.Threading.Tasks.Task<Locations> ListUserLocationsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Locations)</returns>
        System.Threading.Tasks.Task<ApiResponse<Locations>> ListUserLocationsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: ``  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Users</returns>
        System.Threading.Tasks.Task<Users> ListUsersAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: ``  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        System.Threading.Tasks.Task<ApiResponse<Users>> ListUsersWithHttpInfoAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentsData">The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Departments</returns>
        System.Threading.Tasks.Task<Departments> PatchUserDepartmentsAsync(string id, DepartmentsData departmentsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentsData">The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Departments)</returns>
        System.Threading.Tasks.Task<ApiResponse<Departments>> PatchUserDepartmentsWithHttpInfoAsync(string id, DepartmentsData departmentsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationsData">The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Locations</returns>
        System.Threading.Tasks.Task<Locations> PatchUserLocationsAsync(string id, LocationsData locationsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationsData">The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Locations)</returns>
        System.Threading.Tasks.Task<ApiResponse<Locations>> PatchUserLocationsWithHttpInfoAsync(string id, LocationsData locationsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, UserId`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of AccessGroup * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="accessGroupData">`AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessGroup</returns>
        System.Threading.Tasks.Task<AccessGroup> UpsertUserAccessGroupAsync(string id, AccessGroupData accessGroupData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, UserId`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of AccessGroup * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="accessGroupData">`AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessGroup>> UpsertUserAccessGroupWithHttpInfoAsync(string id, AccessGroupData accessGroupData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentData">`Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Department</returns>
        System.Threading.Tasks.Task<Department> UpsertUserDepartmentAsync(string id, DepartmentData departmentData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentData">`Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Department)</returns>
        System.Threading.Tasks.Task<ApiResponse<Department>> UpsertUserDepartmentWithHttpInfoAsync(string id, DepartmentData departmentData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `User_Id, Group_Id`  ### Update a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Group * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="groupData">`Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Group</returns>
        System.Threading.Tasks.Task<Group> UpsertUserGroupAsync(string id, GroupData groupData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `User_Id, Group_Id`  ### Update a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Group * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="groupData">`Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        System.Threading.Tasks.Task<ApiResponse<Group>> UpsertUserGroupWithHttpInfoAsync(string id, GroupData groupData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        System.Threading.Tasks.Task<Location> UpsertUserLocationAsync(string id, LocationData locationData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        System.Threading.Tasks.Task<ApiResponse<Location>> UpsertUserLocationWithHttpInfoAsync(string id, LocationData locationData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IUsersApiSync, IUsersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(string basePath)
        {
            Configuration = Agile.Now.Runtime.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            Client = new ApiClient(Configuration.BasePath);
            AsynchronousClient = new ApiClient(Configuration.BasePath);
            ExceptionFactory = Agile.Now.Runtime.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            Configuration = Agile.Now.Runtime.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            Client = new ApiClient(Configuration.BasePath);
            AsynchronousClient = new ApiClient(Configuration.BasePath);
            ExceptionFactory = Agile.Now.Runtime.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UsersApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            Client = client ?? throw new ArgumentNullException("client");
            AsynchronousClient = asyncClient ?? throw new ArgumentNullException("asyncClient");
            Configuration = configuration ?? throw new ArgumentNullException("configuration");
            ExceptionFactory = Agile.Now.Runtime.Client.Configuration.DefaultExceptionFactory;
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
        /// Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, UserId`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccessGroup</returns>
        public AccessGroup DeleteUserAccessGroup(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            ApiResponse<AccessGroup> localVarResponse = DeleteUserAccessGroupWithHttpInfo(id, subId, name, subName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, UserId`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccessGroup</returns>
        public ApiResponse<AccessGroup> DeleteUserAccessGroupWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->DeleteUserAccessGroup");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling UsersApi->DeleteUserAccessGroup");

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

            localVarRequestOptions.Operation = "UsersApi.DeleteUserAccessGroup";
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
            var localVarResponse = Client.Delete<AccessGroup>("/Endpoint/rest/api/v1/User/{Id}/AccessGroup/{SubId}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteUserAccessGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, UserId`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessGroup</returns>
        public async System.Threading.Tasks.Task<AccessGroup> DeleteUserAccessGroupAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AccessGroup> localVarResponse = await DeleteUserAccessGroupWithHttpInfoAsync(id, subId, name, subName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `AccessGroup` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `AccessGroupId, UserId`  ### Delete a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the AccessGroup record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccessGroup>> DeleteUserAccessGroupWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->DeleteUserAccessGroup");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling UsersApi->DeleteUserAccessGroup");


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

            localVarRequestOptions.Operation = "UsersApi.DeleteUserAccessGroup";
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
            var localVarResponse = await AsynchronousClient.DeleteAsync<AccessGroup>("/Endpoint/rest/api/v1/User/{Id}/AccessGroup/{SubId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteUserAccessGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Department</returns>
        public Department DeleteUserDepartment(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            ApiResponse<Department> localVarResponse = DeleteUserDepartmentWithHttpInfo(id, subId, name, subName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Department</returns>
        public ApiResponse<Department> DeleteUserDepartmentWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->DeleteUserDepartment");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling UsersApi->DeleteUserDepartment");

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

            localVarRequestOptions.Operation = "UsersApi.DeleteUserDepartment";
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
            var localVarResponse = Client.Delete<Department>("/Endpoint/rest/api/v1/User/{Id}/Department/{SubId}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteUserDepartment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Department</returns>
        public async System.Threading.Tasks.Task<Department> DeleteUserDepartmentAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Department> localVarResponse = await DeleteUserDepartmentWithHttpInfoAsync(id, subId, name, subName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Department` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Department record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Department)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Department>> DeleteUserDepartmentWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->DeleteUserDepartment");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling UsersApi->DeleteUserDepartment");


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

            localVarRequestOptions.Operation = "UsersApi.DeleteUserDepartment";
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
            var localVarResponse = await AsynchronousClient.DeleteAsync<Department>("/Endpoint/rest/api/v1/User/{Id}/Department/{SubId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteUserDepartment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `User_Id, Group_Id`  ### Delete a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Group</returns>
        public Group DeleteUserGroup(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            ApiResponse<Group> localVarResponse = DeleteUserGroupWithHttpInfo(id, subId, name, subName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `User_Id, Group_Id`  ### Delete a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Group</returns>
        public ApiResponse<Group> DeleteUserGroupWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->DeleteUserGroup");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling UsersApi->DeleteUserGroup");

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

            localVarRequestOptions.Operation = "UsersApi.DeleteUserGroup";
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
            var localVarResponse = Client.Delete<Group>("/Endpoint/rest/api/v1/User/{Id}/Group/{SubId}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteUserGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `User_Id, Group_Id`  ### Delete a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Group</returns>
        public async System.Threading.Tasks.Task<Group> DeleteUserGroupAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Group> localVarResponse = await DeleteUserGroupWithHttpInfoAsync(id, subId, name, subName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Group` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `User_Id, Group_Id`  ### Delete a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Group record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Group>> DeleteUserGroupWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->DeleteUserGroup");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling UsersApi->DeleteUserGroup");


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

            localVarRequestOptions.Operation = "UsersApi.DeleteUserGroup";
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
            var localVarResponse = await AsynchronousClient.DeleteAsync<Group>("/Endpoint/rest/api/v1/User/{Id}/Group/{SubId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteUserGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        public Location DeleteUserLocation(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            ApiResponse<Location> localVarResponse = DeleteUserLocationWithHttpInfo(id, subId, name, subName);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse<Location> DeleteUserLocationWithHttpInfo(string id, string subId, string name = default, string subName = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->DeleteUserLocation");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling UsersApi->DeleteUserLocation");

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

            localVarRequestOptions.Operation = "UsersApi.DeleteUserLocation";
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
            var localVarResponse = Client.Delete<Location>("/Endpoint/rest/api/v1/User/{Id}/Location/{SubId}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteUserLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> DeleteUserLocationAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Location> localVarResponse = await DeleteUserLocationWithHttpInfoAsync(id, subId, name, subName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the query string resource to delete `Location` record. The method contains two parameters `SubId` and `SubName`. Specify the record `SubId`, `SubName` using `Id, UserId.Email, UserId.Username` field(s) value and use the `DELETE` method of the resource to delete a record.  Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Delete a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id, UserId.Email, UserId.Username` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="subId">The identifier of the Location record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="subName">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` UserId.Email, UserId.Username ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> DeleteUserLocationWithHttpInfoAsync(string id, string subId, string name = default, string subName = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->DeleteUserLocation");

            // verify the required parameter 'subId' is set
            subId = subId ?? throw new ApiException(400, "Missing required parameter 'subId' when calling UsersApi->DeleteUserLocation");


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

            localVarRequestOptions.Operation = "UsersApi.DeleteUserLocation";
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
            var localVarResponse = await AsynchronousClient.DeleteAsync<Location>("/Endpoint/rest/api/v1/User/{Id}/Location/{SubId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("DeleteUserLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// The method returns one record of the `User`.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: ``  ### Get a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>User</returns>
        public User GetUser(string id, string name = default, int operationIndex = 0)
        {
            ApiResponse<User> localVarResponse = GetUserWithHttpInfo(id, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The method returns one record of the `User`.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: ``  ### Get a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of User</returns>
        public ApiResponse<User> GetUserWithHttpInfo(string id, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->GetUser");

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

            localVarRequestOptions.Operation = "UsersApi.GetUser";
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
            var localVarResponse = Client.Get<User>("/Endpoint/rest/api/v1/User/{Id}", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetUser", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// The method returns one record of the `User`.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: ``  ### Get a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<User> localVarResponse = await GetUserWithHttpInfoAsync(id, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The method returns one record of the `User`.  Method returns an extended `User` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.  Foreign key fields are: ``  ### Get a record of User * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned. * If the `Id` field value is matched multiple times, then a `400` error is reported (`Errors/Multible Rows`), and the error record is returned.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ```  ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetUserWithHttpInfoAsync(string id, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->GetUser");


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

            localVarRequestOptions.Operation = "UsersApi.GetUser";
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
            var localVarResponse = await AsynchronousClient.GetAsync<User>("/Endpoint/rest/api/v1/User/{Id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("GetUser", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, UserId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccessGroups</returns>
        public AccessGroups ListUserAccessGroups(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<AccessGroups> localVarResponse = ListUserAccessGroupsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, UserId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccessGroups</returns>
        public ApiResponse<AccessGroups> ListUserAccessGroupsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserAccessGroups");

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

            localVarRequestOptions.Operation = "UsersApi.ListUserAccessGroups";
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
            var localVarResponse = Client.Get<AccessGroups>("/Endpoint/rest/api/v1/User/{Id}/AccessGroups", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserAccessGroups", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, UserId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessGroups</returns>
        public async System.Threading.Tasks.Task<AccessGroups> ListUserAccessGroupsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AccessGroups> localVarResponse = await ListUserAccessGroupsWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessGroup` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `AccessGroupId, UserId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, AccessGroupId, UserId, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessGroups)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccessGroups>> ListUserAccessGroupsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserAccessGroups");


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

            localVarRequestOptions.Operation = "UsersApi.ListUserAccessGroups";
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
            var localVarResponse = await AsynchronousClient.GetAsync<AccessGroups>("/Endpoint/rest/api/v1/User/{Id}/AccessGroups", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserAccessGroups", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccessRoles</returns>
        public AccessRoles ListUserAccessRoles(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<AccessRoles> localVarResponse = ListUserAccessRolesWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccessRoles</returns>
        public ApiResponse<AccessRoles> ListUserAccessRolesWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserAccessRoles");

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

            localVarRequestOptions.Operation = "UsersApi.ListUserAccessRoles";
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
            var localVarResponse = Client.Get<AccessRoles>("/Endpoint/rest/api/v1/User/{Id}/AccessRoles", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserAccessRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessRoles</returns>
        public async System.Threading.Tasks.Task<AccessRoles> ListUserAccessRolesAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AccessRoles> localVarResponse = await ListUserAccessRolesWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `AccessRole` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessRoles)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccessRoles>> ListUserAccessRolesWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserAccessRoles");


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

            localVarRequestOptions.Operation = "UsersApi.ListUserAccessRoles";
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
            var localVarResponse = await AsynchronousClient.GetAsync<AccessRoles>("/Endpoint/rest/api/v1/User/{Id}/AccessRoles", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserAccessRoles", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Applications</returns>
        public Applications ListUserApplications(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Applications> localVarResponse = ListUserApplicationsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Applications</returns>
        public ApiResponse<Applications> ListUserApplicationsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserApplications");

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

            localVarRequestOptions.Operation = "UsersApi.ListUserApplications";
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
            var localVarResponse = Client.Get<Applications>("/Endpoint/rest/api/v1/User/{Id}/Applications", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Applications</returns>
        public async System.Threading.Tasks.Task<Applications> ListUserApplicationsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Applications> localVarResponse = await ListUserApplicationsWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Application` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Applications)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Applications>> ListUserApplicationsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserApplications");


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

            localVarRequestOptions.Operation = "UsersApi.ListUserApplications";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Applications>("/Endpoint/rest/api/v1/User/{Id}/Applications", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserApplications", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Departments</returns>
        public Departments ListUserDepartments(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Departments> localVarResponse = ListUserDepartmentsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Departments</returns>
        public ApiResponse<Departments> ListUserDepartmentsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserDepartments");

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

            localVarRequestOptions.Operation = "UsersApi.ListUserDepartments";
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
            var localVarResponse = Client.Get<Departments>("/Endpoint/rest/api/v1/User/{Id}/Departments", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserDepartments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Departments</returns>
        public async System.Threading.Tasks.Task<Departments> ListUserDepartmentsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Departments> localVarResponse = await ListUserDepartmentsWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, DepartmentId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Departments)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Departments>> ListUserDepartmentsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserDepartments");


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

            localVarRequestOptions.Operation = "UsersApi.ListUserDepartments";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Departments>("/Endpoint/rest/api/v1/User/{Id}/Departments", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserDepartments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>EffectivePermissions</returns>
        public EffectivePermissions ListUserEffectivePermissions(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<EffectivePermissions> localVarResponse = ListUserEffectivePermissionsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of EffectivePermissions</returns>
        public ApiResponse<EffectivePermissions> ListUserEffectivePermissionsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserEffectivePermissions");

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

            localVarRequestOptions.Operation = "UsersApi.ListUserEffectivePermissions";
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
            var localVarResponse = Client.Get<EffectivePermissions>("/Endpoint/rest/api/v1/User/{Id}/EffectivePermissions", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserEffectivePermissions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EffectivePermissions</returns>
        public async System.Threading.Tasks.Task<EffectivePermissions> ListUserEffectivePermissionsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EffectivePermissions> localVarResponse = await ListUserEffectivePermissionsWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `EffectivePermission` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `UserId, AccessRoleId, RoleId, AccessGroupTypeId`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, UserId, AccessRoleId, RoleId, AccessGroupTypeId, Create, Read, Update, Delete, Details, Export, Import, Generic, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EffectivePermissions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EffectivePermissions>> ListUserEffectivePermissionsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserEffectivePermissions");


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

            localVarRequestOptions.Operation = "UsersApi.ListUserEffectivePermissions";
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
            var localVarResponse = await AsynchronousClient.GetAsync<EffectivePermissions>("/Endpoint/rest/api/v1/User/{Id}/EffectivePermissions", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserEffectivePermissions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `User_Id, Group_Id`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Groups</returns>
        public Groups ListUserGroups(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Groups> localVarResponse = ListUserGroupsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `User_Id, Group_Id`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Groups</returns>
        public ApiResponse<Groups> ListUserGroupsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserGroups");

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

            localVarRequestOptions.Operation = "UsersApi.ListUserGroups";
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
            var localVarResponse = Client.Get<Groups>("/Endpoint/rest/api/v1/User/{Id}/Groups", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserGroups", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `User_Id, Group_Id`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Groups</returns>
        public async System.Threading.Tasks.Task<Groups> ListUserGroupsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Groups> localVarResponse = await ListUserGroupsWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Group` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `User_Id, Group_Id`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, User_Id, Group_Id ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Groups)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Groups>> ListUserGroupsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserGroups");


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

            localVarRequestOptions.Operation = "UsersApi.ListUserGroups";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Groups>("/Endpoint/rest/api/v1/User/{Id}/Groups", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserGroups", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Locations</returns>
        public Locations ListUserLocations(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Locations> localVarResponse = ListUserLocationsWithHttpInfo(id, name, fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Locations</returns>
        public ApiResponse<Locations> ListUserLocationsWithHttpInfo(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserLocations");

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

            localVarRequestOptions.Operation = "UsersApi.ListUserLocations";
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
            var localVarResponse = Client.Get<Locations>("/Endpoint/rest/api/v1/User/{Id}/Locations", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserLocations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Locations</returns>
        public async System.Threading.Tasks.Task<Locations> ListUserLocationsAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Locations> localVarResponse = await ListUserLocationsWithHttpInfoAsync(id, name, fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, LocationId, UserId, ModifiedOn, ModifiedBy, CreatedBy, CreatedOn ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Locations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Locations>> ListUserLocationsWithHttpInfoAsync(string id, string name = default, string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->ListUserLocations");


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

            localVarRequestOptions.Operation = "UsersApi.ListUserLocations";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Locations>("/Endpoint/rest/api/v1/User/{Id}/Locations", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUserLocations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: ``  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Users</returns>
        public Users ListUsers(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
        {
            ApiResponse<Users> localVarResponse = ListUsersWithHttpInfo(fields, filters, orders, currentPage, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: ``  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Users</returns>
        public ApiResponse<Users> ListUsersWithHttpInfo(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "UsersApi.ListUsers";
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
            var localVarResponse = Client.Get<Users>("/Endpoint/rest/api/v1/Users", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUsers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: ``  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Users</returns>
        public async System.Threading.Tasks.Task<Users> ListUsersAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Users> localVarResponse = await ListUsersWithHttpInfoAsync(fields, filters, orders, currentPage, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended `User` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: ``  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&#39;s name, and a limit is set to return a maximum of 1000 rows.  ```http fields=Name,ExternalId,Email&amp;Filters=(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &gt; 2022-01-01)&amp;Orders=Name ASC&amp;PageSize=1000 ```
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fields">Specify the fields you want to retrieve in the fields parameter and use the GET method of the resource.  The list of database column attributes. If list is empty or &quot;*&quot; then all of fields will be returned.  This method converts a string list to a string with a comma separator.  Example:  ``` Id, Name, Username, Email, MobilePhone, External_Id, Creation_Date, Last_Login, Is_Active ``` (optional)</param>
        /// <param name="filters">In the List methods, filtering of resources can be performed using filter parameters.  You can also use parent tables as a search filter. For example, the `Employee` table has a `DepartmentId` field, so you can search for a department name using the `DepartmentId.Name` field name. All fields in the parent table are available.  The name of the entity field. Example: `Name` or relation field `OwnerId.Name`  Please refer to the corresponding method&#39;s documentation for the complete list of supported filter parameters by record.  The operator must be a standard comparison operator =, &lt;&gt;, &gt;, &gt;=, &lt;, &lt;=, In, Like, NotIn  You can add multiple values separated by comma when using the `In`, `NotIn` operators. Example of text field; `USA; FIN; ARE` Example of numeric field; `1, 2, 3`  Example of filters: ```sql Filters=(DepartmentId.Name = My Department) AND (DepartmentId.CreatedOn = 2021-01-01)  Filters=(DepartmentId.Name = My Department 1) OR (DepartmentId.ExternalId In DE001;DE002)  Filters=ExternalId In S100;S101;S120;100  Filters=Id = 100  ```  (optional)</param>
        /// <param name="orders">The `Orders` parameter is provided for sorting the result in the desired order. Both the attribute based on which sorting needs to be done, and the order of sorting (ascending or descending) can be specified. This method converts a string list to a string with a comma separator.  Example:  ``` Name DESC, CreatedOn ASC ``` (optional)</param>
        /// <param name="currentPage">This field specifies the current page of results being returned. It&#39;s often used in conjunction with `PageSize` to manage pagination by indicating which subset of the total data is currently being retrieved. (optional, default to 0)</param>
        /// <param name="pageSize">The field indicates the number of items returned in a single page or response. It helps clients determine how many items to display per page and how to request additional pages if needed.  The value ranges from `1` to `1000` and defaults to `50`. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Users)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Users>> ListUsersWithHttpInfoAsync(string fields = default, string filters = default, string orders = default, int? currentPage = default, int? pageSize = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
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

            localVarRequestOptions.Operation = "UsersApi.ListUsers";
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
            var localVarResponse = await AsynchronousClient.GetAsync<Users>("/Endpoint/rest/api/v1/Users", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("ListUsers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentsData">The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Departments</returns>
        public Departments PatchUserDepartments(string id, DepartmentsData departmentsData, string name = default, string deleteNotExists = default, int operationIndex = 0)
        {
            ApiResponse<Departments> localVarResponse = PatchUserDepartmentsWithHttpInfo(id, departmentsData, name, deleteNotExists);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentsData">The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Departments</returns>
        public ApiResponse<Departments> PatchUserDepartmentsWithHttpInfo(string id, DepartmentsData departmentsData, string name = default, string deleteNotExists = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->PatchUserDepartments");

            // verify the required parameter 'departmentsData' is set
            departmentsData = departmentsData ?? throw new ApiException(400, "Missing required parameter 'departmentsData' when calling UsersApi->PatchUserDepartments");

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
            localVarRequestOptions.Data = departmentsData;

            localVarRequestOptions.Operation = "UsersApi.PatchUserDepartments";
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
            var localVarResponse = Client.Patch<Departments>("/Endpoint/rest/api/v1/User/{Id}/Departments", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PatchUserDepartments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentsData">The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Departments</returns>
        public async System.Threading.Tasks.Task<Departments> PatchUserDepartmentsAsync(string id, DepartmentsData departmentsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Departments> localVarResponse = await PatchUserDepartmentsWithHttpInfoAsync(id, departmentsData, name, deleteNotExists, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `DepartmentsData` object resource to insert or update (Upsert) a list of `DepartmentData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentList` record structure as text fields in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Department` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentsData">The list of Department information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Departments)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Departments>> PatchUserDepartmentsWithHttpInfoAsync(string id, DepartmentsData departmentsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->PatchUserDepartments");

            // verify the required parameter 'departmentsData' is set
            departmentsData = departmentsData ?? throw new ApiException(400, "Missing required parameter 'departmentsData' when calling UsersApi->PatchUserDepartments");


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
            localVarRequestOptions.Data = departmentsData;

            localVarRequestOptions.Operation = "UsersApi.PatchUserDepartments";
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
            var localVarResponse = await AsynchronousClient.PatchAsync<Departments>("/Endpoint/rest/api/v1/User/{Id}/Departments", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PatchUserDepartments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationsData">The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Locations</returns>
        public Locations PatchUserLocations(string id, LocationsData locationsData, string name = default, string deleteNotExists = default, int operationIndex = 0)
        {
            ApiResponse<Locations> localVarResponse = PatchUserLocationsWithHttpInfo(id, locationsData, name, deleteNotExists);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationsData">The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Locations</returns>
        public ApiResponse<Locations> PatchUserLocationsWithHttpInfo(string id, LocationsData locationsData, string name = default, string deleteNotExists = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->PatchUserLocations");

            // verify the required parameter 'locationsData' is set
            locationsData = locationsData ?? throw new ApiException(400, "Missing required parameter 'locationsData' when calling UsersApi->PatchUserLocations");

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
            localVarRequestOptions.Data = locationsData;

            localVarRequestOptions.Operation = "UsersApi.PatchUserLocations";
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
            var localVarResponse = Client.Patch<Locations>("/Endpoint/rest/api/v1/User/{Id}/Locations", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PatchUserLocations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationsData">The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Locations</returns>
        public async System.Threading.Tasks.Task<Locations> PatchUserLocationsAsync(string id, LocationsData locationsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Locations> localVarResponse = await PatchUserLocationsWithHttpInfoAsync(id, locationsData, name, deleteNotExists, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationsData` object resource to insert or update (Upsert) a list of `LocationData` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationList` record structure as text fields in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  **Attention!**, this can also cause an incorrect row update, but at the same time enables efficient data transfer between systems.  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the record list structure of the updated or created record if the call is successful. The method returns a list structured with an extended `Location` representation. In this format, all foreign key fields are depicted as abstract object structures, employing `AbstractText` or `AbstractLong` data types. This offers an enriched and detailed perspective of the data and its associated entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationsData">The list of Location information to insert or update.  The input parameter must be used in the `Extra` record array structure inside the `Name` and `FieldName` parameters in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="deleteNotExists">The Delete not exists function delete orphan values from a table.  If you specify value, you do not need to manually delete orphan rows from the table, the service retrieves the result set and if it is not found from the json string, then delete orphan rows from the table. (optional, default to &quot;false&quot;)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Locations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Locations>> PatchUserLocationsWithHttpInfoAsync(string id, LocationsData locationsData, string name = default, string deleteNotExists = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->PatchUserLocations");

            // verify the required parameter 'locationsData' is set
            locationsData = locationsData ?? throw new ApiException(400, "Missing required parameter 'locationsData' when calling UsersApi->PatchUserLocations");


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
            localVarRequestOptions.Data = locationsData;

            localVarRequestOptions.Operation = "UsersApi.PatchUserLocations";
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
            var localVarResponse = await AsynchronousClient.PatchAsync<Locations>("/Endpoint/rest/api/v1/User/{Id}/Locations", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("PatchUserLocations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, UserId`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of AccessGroup * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="accessGroupData">`AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AccessGroup</returns>
        public AccessGroup UpsertUserAccessGroup(string id, AccessGroupData accessGroupData, string name = default, int operationIndex = 0)
        {
            ApiResponse<AccessGroup> localVarResponse = UpsertUserAccessGroupWithHttpInfo(id, accessGroupData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, UserId`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of AccessGroup * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="accessGroupData">`AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AccessGroup</returns>
        public ApiResponse<AccessGroup> UpsertUserAccessGroupWithHttpInfo(string id, AccessGroupData accessGroupData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->UpsertUserAccessGroup");

            // verify the required parameter 'accessGroupData' is set
            accessGroupData = accessGroupData ?? throw new ApiException(400, "Missing required parameter 'accessGroupData' when calling UsersApi->UpsertUserAccessGroup");

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
            localVarRequestOptions.Data = accessGroupData;

            localVarRequestOptions.Operation = "UsersApi.UpsertUserAccessGroup";
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
            var localVarResponse = Client.Post<AccessGroup>("/Endpoint/rest/api/v1/User/{Id}/AccessGroup", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertUserAccessGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, UserId`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of AccessGroup * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="accessGroupData">`AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessGroup</returns>
        public async System.Threading.Tasks.Task<AccessGroup> UpsertUserAccessGroupAsync(string id, AccessGroupData accessGroupData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<AccessGroup> localVarResponse = await UpsertUserAccessGroupWithHttpInfoAsync(id, accessGroupData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `AccessGroupPost` object resource to insert or update (Upsert) `AccessGroup` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `AccessGroupId, UserId`  ### Update a record of AccessGroup * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of AccessGroup * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`AccessGroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `AccessGroup` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="accessGroupData">`AccessGroup` information to insert or update.  The input parameter must be used in the `AccessGroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccessGroup>> UpsertUserAccessGroupWithHttpInfoAsync(string id, AccessGroupData accessGroupData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->UpsertUserAccessGroup");

            // verify the required parameter 'accessGroupData' is set
            accessGroupData = accessGroupData ?? throw new ApiException(400, "Missing required parameter 'accessGroupData' when calling UsersApi->UpsertUserAccessGroup");


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
            localVarRequestOptions.Data = accessGroupData;

            localVarRequestOptions.Operation = "UsersApi.UpsertUserAccessGroup";
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
            var localVarResponse = await AsynchronousClient.PostAsync<AccessGroup>("/Endpoint/rest/api/v1/User/{Id}/AccessGroup", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertUserAccessGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentData">`Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Department</returns>
        public Department UpsertUserDepartment(string id, DepartmentData departmentData, string name = default, int operationIndex = 0)
        {
            ApiResponse<Department> localVarResponse = UpsertUserDepartmentWithHttpInfo(id, departmentData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentData">`Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Department</returns>
        public ApiResponse<Department> UpsertUserDepartmentWithHttpInfo(string id, DepartmentData departmentData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->UpsertUserDepartment");

            // verify the required parameter 'departmentData' is set
            departmentData = departmentData ?? throw new ApiException(400, "Missing required parameter 'departmentData' when calling UsersApi->UpsertUserDepartment");

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
            localVarRequestOptions.Data = departmentData;

            localVarRequestOptions.Operation = "UsersApi.UpsertUserDepartment";
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
            var localVarResponse = Client.Post<Department>("/Endpoint/rest/api/v1/User/{Id}/Department", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertUserDepartment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentData">`Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Department</returns>
        public async System.Threading.Tasks.Task<Department> UpsertUserDepartmentAsync(string id, DepartmentData departmentData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Department> localVarResponse = await UpsertUserDepartmentWithHttpInfoAsync(id, departmentData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `DepartmentPost` object resource to insert or update (Upsert) `Department` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `DepartmentId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Department * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Department * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`DepartmentData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Department` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="departmentData">`Department` information to insert or update.  The input parameter must be used in the `DepartmentData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Department)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Department>> UpsertUserDepartmentWithHttpInfoAsync(string id, DepartmentData departmentData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->UpsertUserDepartment");

            // verify the required parameter 'departmentData' is set
            departmentData = departmentData ?? throw new ApiException(400, "Missing required parameter 'departmentData' when calling UsersApi->UpsertUserDepartment");


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
            localVarRequestOptions.Data = departmentData;

            localVarRequestOptions.Operation = "UsersApi.UpsertUserDepartment";
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
            var localVarResponse = await AsynchronousClient.PostAsync<Department>("/Endpoint/rest/api/v1/User/{Id}/Department", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertUserDepartment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `User_Id, Group_Id`  ### Update a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Group * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="groupData">`Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Group</returns>
        public Group UpsertUserGroup(string id, GroupData groupData, string name = default, int operationIndex = 0)
        {
            ApiResponse<Group> localVarResponse = UpsertUserGroupWithHttpInfo(id, groupData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `User_Id, Group_Id`  ### Update a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Group * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="groupData">`Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Group</returns>
        public ApiResponse<Group> UpsertUserGroupWithHttpInfo(string id, GroupData groupData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->UpsertUserGroup");

            // verify the required parameter 'groupData' is set
            groupData = groupData ?? throw new ApiException(400, "Missing required parameter 'groupData' when calling UsersApi->UpsertUserGroup");

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
            localVarRequestOptions.Data = groupData;

            localVarRequestOptions.Operation = "UsersApi.UpsertUserGroup";
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
            var localVarResponse = Client.Post<Group>("/Endpoint/rest/api/v1/User/{Id}/Group", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertUserGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `User_Id, Group_Id`  ### Update a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Group * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="groupData">`Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Group</returns>
        public async System.Threading.Tasks.Task<Group> UpsertUserGroupAsync(string id, GroupData groupData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Group> localVarResponse = await UpsertUserGroupWithHttpInfoAsync(id, groupData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `GroupPost` object resource to insert or update (Upsert) `Group` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `User_Id, Group_Id`  ### Update a record of Group * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Group * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`GroupData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Group` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="groupData">`Group` information to insert or update.  The input parameter must be used in the `GroupData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Group>> UpsertUserGroupWithHttpInfoAsync(string id, GroupData groupData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->UpsertUserGroup");

            // verify the required parameter 'groupData' is set
            groupData = groupData ?? throw new ApiException(400, "Missing required parameter 'groupData' when calling UsersApi->UpsertUserGroup");


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
            localVarRequestOptions.Data = groupData;

            localVarRequestOptions.Operation = "UsersApi.UpsertUserGroup";
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
            var localVarResponse = await AsynchronousClient.PostAsync<Group>("/Endpoint/rest/api/v1/User/{Id}/Group", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertUserGroup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Location</returns>
        public Location UpsertUserLocation(string id, LocationData locationData, string name = default, int operationIndex = 0)
        {
            ApiResponse<Location> localVarResponse = UpsertUserLocationWithHttpInfo(id, locationData, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Location</returns>
        public ApiResponse<Location> UpsertUserLocationWithHttpInfo(string id, LocationData locationData, string name = default, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->UpsertUserLocation");

            // verify the required parameter 'locationData' is set
            locationData = locationData ?? throw new ApiException(400, "Missing required parameter 'locationData' when calling UsersApi->UpsertUserLocation");

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
            localVarRequestOptions.Data = locationData;

            localVarRequestOptions.Operation = "UsersApi.UpsertUserLocation";
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
            var localVarResponse = Client.Post<Location>("/Endpoint/rest/api/v1/User/{Id}/Location", localVarRequestOptions, Configuration);
            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertUserLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Location</returns>
        public async System.Threading.Tasks.Task<Location> UpsertUserLocationAsync(string id, LocationData locationData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<Location> localVarResponse = await UpsertUserLocationWithHttpInfoAsync(id, locationData, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Use the `LocationPost` object resource to insert or update (Upsert) `Location` using `Id, UserId.Email, UserId.Username` field(s) value.  You can supply the required field values in the request data, and then use the `POST` method of the resource.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.  Foreign key fields are: `LocationId, UserId, ModifiedBy, CreatedBy`  ### Update a record of Location * If the `Id` field value is not matched, then a `404` error is reported (`Errors/Not Found`), and the error record is returned.. You cannot change `Id` field value (primary key). * If the `UserId.Email, UserId.Username` field value is not empty and `Id` field value is empty, action try insert record according `UserId.Email, UserId.Username` field value (if set, the value is a unique identifier).  ### Create a new record of Location * If the value in the `UserId.Email, UserId.Username` and `Id` fields are empty then action insert a new record according input parameter entity record structure (`LocationData`).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended `Location` structure. Here, all foreign key fields are abstract object structures, utilizing `AbstractText` or `AbstractLong` data types, offering a detailed view of the data and related entities.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the User record. The parameter is part of the url address and some special characters are forbidden.  You can extract any string to a base64 string. E.g email address name@domain.com value is base64|bmFtZUBkb21haW4uY29t</param>
        /// <param name="locationData">`Location` information to insert or update.  The input parameter must be used in the `LocationData` record structure inside the `FieldType` parameter in the foreign key fields.</param>
        /// <param name="name">The name of the database field. If empty, the entity `Id` field is used.  Example:  ``` Id ``` (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Location)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Location>> UpsertUserLocationWithHttpInfoAsync(string id, LocationData locationData, string name = default, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            id = id ?? throw new ApiException(400, "Missing required parameter 'id' when calling UsersApi->UpsertUserLocation");

            // verify the required parameter 'locationData' is set
            locationData = locationData ?? throw new ApiException(400, "Missing required parameter 'locationData' when calling UsersApi->UpsertUserLocation");


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
            localVarRequestOptions.Data = locationData;

            localVarRequestOptions.Operation = "UsersApi.UpsertUserLocation";
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
            var localVarResponse = await AsynchronousClient.PostAsync<Location>("/Endpoint/rest/api/v1/User/{Id}/Location", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                Exception _exception = ExceptionFactory("UpsertUserLocation", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
