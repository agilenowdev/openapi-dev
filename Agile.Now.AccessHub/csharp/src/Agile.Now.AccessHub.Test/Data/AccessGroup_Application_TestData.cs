using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class AccessGroup_Application_TestData : TestData<Application, ApplicationData> {
    public override void AssertEqualToRequest(ApplicationData data0, Application data1) =>
        Assert.Equal(data0.AccessApplicationId.Value, data1.Id);

    public override void AssertEqualToResponse(Application data0, Application data1) {
        Assert.Equal(data0.Id, data1.Id);
        //Assert.Equal(data0.ApplicationId.Id, data1.ApplicationId.Id);
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
        AccessGroupTestData.Applications.Select(i => new ApplicationData(
            parentApplicationId: new("Id", AccessGroupTestData.ParentApplication),
            accessApplicationId: new("Id", i)));
}
