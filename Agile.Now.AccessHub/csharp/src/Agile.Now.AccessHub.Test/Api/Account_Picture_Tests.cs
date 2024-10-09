using System.Collections.Generic;
using Agile.Now.AccessHub.Api;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Common;
using Agile.Now.Api.Test;
using Agile.Now.ApiAccounts.Test.Api;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api;

public class Account_Picture_Tests : SubEntityTests<Account, string, AccountInsertData, Picture, int, PictureData> {
    readonly AccountsApi api;

    public Account_Picture_Tests()
        : base(new Account_Tests(),
            id: null,
            testData: new Account_Picture_TestData()) {

        api = new AccountsApi(Settings.Connections[0]);
    }

    protected override List<Picture> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListAccountPictures(id).Data;

    protected override Picture Upsert(string id, PictureData data) => api.UpsertAccountPicture(id, data);

    protected override Picture Delete(string id, string subId, string name, string subName) =>
        api.DeleteAccountPicture(id, subId, subName: subName);

    [Fact] public void Test_Account_Picture_List_ById() => Test_List_ById();
    [Fact] public void Test_Account_Picture_List_ByUniqueAttributes() => Test_List_ByUniqueAttributes();
    [Fact] public void Test_Account_Picture_List_Paging() => Test_List_Paging();
    [Fact] public void Test_Account_Picture_List_OrderAscending() => Test_List_OrderAscending();
    [Fact] public void Test_Account_Picture_List_OrderDecending() => Test_List_OrderDecending();

    [Fact] public void Test_Account_Picture_Upsert() => Test_Upsert();

    [Fact] public void Test_Account_Picture_Delete_ById() => Test_Delete_ById();
    [Fact] public void Test_Location_User_Delete_ByUniqueAttributes() => Test_Delete_ByUniqueAttributes();

    

    [Fact]
    public async void Test_AccountPicture_Upsert() {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        //try {
        //    var createdSubEntity = await api.UpsertAccountPictureAsync(created.Id,
        //        new(Account_Picture_TestData.PictureData.ToStream()), name: "AccountId");
        //    try {
        //        var existingSubEntities = api.ListAccountPictures(created.Id).Data;
        //        Assert.Contains(existingSubEntities, i => i.Filename == createdSubEntity.Filename);
        //    }
        //    finally {
        //        api.DeleteAccountPicture(created.Id, null);
        //    }
        //}
        //finally {
        //    api.DeleteAccount(created.Id);
        //}
    }
}
