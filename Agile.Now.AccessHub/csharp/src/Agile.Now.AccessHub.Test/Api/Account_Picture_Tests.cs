using System.Collections.Generic;
using System.Net.Http;
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
            testData: new Picture_TestData()) {

        api = new AccountsApi(Settings.Connections[0]);
    }

    protected override List<Picture> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) =>

        api.ListAccountPictures(
            id: id, name: name, filters: filters, orders: orders, currentPage: currentPage, pageSize: pageSize).Data;

    //protected override Picture Upsert(string id, PictureData data) => api.UpsertAccountPicture(id, data);

    protected override Picture Delete(string id, string subId, string name, string subName) =>
        api.DeleteAccountPicture(id, subId, subName: subName);

    //[Fact] public void Test_Account_Picture_List_ById() => Test_List_ById();

    [Fact]
    public async void Test_Account_Picture_List_ById() {
        var existingSubEntities = (await api.ListAccountPicturesAsync("ee825d23-c105-4274-9229-d1df34e1cbde")).Data;
    }

    //[Fact] public void Test_Account_Picture_Upsert() => Test_Upsert();
    [Fact] public void Test_Account_Picture_Delete_ById() => Test_Delete_ById();

    [Fact]
    public void Test_AccountPicture_Upsert() {
        var inputData = Picture_TestData.PictureData.ToStream();
        var created = api.UpsertAccountPicture("ee825d23-c105-4274-9229-d1df34e1cbde",
            inputData);
    }
}
