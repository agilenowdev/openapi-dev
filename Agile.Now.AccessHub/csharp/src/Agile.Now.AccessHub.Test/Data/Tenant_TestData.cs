using System.Collections.Generic;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.ApiAccounts.Test.Api;

public class Tenant_TestData : TestData<Tenant, TenantData> {
    public const int DefaultTenant = 15;
    public readonly int[] ExternalTenants = new[] { 7182, 7186, 7178 };

    public override void AssertEqualToRequest(TenantData expected, Tenant actual) { 
        Assert.Equal(expected.TenantId.Value, actual.Id.ToString());
    }

    public override void AssertEqualToResponse(Tenant expected, Tenant actual) { 
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.IsActive, actual.IsActive);
    }

    public override IEnumerable<TenantData> GenerateRequestData() {
        yield return new(tenantId: new(nameof(Tenant.Id), DefaultTenant.ToString()));
        foreach(var i in ExternalTenants)
            yield return new(tenantId: new(nameof(Tenant.Id), i.ToString()));
    }
}
