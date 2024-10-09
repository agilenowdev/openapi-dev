using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Model;
using Xunit;

namespace Agile.Now.Runtime.Test.Data;

public class User_Location_TestData : TestData<Location, LocationData> {
    public override void AssertEqualToRequest(LocationData expected, Location actual) {
        Assert.Equal(expected.LocationId.Value, actual.Id);
    }

    public override void AssertEqualToResponse(Location expected, Location actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.CountryId.Id, actual.CountryId.Id);
        Assert.Equal(expected.TimezoneId.Id, actual.TimezoneId.Id);
        Assert.Equal(expected.CurrencyId.Id, actual.CurrencyId.Id);
    }

    public static readonly string[] Locations = new[] {
        "61B1585D-4A6B-44CD-AFF1-EA068287AEB1",
        "64FF4E9A-736C-4B50-B6B2-606BB4A25CD7",
        "2107D0BF-1237-40CA-9FE3-27B4636D6E2B"
    };

    public static LocationData CreateLocationData(string id) => new(locationId: new("Id", id));

    public override IEnumerable<LocationData> GenerateRequestData() => CreateLocationDatas();

    public static IEnumerable<LocationData> CreateLocationDatas() =>
        Locations.Select(i => CreateLocationData(i));
}

public static class User_Location_TestData_Extensions {
    public static LocationText ToLocationPatchData(this LocationData locationData) =>
        new LocationText(locationId: locationData.LocationId.Value);
}
