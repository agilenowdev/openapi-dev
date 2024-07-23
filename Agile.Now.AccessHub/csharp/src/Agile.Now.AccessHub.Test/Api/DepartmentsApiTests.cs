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
using Xunit;

using Agile.Now.AccessHub.Client;
using Agile.Now.AccessHub.Api;
// uncomment below to import models
//using Agile.Now.AccessHub.Model;

namespace Agile.Now.AccessHub.Test.Api
{
    /// <summary>
    ///  Class for testing DepartmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DepartmentsApiTests : IDisposable
    {
        private DepartmentsApi instance;

        public DepartmentsApiTests()
        {
            instance = new DepartmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DepartmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DepartmentsApi
            //Assert.IsType<DepartmentsApi>(instance);
        }

        /// <summary>
        /// Test CreateDepartment
        /// </summary>
        [Fact]
        public void CreateDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DepartmentInsertData departmentInsertData = null;
            //var response = instance.CreateDepartment(departmentInsertData);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test DeleteDepartment
        /// </summary>
        [Fact]
        public void DeleteDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string name = null;
            //var response = instance.DeleteDepartment(id, name);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test DeleteDepartmentUser
        /// </summary>
        [Fact]
        public void DeleteDepartmentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string subId = null;
            //string name = null;
            //string subName = null;
            //var response = instance.DeleteDepartmentUser(id, subId, name, subName);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetDepartment
        /// </summary>
        [Fact]
        public void GetDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string name = null;
            //var response = instance.GetDepartment(id, name);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test ListDepartmentUsers
        /// </summary>
        [Fact]
        public void ListDepartmentUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string name = null;
            //string fields = null;
            //string filters = null;
            //string orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //var response = instance.ListDepartmentUsers(id, name, fields, filters, orders, currentPage, pageSize);
            //Assert.IsType<Users>(response);
        }

        /// <summary>
        /// Test ListDepartments
        /// </summary>
        [Fact]
        public void ListDepartmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fields = null;
            //string filters = null;
            //string orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //var response = instance.ListDepartments(fields, filters, orders, currentPage, pageSize);
            //Assert.IsType<Departments>(response);
        }

        /// <summary>
        /// Test PatchDepartmentUsers
        /// </summary>
        [Fact]
        public void PatchDepartmentUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UsersData usersData = null;
            //string name = null;
            //string deleteNotExists = null;
            //var response = instance.PatchDepartmentUsers(id, usersData, name, deleteNotExists);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test UpdateDepartment
        /// </summary>
        [Fact]
        public void UpdateDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DepartmentUpdateData departmentUpdateData = null;
            //string name = null;
            //var response = instance.UpdateDepartment(id, departmentUpdateData, name);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test UpsertDepartment
        /// </summary>
        [Fact]
        public void UpsertDepartmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DepartmentData departmentData = null;
            //var response = instance.UpsertDepartment(departmentData);
            //Assert.IsType<Department>(response);
        }

        /// <summary>
        /// Test UpsertDepartmentUser
        /// </summary>
        [Fact]
        public void UpsertDepartmentUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //UserData userData = null;
            //string name = null;
            //var response = instance.UpsertDepartmentUser(id, userData, name);
            //Assert.IsType<User>(response);
        }
    }
}
