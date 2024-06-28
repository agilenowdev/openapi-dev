using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.ApiAccounts.Model;

namespace Agile.Now.ApiAccounts.Test.Api
{
    internal static class TestAccountData
    {
        public const int DefaultTenant = 15;

        public static AccountData CreateAccountData(string suffix = null)
        {
            var name = "unit-test-account" + suffix;
            var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
            return new
            (
                tenantId: new("Id", DefaultTenant.ToString()),
                firstName: name,
                lastName: "lastName" + suffix,
                email: uniqueName + "@agilenow.io",
                username: uniqueName,
                isActive: true,
                languageId: new("Name", "Finnish")
            )
            {
                DateFormatId = new("Id", "DD-MM-YYYY")
            };
        }

        public static AccountData[] CreateAccountDataList() =>
            new[] { 0, 1, 2 }.Select(i => CreateAccountData(i.ToString())).ToArray();
    }
};