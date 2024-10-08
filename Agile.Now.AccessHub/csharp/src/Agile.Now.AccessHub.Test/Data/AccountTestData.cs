using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.ApiAccounts.Test.Api;

public class AccountTestData2 : TestData<Account, AccountData> {
    public override void AssertEqual(AccountData data0, Account data1) => data0.AssertEqual(data1);
    public override void AssertEqual(Account data0, Account data1) => data0.AssertEqual(data1);
    public override IEnumerable<AccountData> GenerateRequestData() => AccountTestData.CreateAccountDatas();
    public override void Update(AccountData data) => AccountTestData.UpdateAccountData(data);
}

public class AccountTenantTestData : TestData<Tenant, TenantData> {
    public override void AssertEqual(TenantData data0, Tenant data1) { }
    public override void AssertEqual(Tenant data0, Tenant data1) { }
    public override IEnumerable<TenantData> GenerateRequestData() => AccountTestData.CreateTenantDatas();
    public override void Update(TenantData data) { }
}

public class AccountPictureTestData : TestData<Picture, PictureData> {
    public override void AssertEqual(PictureData data0, Picture data1) { }
    public override void AssertEqual(Picture data0, Picture data1) { }
    public override IEnumerable<PictureData> GenerateRequestData() => AccountTestData.CreatePicturesDatas();
    public override void Update(PictureData data) { }
}

internal static class AccountTestData {
    public const int DefaultTenant = 15;
    public const int AnotherTenant = 7182;//7186
    public const string PictureData = "0123456789";

    public static AccountData CreateAccountData(string suffix = null) {
        var name = CommonTestData.CreateTestEntityName("account", suffix);
        var uniqueName = name.MakeUnique();
        return new AccountData
        (
            externalId: Guid.NewGuid().ToString(),
            firstName: name,
            lastName: "lastName" + suffix,
            email: uniqueName + "@agilenow.io",
            username: uniqueName,
            dateFormatId: EnumDateFormat.DdMmYyyy,
            timezoneId: EnumTimezone.Gmt0100Azores,
            languageId: EnumLanguage.Finnish
        );
    }

    public static IEnumerable<AccountData> CreateAccountDatas() =>
        Enumerable.Range(0, 4).Select(i => CreateAccountData(i.ToString()));

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

    public static void AssertEqual(this Account data, Account account) {
        Assert.Equal(data.TenantId.Id, account.TenantId.Id);
        Assert.Equal(data.LastName, account.LastName);
        Assert.Equal(data.FirstName, account.FirstName);
        Assert.Equal(data.Email, account.Email);
        Assert.Equal(data.DateFormatId.Id, account.DateFormatId.Id);
        Assert.Equal(data.TimezoneId.Id, account.TimezoneId.Id);
        Assert.Equal(data.LanguageId.Id, account.LanguageId.Id);
    }

    public static IEnumerable<TenantData> CreateTenantDatas() {
        yield return new(
            userId: new("Id", UserTestData.Users[0].ToString()),
            tenantId: new("Id", AnotherTenant.ToString()));
    }

    public static IEnumerable<PictureData> CreatePicturesDatas() {
        yield return new(PictureData.ToStream());
    }

    public static Stream ToStream(this string s) =>
        new TestStream(Encoding.UTF8.GetBytes(Convert.ToBase64String(Encoding.UTF8.GetBytes(s ?? ""))));
}

public class TestStream : MemoryStream {
    public TestStream(byte[] buffer) : base(buffer) { }
    public override int ReadTimeout { get => 10000; set => base.ReadTimeout = value; }
    public override int WriteTimeout { get => 10000; set => base.WriteTimeout = value; }
    public override bool CanTimeout => true;
}