using System.IO;
using System.Text;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Xunit;

namespace Agile.Now.ApiAccounts.Test.Api {
    internal static class AccountTestData {
        public const int DefaultTenant = 15;
        public const int AnotherTenant = 7182;//7186
        public const string PictureData = "0123456789";

        public static AccountData CreateAccountData(string suffix = null) {
            var name = CommonTestData.CreateTestEntityName("account", suffix);
            var uniqueName = name.MakeUnique();
            return new AccountData
            (
                firstName: name,
                lastName: "lastName" + suffix,
                email: uniqueName + "@agilenow.io",
                username: uniqueName,
                dateFormatId: EnumDateFormat.DdMmYyyy,
                timezoneId: EnumTimezone.Gmt0100Azores,
                languageId: EnumLanguage.Finnish
            );
        }

        public static void UpdateAccountData(AccountData accountData) {
            accountData.FirstName = accountData.FirstName.MarkUpdated();
            accountData.LastName = accountData.LastName.MarkUpdated();
            accountData.Email = accountData.Email.MarkUpdated();
            accountData.DateFormatId = accountData.DateFormatId == EnumDateFormat.DdMmYyyy ?
                EnumDateFormat.YyyyMmDd : EnumDateFormat.DdMmYyyy;
            accountData.TimezoneId = accountData.TimezoneId == EnumTimezone.Gmt0100Azores ?
                EnumTimezone.Gmt0100CapeVerdeIs : EnumTimezone.Gmt0100Azores;
            accountData.LanguageId = accountData.LanguageId == EnumLanguage.Finnish ?
                EnumLanguage.English : EnumLanguage.Finnish;
        }

        public static void AssertEqual(this AccountData data, Account account) {
            Assert.Equal(data.LastName, account.LastName);
            Assert.Equal(data.FirstName, account.FirstName);
            Assert.Equal(data.Email, account.Email);
            Assert.Equal(data.DateFormatId, EnumDateFormatValueConverter.FromString(account.DateFormatId.Id));
            Assert.Equal(data.TimezoneId, EnumTimezoneValueConverter.FromString(account.TimezoneId.Id));
            Assert.Equal(data.LanguageId, EnumLanguageValueConverter.FromString(account.LanguageId.Id));
        }

        public static Stream ToStream(this string s) => new TestStream(Encoding.UTF8.GetBytes(s ?? ""));
    }

    public class TestStream : MemoryStream {
        public TestStream(byte[] buffer) : base(buffer) { }
        public override int ReadTimeout { get => 10000; set => base.ReadTimeout = value; }
        public override int WriteTimeout { get => 10000; set => base.WriteTimeout = value; }
        public override bool CanTimeout => true;
    }
};