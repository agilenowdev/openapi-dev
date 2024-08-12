using System;
using System.Linq;
using Agile.Now.AccessHub.Model;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class TestLocationData
{
    public static int[] TestUsers = new[] { 35012, 34967 };
    public static string[] Locations = new[] { "27036EDD-AA1F-4EBA-8EC9-D2DFBC7B9A59" };

    public static LocationInsertData CreateLocationData(string suffix = null)
    {
        var name = "unit-test-location" + suffix;
        var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
        return new LocationInsertData
        (
            name: uniqueName,
            countryId: EnumCountry.Finland,
            currencyId: EnumCurrency.UnitedStatesDollar,
            timezoneId: EnumTimezone.Gmt0100WestCentralAfrica
        );
    }

    public static LocationInsertData[] CreateLocationDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateLocationData(i.ToString())).ToArray();

    public static void UpdateLocationData(LocationInsertData locationInsertData)
    {
        const string updated = "updated";
        locationInsertData.CountryId = locationInsertData.CountryId == EnumCountry.Finland ?
            EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
        locationInsertData.CurrencyId = locationInsertData.CurrencyId == EnumCurrency.UnitedStatesDollar ?
            EnumCurrency.Euro : EnumCurrency.UnitedStatesDollar;
    }

    public static LocationUpdateData ToLocationUpdateData(this LocationInsertData locationInsertData) =>
        new
        (
            name: locationInsertData.Name,
            countryId: locationInsertData.CountryId,
            currencyId: locationInsertData.CurrencyId
        );

    public static LocationData ToLocationData(this LocationInsertData locationInsertData) =>
        new
        (
            id: locationInsertData.Id,
            name: locationInsertData.Name,
            countryId: locationInsertData.CountryId,
            currencyId: locationInsertData.CurrencyId,
            timezoneId: locationInsertData.TimezoneId
        );
}
