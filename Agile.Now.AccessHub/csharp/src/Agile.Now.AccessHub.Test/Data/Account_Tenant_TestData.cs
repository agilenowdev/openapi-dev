using System.Collections.Generic;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;

namespace Agile.Now.ApiAccounts.Test.Api;

public class Account_Tenant_TestData : TestData<Tenant, TenantData> {
    public const int DefaultTenant = 15;
    public readonly int[] ExternalTenants = new[] { 7182, 7186, 7178 };

    public override void AssertEqualToRequest(TenantData data0, Tenant data1) { }
    public override void AssertEqualToResponse(Tenant data0, Tenant data1) { }

    public override IEnumerable<TenantData> GenerateRequestData() {
        yield return new(tenantId: new(nameof(Tenant.Id), DefaultTenant.ToString()));
        foreach(var i in ExternalTenants)
            yield return new(tenantId: new(nameof(Tenant.Id), i.ToString()));
    }
}
