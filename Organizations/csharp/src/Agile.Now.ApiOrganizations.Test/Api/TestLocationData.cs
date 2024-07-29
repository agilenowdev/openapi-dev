using System;
using System.Linq;
using Agile.Now.ApiOrganizations.Model;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class TestLocationData
{

    public static int[] TestUsers = new[] { 35012, 34967 };

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

    public static void UpdateLocationData(LocationInsertData locationInsertData, string id = null)
    {
        if (id != null)
            locationInsertData.Id = id;
        const string updated = "updated";
        locationInsertData.Name += updated;
        locationInsertData.CountryId = locationInsertData.CountryId == EnumCountry.FIN ?
            EnumCountry.USA : EnumCountry.FIN;
        locationInsertData.CurrencyId = locationInsertData.CurrencyId == EnumCurrency.USD ?
            EnumCurrency.EUR : EnumCurrency.USD;
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
            currencyId: locationInsertData.CurrencyId
        );
}
