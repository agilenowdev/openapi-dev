using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Xunit;

namespace Agile.Now.ApiOrganizations.Test.Api;

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

    public static IEnumerable<LocationInsertData> CreateLocationDatas() =>
        Enumerable.Range(0, 4).Select(i => CreateLocationData(i.ToString()));

    public static void Update(this LocationInsertData locationInsertData) {
        locationInsertData.CountryId = locationInsertData.CountryId == EnumCountry.Finland ?
            EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
        locationInsertData.TimezoneId = locationInsertData.TimezoneId == EnumTimezone.Gmt0100WestCentralAfrica ?
            EnumTimezone.Gmt0100Azores : EnumTimezone.Gmt0100WestCentralAfrica;
        locationInsertData.CurrencyId = locationInsertData.CurrencyId == EnumCurrency.UnitedStatesDollar ?
            EnumCurrency.Euro : EnumCurrency.UnitedStatesDollar;
    }

    public static void AssertEqual(this LocationInsertData locationInsertData, Location location) {
        Assert.Equal(locationInsertData.Name, location.Name);
        Assert.Equal(locationInsertData.CountryId, EnumCountryValueConverter.FromString(location.CountryId.Id));
        Assert.Equal(locationInsertData.TimezoneId, EnumTimezoneValueConverter.FromString(location.TimezoneId.Id));
        Assert.Equal(locationInsertData.CurrencyId, EnumCurrencyValueConverter.FromString(location.CurrencyId.Id));
    }

    public static void AssertEqual(this Location locationInsertData, Location location) {
        Assert.Equal(locationInsertData.Name, location.Name);
        Assert.Equal(locationInsertData.CountryId.Id, location.CountryId.Id);
        Assert.Equal(locationInsertData.TimezoneId.Id, location.TimezoneId.Id);
        Assert.Equal(locationInsertData.CurrencyId.Id, location.CurrencyId.Id);
    }

    public static LocationUpdateData ToLocationUpdateData(this LocationInsertData locationInsertData) =>
        new
        (
            name: locationInsertData.Name,
            countryId: locationInsertData.CountryId,
            timezoneId: locationInsertData.TimezoneId,
            currencyId: locationInsertData.CurrencyId
        );

    public static LocationData ToLocationData(this LocationInsertData locationInsertData) =>
        new
        (
            id: locationInsertData.Id,
            name: locationInsertData.Name,
            countryId: locationInsertData.CountryId,
            timezoneId: locationInsertData.TimezoneId,
            currencyId: locationInsertData.CurrencyId
        );
}
