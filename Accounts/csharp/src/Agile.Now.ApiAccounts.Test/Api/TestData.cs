using System;
using Agile.Now.ApiAccounts.Model;

namespace Agile.Now.ApiAccounts.Test.Api
{
    internal static class TestData
    {
        public const int DefaultTenant = 15;

        public static AccountData CreateAccountData()
        {
            var name = "unit-test-account";
            var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
            return new
            (
                tenantId: new("Id", DefaultTenant.ToString()),
                firstName: name,
                lastName: "lastName",
                email: uniqueName + "@esystems.fi",
                username: uniqueName,
                isActive: true,
                languageId: new("Name", "Finnish")
            )
            {
                DateFormatId = new("Id", "DD-MM-YYYY")
            };
        }
    }
}
