using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class Application_TestData : TestData<Application, ApplicationData> {
    public override void AssertEqualToRequest(ApplicationData data0, Application data1) =>
        Assert.Equal(data0.AccessApplicationId.Value, data1.Id);

    public override void AssertEqualToResponse(Application data0, Application data1) {
        Assert.Equal(data0.Id, data1.Id);
        Assert.Equal(data0.ApplicationId.Id, data1.ApplicationId.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.ApplicationKey, data1.ApplicationKey);
        Assert.Equal(data0.ExternalId, data1.ExternalId);
        Assert.Equal(data0.Description, data1.Description);
        Assert.Equal(data0.WebSiteURL, data1.WebSiteURL);
        Assert.Equal(data0.IsSystem, data1.IsSystem);
        Assert.Equal(data0.IsEndUser, data1.IsEndUser);
        Assert.Equal(data0.IsTestApp, data1.IsTestApp);
        Assert.Equal(data0.IsActive, data1.IsActive);
        Assert.Equal(data0.IsReadOnly, data1.IsReadOnly);
        Assert.Equal(data0.AuthenticationId.Id, data1.AuthenticationId.Id);
    }

    public override IEnumerable<ApplicationData> GenerateRequestData() =>
        Applications.Select(i => new ApplicationData(
            parentApplicationId: new("Id", ParentApplication),
            accessApplicationId: new("Id", i)));

    public static readonly string ParentApplication = "3B594DDA-3F5D-431A-A532-A3EDFFA9BD98";

    public static readonly string[] Applications = new[] {
        "15478BAE-C17D-4966-8288-F2F743A4B0EA",
        "5BEE1686-32A5-4469-958C-EFF31CB9EC07",
        "F32007E7-C34E-4043-8E6E-5EB75B7240FB"
    };

}

public static class Application_TestData_Extension {
    public static ApplicationText ToApplicationText(this ApplicationData applicationData) => new(
        parentApplicationId: Application_TestData.ParentApplication,
        accessApplicationId: applicationData.AccessApplicationId.Value);
}
