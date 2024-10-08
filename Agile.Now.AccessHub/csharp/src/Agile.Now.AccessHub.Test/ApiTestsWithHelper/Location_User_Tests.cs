using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiOrganizations.Test.Api;
using Xunit;

namespace Agile.Now.AccessHub.Test.ApiTestsWithHelper;

public class Location_User_Tests : SubEntityTests<string, User, int, UserData> {
    readonly LocationsApi api;

    public Location_User_Tests()
        : base(new Location_Tests(),
            id: new(nameof(User.Id), entity => entity.Id, null),
            testData: new LocationUserTestData()) {

        api = new LocationsApi(Settings.Connections[0]);
    }

    protected override List<User> List(string id) => api.ListLocationUsers(id).Data;
    protected override User Upsert(string id, UserData data) => api.UpsertLocationUser(id, data);
    protected override void Delete(string id, int subId) => api.DeleteLocationUser(id, subId.ToString(), subName: "UserId");

    [Fact] public void Test_Location_User_List_ById() => Test_List_ById();
    [Fact] public void Test_Location_User_Upsert() => Test_Upsert();
    [Fact] public void Test_Location_User_Delete() => Test_Delete_ById();
}
