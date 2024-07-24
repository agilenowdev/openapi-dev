using System;
using System.Linq;
using Agile.Now.ApiOrganizations.Model;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class TestLocationData
{
    public static LocationInsertData CreateLocationData(string suffix = null)
    {
        var name = "unit-test-location" + suffix;
        var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
        return new
        (
            name: uniqueName,
            countryId: EnumCountry.FIN,
            currencyId: EnumCurrency.USD
        );
    }

    public static LocationInsertData[] CreateLocationDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateLocationData(i.ToString())).ToArray();

    public static void UpdateLocationData(LocationInsertData LocationInsertData, string id = null)
    {
        if (id != null)
            LocationInsertData.Id = id;
        const string updated = "updated";
        LocationInsertData.Name += updated;
        LocationInsertData.CountryId = LocationInsertData.CountryId == EnumCountry.FIN ?
            EnumCountry.USA : EnumCountry.FIN;
        LocationInsertData.CurrencyId = LocationInsertData.CurrencyId == EnumCurrency.USD ?
            EnumCurrency.EUR : EnumCurrency.USD;
    }

    public static LocationUpdateData ToLocationUpdateData(this LocationInsertData LocationInsertData) =>
        new
        (
            name: LocationInsertData.Name,
            countryId: LocationInsertData.CountryId,
            currencyId: LocationInsertData.CurrencyId
        );

    public static LocationData ToLocationData(this LocationInsertData LocationInsertData) =>
        new
        (
            name: LocationInsertData.Name,
            countryId: LocationInsertData.CountryId,
            currencyId: LocationInsertData.CurrencyId
        );
}
