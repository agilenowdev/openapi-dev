using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.ApiOrganizations.Test.Api;

public class LocationTestData2 : TestData<Location, LocationInsertData> {
    public override void AssertEqual(LocationInsertData expected, Location actual) {
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.CountryId, EnumCountryValueConverter.FromString(actual.CountryId.Id));
        Assert.Equal(expected.TimezoneId, EnumTimezoneValueConverter.FromString(actual.TimezoneId.Id));
        Assert.Equal(expected.CurrencyId, EnumCurrencyValueConverter.FromString(actual.CurrencyId.Id));
    }

    public override void AssertEqual(Location expected, Location actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.CountryId.Id, actual.CountryId.Id);
        Assert.Equal(expected.TimezoneId.Id, actual.TimezoneId.Id);
        Assert.Equal(expected.CurrencyId.Id, actual.CurrencyId.Id);
    }

    public override IEnumerable<LocationInsertData> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => LocationTestData.CreateLocationData(i.ToString()));

    public override void Update(LocationInsertData data) {
        data.CountryId = data.CountryId == EnumCountry.Finland ?
            EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
        data.TimezoneId = data.TimezoneId == EnumTimezone.Gmt0100WestCentralAfrica ?
            EnumTimezone.Gmt0100Azores : EnumTimezone.Gmt0100WestCentralAfrica;
        data.CurrencyId = data.CurrencyId == EnumCurrency.UnitedStatesDollar ?
            EnumCurrency.Euro : EnumCurrency.UnitedStatesDollar;
    }
}

public static class LocationTestData_extention {
    public static LocationUpdateData ToLocationUpdateData(this LocationInsertData locationInsertData) =>
        new(
            name: locationInsertData.Name,
            countryId: locationInsertData.CountryId,
            timezoneId: locationInsertData.TimezoneId,
            currencyId: locationInsertData.CurrencyId
        );

    public static LocationData ToLocationData(this LocationInsertData locationInsertData) =>
        new(
            id: locationInsertData.Id,
            name: locationInsertData.Name,
            countryId: locationInsertData.CountryId,
            timezoneId: locationInsertData.TimezoneId,
            currencyId: locationInsertData.CurrencyId
        );
}

public class LocationUserTestData : TestData<User, UserData> {
    public override void AssertEqual(UserData data0, User data1) { }
    public override void AssertEqual(User data0, User data1) { }
    public override IEnumerable<UserData> GenerateRequestData() => UserTestData.CreateUserData1s();
    public override void Update(UserData data) { }
}

internal static class LocationTestData {
    public static LocationInsertData CreateLocationData(string suffix = null) {
        var name = CommonTestData.CreateTestEntityName("location", suffix);
        return new LocationInsertData
        (
            externalId: Guid.NewGuid().ToString(),
            name: name.MakeUnique(),
            countryId: EnumCountry.Finland,
            timezoneId: EnumTimezone.Gmt0100WestCentralAfrica,
            currencyId: EnumCurrency.UnitedStatesDollar
        );
    }
}
