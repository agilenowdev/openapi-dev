using System.Collections.Generic;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Agile.Now.Api.Test;

namespace Agile.Now.ApiAccounts.Test.Api;

public class Account_Tenant_TestData : TestData<Tenant, TenantData> {
    public const int DefaultTenant = 15;
    public const int ExternalTenant = 7182;//7186

    public override void AssertEqualToRequest(TenantData data0, Tenant data1) { }
    public override void AssertEqualToResponse(Tenant data0, Tenant data1) { }
    public override IEnumerable<TenantData> GenerateRequestData() => CreateTenantDatas();
    public override void Update(TenantData data) { }

    public static IEnumerable<TenantData> CreateTenantDatas() {
        yield return new(
            userId: new("Id", UserTestData.Users[0].ToString()),
            tenantId: new("Id", ExternalTenant.ToString()));
    }
}
