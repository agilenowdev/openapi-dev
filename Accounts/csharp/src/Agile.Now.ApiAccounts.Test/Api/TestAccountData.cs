using System;
using System.Linq;
using Agile.Now.ApiAccounts.Model;

namespace Agile.Now.ApiAccounts.Test.Api
{
    internal static class TestAccountData
    {
        public const int DefaultTenant = 15;
        public const int AnotherTenant = 7178;

        public static AccountData CreateAccountData(string suffix = null)
        {
            var name = "unit-test-account" + suffix;
            var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
            return new
            (
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

        public static AccountData[] CreateAccountDataList(int count) =>
            Enumerable.Range(0, count).Select(i => CreateAccountData(i.ToString())).ToArray();

        public static void UpdateAccountData(AccountData accountData)
        {
            const string updated = "updated";
            accountData.LastName += updated;
            accountData.FirstName += updated;
            accountData.Email = updated + accountData.Email;
            accountData.LanguageId = accountData.LanguageId.Value == "Finnish" ?
                new("Name", "English") :
                new("Name", "Finnish");
        }

        public static AccountData ToAccountData(Account account) => new
        (
            id: account.Id,
            tenantId: new("Id", account.TenantId.Id.ToString()),
            name: account.Name,
            firstName: account.FirstName,
            lastName: account.LastName,
            phone: account.Phone,
            email: account.Email,
            languageId: new("Name", account.LanguageId.Name),
            timezoneId: new("Id", account.TimezoneId.Id),
            dateFormatId: new("Id", account.DateFormatId.Id),
            username: account.Username,
            externalId: account.ExternalId,
            notifyByEmail: account.NotifyByEmail,
            notifyBySMS: account.NotifyBySMS,
            isActive: account.IsActive
        );
    }
};