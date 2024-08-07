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
    ///  Class for testing EntitiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EntitiesApiTests : IDisposable
    {
        private EntitiesApi instance;

        public EntitiesApiTests()
        {
            instance = new EntitiesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EntitiesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EntitiesApi
            //Assert.IsType<EntitiesApi>(instance);
        }

        /// <summary>
        /// Test GetEntity
        /// </summary>
        [Fact]
        public void GetEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string name = null;
            //var response = instance.GetEntity(id, name);
            //Assert.IsType<Entity>(response);
        }

        /// <summary>
        /// Test ListEntities
        /// </summary>
        [Fact]
        public void ListEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fields = null;
            //string filters = null;
            //string orders = null;
            //int? currentPage = null;
            //int? pageSize = null;
            //var response = instance.ListEntities(fields, filters, orders, currentPage, pageSize);
            //Assert.IsType<Entities>(response);
        }
    }
}
