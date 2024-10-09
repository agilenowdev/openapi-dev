using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.ApiAccounts.Test.Api;

public class Account_TestData : TestData<Account, AccountInsertData> {
    public override void AssertEqualToRequest(AccountInsertData expected, Account actual) {
        Assert.Equal(expected.LastName, actual.LastName);
        Assert.Equal(expected.FirstName, actual.FirstName);
        Assert.Equal(expected.Email, actual.Email);
        Assert.Equal(expected.LanguageId, EnumLanguageValueConverter.FromString(actual.LanguageId.Id));
        Assert.Equal(expected.TimezoneId, EnumTimezoneValueConverter.FromString(actual.TimezoneId.Id));
        Assert.Equal(expected.DateFormatId, EnumDateFormatValueConverter.FromString(actual.DateFormatId.Id));
    }

    public override void AssertEqualToResponse(Account expected, Account actual) {
        Assert.Equal(expected.TenantId.Id, actual.TenantId.Id);
        Assert.Equal(expected.LastName, actual.LastName);
        Assert.Equal(expected.FirstName, actual.FirstName);
        Assert.Equal(expected.Email, actual.Email);
        Assert.Equal(expected.LanguageId.Id, actual.LanguageId.Id);
        Assert.Equal(expected.TimezoneId.Id, actual.TimezoneId.Id);
        Assert.Equal(expected.DateFormatId.Id, actual.DateFormatId.Id);
    }

    public override IEnumerable<AccountInsertData> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("account", i.ToString());
            var uniqueName = name.MakeUnique();
            return new AccountInsertData(
                firstName: name,
                lastName: "lastName" + i.ToString(),
                email: uniqueName + "@agilenow.io",
                languageId: EnumLanguage.Finnish,
                timezoneId: EnumTimezone.Gmt0100Azores,
                dateFormatId: EnumDateFormat.DdMmYyyy,
                username: uniqueName,
                externalId: Guid.NewGuid().ToString()
            );
        });

    public override void Update(AccountInsertData data) {
        data.FirstName = data.FirstName.MarkUpdated();
        data.LastName = data.LastName.MarkUpdated();
        data.Email = data.Email.MarkUpdated();
        data.LanguageId = data.LanguageId == EnumLanguage.Finnish ?
            EnumLanguage.English : EnumLanguage.Finnish;
        data.TimezoneId = data.TimezoneId == EnumTimezone.Gmt0100Azores ?
            EnumTimezone.Gmt0100CapeVerdeIs : EnumTimezone.Gmt0100Azores;
        data.DateFormatId = data.DateFormatId == EnumDateFormat.DdMmYyyy ?
            EnumDateFormat.YyyyMmDd : EnumDateFormat.DdMmYyyy;
    }
}

public static class Account_TestData_Extension {
    public static AccountUpdateData ToAccountUpdateData(this AccountInsertData accountInsertData) =>
        new AccountUpdateData(
            name: accountInsertData.FirstName,
            firstName: accountInsertData.FirstName,
            lastName: accountInsertData.LastName,
            phone: accountInsertData.Phone,
            email: accountInsertData.Email,
            languageId: accountInsertData.LanguageId,
            timezoneId: accountInsertData.TimezoneId,
            dateFormatId: accountInsertData.DateFormatId,
            username: accountInsertData.Username,
            externalId: accountInsertData.ExternalId,
            notifyByEmail: accountInsertData.NotifyByEmail,
            notifyBySMS: accountInsertData.NotifyBySMS,
            isActive: accountInsertData.IsActive);

    public static AccountData ToAccountData(this AccountInsertData accountInsertData) =>
        new AccountData(
            name: accountInsertData.FirstName,
            firstName: accountInsertData.FirstName,
            lastName: accountInsertData.LastName,
            phone: accountInsertData.Phone,
            email: accountInsertData.Email,
            languageId: accountInsertData.LanguageId,
            timezoneId: accountInsertData.TimezoneId,
            dateFormatId: accountInsertData.DateFormatId,
            username: accountInsertData.Username,
            externalId: accountInsertData.ExternalId,
            notifyByEmail: accountInsertData.NotifyByEmail,
            notifyBySMS: accountInsertData.NotifyBySMS,
            isActive: accountInsertData.IsActive);
}




