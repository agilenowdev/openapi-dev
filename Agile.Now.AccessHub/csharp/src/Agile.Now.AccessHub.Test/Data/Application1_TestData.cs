using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class Application1_TestData : TestData<Application, ApplicationData1> {
    public override void AssertEqualToRequest(ApplicationData1 data0, Application data1) {
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.ApplicationKey, data1.ApplicationKey);
        Assert.Equal(data0.ExternalId, data1.ExternalId);
        Assert.Equal(data0.Description, data1.Description);
        Assert.Equal(data0.WebSiteURL, data1.WebSiteURL);
    }

    public override void AssertEqualToResponse(Application data0, Application data1) {
        Assert.Equal(data0.Id, data1.Id);
        Assert.Equal(data0.Name, data1.Name);
        Assert.Equal(data0.ApplicationKey, data1.ApplicationKey);
        Assert.Equal(data0.ExternalId, data1.ExternalId);
        Assert.Equal(data0.Description, data1.Description);
        Assert.Equal(data0.WebSiteURL, data1.WebSiteURL);
    }

    public override IEnumerable<ApplicationData1> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("application", i.ToString());
            return new ApplicationData1(
                name: name.MakeUnique(),
                applicationKey: Guid.NewGuid().ToString(),
                externalId: Guid.NewGuid().ToString(),
                description: name,
                webSiteURL: "www.test.io"
            );
        });

    public static readonly string ParentApplication = "3B594DDA-3F5D-431A-A532-A3EDFFA9BD98";
}
