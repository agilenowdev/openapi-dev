using System;
using System.IO;
using System.Linq;
using System.Text;
using Agile.Now.AccessHub.Model;

namespace Agile.Now.ApiAccounts.Test.Api
{
    internal static class TestAccountData
    {
        public const int DefaultTenant = 15;
        public const int AnotherTenant = 7182;//7186
        public const string PictureData = "0123456789";

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
                languageId: EnumLanguage.Finnish
            )
            {
                DateFormatId = EnumDateFormat.DdMmYyyy
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
            accountData.LanguageId = accountData.LanguageId == EnumLanguage.Finnish ?
                EnumLanguage.English : EnumLanguage.Finnish;
        }

        public static Stream ToStream(this string s) => new TestStream(Encoding.UTF8.GetBytes(s ?? ""));
    }

    public class TestStream : MemoryStream
    {
        public TestStream(byte[] buffer) : base(buffer) { }
        public override int ReadTimeout { get => 10000; set => base.ReadTimeout = value; }
        public override int WriteTimeout { get => 10000; set => base.WriteTimeout = value; }
        public override bool CanTimeout => true;
    }
};