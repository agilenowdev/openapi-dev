/*
 * Agile.Now.AccessHub API documentation
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: dev@agilenow.io
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.api;

import org.openapitools.client.ApiException;
import org.openapitools.client.model.Account;
import org.openapitools.client.model.AccountData;
import org.openapitools.client.model.Accounts;
import org.openapitools.client.model.Error;
import org.openapitools.client.model.Tenant;
import org.openapitools.client.model.TenantData;
import org.openapitools.client.model.Tenants;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for AccountsApi
 */
@Disabled
public class AccountsApiTest {

    private final AccountsApi api = new AccountsApi();

    /**
     * Use the &#x60;AccountData&#x60; object resource to create new records.  You can supply the required field values in the request data, and then use the &#x60;POST&#x60; method of the resource.  The input parameter must be used in the &#x60;AccountData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields.  Foreign key fields are: &#x60;TenantId, LanguageId, TimezoneId, DateFormatId&#x60;  ### Create a new record of Account * If the value in the &#x60;Id,Username, ExternalId&#x60; fields are empty then action insert a new record according input parameter entity record structure (&#x60;AccountData&#x60;). * If the value in the &#x60;Username, ExternalId&#x60; and &#x60;Id&#x60; fields are empty then action insert a new record according input parameter entity record structure (&#x60;AccountData&#x60;). * If the &#x60;Id,Username, ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.  The response body will contain the object of the created record if the call is successful. Method returns an extended &#x60;Account&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void createAccountTest() throws ApiException {
        AccountData accountData = null;
        Account response = api.createAccount(accountData);
        // TODO: test validations
    }

    /**
     * Use the query string resource to delete &#x60;Account&#x60; record. The method contains two parameters &#x60;Id&#x60; and &#x60;Name&#x60;. Specify the record &#x60;{Id}&#x60;, &#x60;Name&#x60; using &#x60;Id,Username, ExternalId&#x60; field(s) value and use the &#x60;DELETE&#x60; method of the resource to delete a record.  Method returns an extended &#x60;Account&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  Foreign key fields are: &#x60;TenantId, LanguageId, TimezoneId, DateFormatId&#x60;  ### Delete a record of Account * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;Id,Username, ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void deleteAccountTest() throws ApiException {
        String id = null;
        String name = null;
        Account response = api.deleteAccount(id, name);
        // TODO: test validations
    }

    /**
     * Use the query string resource to delete &#x60;Tenant&#x60; record. The method contains two parameters &#x60;SubId&#x60; and &#x60;SubName&#x60;. Specify the record &#x60;SubId&#x60;, &#x60;SubName&#x60; using &#x60;UserId,AccountId.Username, AccountId.ExternalId&#x60; field(s) value and use the &#x60;DELETE&#x60; method of the resource to delete a record.  Method returns an extended &#x60;Tenant&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  Foreign key fields are: &#x60;UserId, TenantId, AccountId&#x60;  ### Delete a record of Tenant * If the &#x60;UserId&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;UserId,AccountId.Username, AccountId.ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.  The response body will contain the object of the deleted record if the call is successful.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void deleteAccountTenantTest() throws ApiException {
        String id = null;
        String subId = null;
        String name = null;
        String subName = null;
        Tenant response = api.deleteAccountTenant(id, subId, name, subName);
        // TODO: test validations
    }

    /**
     * The method returns one record of the &#x60;Account&#x60;.  Method returns an extended &#x60;Account&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.  Foreign key fields are: &#x60;TenantId, LanguageId, TimezoneId, DateFormatId&#x60;  ### Get a record of Account * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned. * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;Id,Username, ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getAccountTest() throws ApiException {
        String id = null;
        String name = null;
        Account response = api.getAccount(id, name);
        // TODO: test validations
    }

    /**
     * Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended &#x60;Tenant&#x60; representation. In this format, all foreign key fields are depicted as abstract object structures, employing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: &#x60;UserId, TenantId, AccountId&#x60;  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&amp;#39;s name, and a limit is set to return a maximum of 1000 rows.  &#x60;&#x60;&#x60;http fields&#x3D;Name,ExternalId,Email&amp;amp;Filters&#x3D;(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &amp;gt; 2022-01-01)&amp;amp;Orders&#x3D;Name ASC&amp;amp;PageSize&#x3D;1000 &#x60;&#x60;&#x60;
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void listAccountTenantsTest() throws ApiException {
        String id = null;
        String name = null;
        String fields = null;
        String filters = null;
        String orders = null;
        Integer currentPage = null;
        Integer pageSize = null;
        Tenants response = api.listAccountTenants(id, name, fields, filters, orders, currentPage, pageSize);
        // TODO: test validations
    }

    /**
     * Utilize this method to execute a query designed to fetch comprehensive information, delivering all results in a singular response. If necessary, the method returns a portion of the results along with an identifier to retrieve the remaining data.  Leverage the search service to extract the requisite information from the system effectively.  The method returns a list structured with an extended &#x60;Account&#x60; representation. In this format, all foreign key fields are depicted as abstract object structures, employing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types. This offers an enriched and detailed perspective of the data and its associated entities.  The foreign key fields involved are: &#x60;TenantId, LanguageId, TimezoneId, DateFormatId&#x60;  ### Example It searches for employees whose data has been modified since January 1, 2022, and belong to departments with external system identifiers DE001 and DE002. The system responds by returning the name, external identifier, and email address of the relevant employees. The retrieved information is organized in ascending order by the person&amp;#39;s name, and a limit is set to return a maximum of 1000 rows.  &#x60;&#x60;&#x60;http fields&#x3D;Name,ExternalId,Email&amp;amp;Filters&#x3D;(DepartmentId.ExternalId In DE001;DE002) AND (ModifiedOn &amp;gt; 2022-01-01)&amp;amp;Orders&#x3D;Name ASC&amp;amp;PageSize&#x3D;1000 &#x60;&#x60;&#x60;
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void listAccountsTest() throws ApiException {
        String fields = null;
        String filters = null;
        String orders = null;
        Integer currentPage = null;
        Integer pageSize = null;
        Accounts response = api.listAccounts(fields, filters, orders, currentPage, pageSize);
        // TODO: test validations
    }

    /**
     * Use the &#x60;AccountData&#x60; object resource to update &#x60;Account&#x60; using &#x60;Id,Username, ExternalId&#x60; field(s) value.  Provide the updated record information in your request data and use the &#x60;PUT&#x60; method of the resource with a specific record ID to update that record.   The input parameter must be used in the &#x60;AccountData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields.  Foreign key fields are: &#x60;TenantId, LanguageId, TimezoneId, DateFormatId&#x60;  ### Update a record of Account * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned.. You cannot change &#x60;Id&#x60; field value (primary key). * If the &#x60;Id&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned. * If the &#x60;Id,Username, ExternalId&#x60; field value is matched multiple times, then a &#x60;400&#x60; error is reported (&#x60;Errors/Multible Rows&#x60;), and the error record is returned.  The response body will contain the object of the updated record if the call is successful. Method returns an extended &#x60;Account&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void updateAccountTest() throws ApiException {
        String id = null;
        AccountData accountData = null;
        String name = null;
        Account response = api.updateAccount(id, accountData, name);
        // TODO: test validations
    }

    /**
     * Use the &#x60;AccountData&#x60; object resource to insert or update (Upsert) &#x60;Account&#x60; using &#x60;Id,Username, ExternalId&#x60; field(s) value.  You can supply the required field values in the request data, and then use the &#x60;POST&#x60; method of the resource.  The input parameter must be used in the &#x60;AccountData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields.  Foreign key fields are: &#x60;TenantId, LanguageId, TimezoneId, DateFormatId&#x60;  ### Update a record of Account * If the &#x60;Id&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned.. You cannot change &#x60;Id&#x60; field value (primary key). * If the &#x60;Username, ExternalId&#x60; field value is not empty and &#x60;Id&#x60; field value is empty, action try insert record according &#x60;Username, ExternalId&#x60; field value (if set, the value is a unique identifier).  ### Create a new record of Account * If the value in the &#x60;Username, ExternalId&#x60; and &#x60;Id&#x60; fields are empty then action insert a new record according input parameter entity record structure (&#x60;AccountData&#x60;).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended &#x60;Account&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void upsertAccountTest() throws ApiException {
        AccountData accountData = null;
        Account response = api.upsertAccount(accountData);
        // TODO: test validations
    }

    /**
     * Use the &#x60;TenantPost&#x60; object resource to insert or update (Upsert) &#x60;Tenant&#x60; using &#x60;UserId,AccountId.Username, AccountId.ExternalId&#x60; field(s) value.  You can supply the required field values in the request data, and then use the &#x60;POST&#x60; method of the resource.  The input parameter must be used in the &#x60;TenantData&#x60; record structure inside the &#x60;FieldType&#x60; parameter in the foreign key fields.  Foreign key fields are: &#x60;UserId, TenantId, AccountId&#x60;  ### Update a record of Tenant * If the &#x60;UserId&#x60; field value is not matched, then a &#x60;404&#x60; error is reported (&#x60;Errors/Not Found&#x60;), and the error record is returned.. You cannot change &#x60;UserId&#x60; field value (primary key). * If the &#x60;AccountId.Username, AccountId.ExternalId&#x60; field value is not empty and &#x60;UserId&#x60; field value is empty, action try insert record according &#x60;AccountId.Username, AccountId.ExternalId&#x60; field value (if set, the value is a unique identifier).  ### Create a new record of Tenant * If the value in the &#x60;AccountId.Username, AccountId.ExternalId&#x60; and &#x60;UserId&#x60; fields are empty then action insert a new record according input parameter entity record structure (&#x60;TenantData&#x60;).  The response body will contain the object of the updated or created record if the call is successful. Method returns an extended &#x60;Tenant&#x60; structure. Here, all foreign key fields are abstract object structures, utilizing &#x60;AbstractText&#x60; or &#x60;AbstractLong&#x60; data types, offering a detailed view of the data and related entities.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void upsertAccountTenantTest() throws ApiException {
        String id = null;
        TenantData tenantData = null;
        String name = null;
        Tenant response = api.upsertAccountTenant(id, tenantData, name);
        // TODO: test validations
    }

}
