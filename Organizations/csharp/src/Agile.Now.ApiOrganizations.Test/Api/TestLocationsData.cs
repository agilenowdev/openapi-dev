using System;
using System.Linq;
using Agile.Now.ApiOrganizations.Model;

namespace Agile.Now.ApiOrganizations.Test.Api
{
    internal static class TestLocationsData
    {
        public static LocationData CreateLocationData(string suffix = null)
        {
            var name = "unit-test-location" + suffix;
            var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
            return new
            (
                name: uniqueName,
                countryId: new("Name", "Finland"),
                currencyId: new("Name", "United States Dollar")
            );
        }

        public static LocationData[] CreateLocationDataList(int count) =>
            Enumerable.Range(0, count).Select(i => CreateLocationData(i.ToString())).ToArray();

        public static void UpdateLocationData(LocationData locationData, string id = null)
        {
            if (id != null)
                locationData.Id = id;
            const string updated = "updated";
            locationData.Name += updated;
            locationData.CountryId = locationData.CountryId.Value == "Finland" ?
                new("Name", "Aland Islands") :
                new("Name", "Finland");
            locationData.CurrencyId = locationData.CurrencyId.Value == "United States Dollar" ?
                new("Name", "Australian Dollar") :
                new("Name", "United States Dollar");
        }
    }
}
