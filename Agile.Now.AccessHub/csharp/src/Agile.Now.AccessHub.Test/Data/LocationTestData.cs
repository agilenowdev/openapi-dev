using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class LocationTestData
{
    public static LocationInsertData CreateLocationData(string suffix = null)
    {
        var name = CommonTestData.NamePrefix + "unit-test-location" + suffix;
        return new LocationInsertData
        (
            name: name.MakeUnique(),
            countryId: EnumCountry.Finland,
            timezoneId: EnumTimezone.Gmt0100WestCentralAfrica,
            currencyId: EnumCurrency.UnitedStatesDollar
        );
    }

    public static void UpdateLocationData(LocationInsertData locationInsertData)
    {
        locationInsertData.CountryId = locationInsertData.CountryId == EnumCountry.Finland ?
            EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
        locationInsertData.TimezoneId = locationInsertData.TimezoneId == EnumTimezone.Gmt0100WestCentralAfrica ?
            EnumTimezone.Gmt0100Azores : EnumTimezone.Gmt0100WestCentralAfrica;
        locationInsertData.CurrencyId = locationInsertData.CurrencyId == EnumCurrency.UnitedStatesDollar ?
            EnumCurrency.Euro : EnumCurrency.UnitedStatesDollar;
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
