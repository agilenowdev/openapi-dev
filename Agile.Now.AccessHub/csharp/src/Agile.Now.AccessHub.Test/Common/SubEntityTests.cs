using System;
using System.Collections.Generic;
using Xunit;

namespace Agile.Now.AccessHub.Test.Common;

public class SubEntityTests<TParentEntityId, TReadData, TId, TInsertData, TUpdateData, TUpsertData>
    : EntityTestsBase<TReadData, TId, TInsertData, TUpdateData, TUpsertData> {

    readonly EntityTestsBase<TParentEntityId> parent;

    public readonly Action<TParentEntityId, TId> Delete;
    public readonly Func<TParentEntityId, List<TReadData>> List;
    public readonly Func<TParentEntityId, TUpsertData, TReadData> Upsert;

    public SubEntityTests(
        EntityTestsBase<TParentEntityId> parent,
        Attribute<TReadData, TId, TInsertData> id,
        Action<TParentEntityId, TId> delete = null,
        Func<TParentEntityId, List<TReadData>> list = null,
        Func<TParentEntityId, TUpsertData, TReadData> upsert = null,
        TestData<TReadData, TInsertData, TUpdateData, TUpsertData> testData = null)

        : base(id, testData) {

        this.parent = parent;

        Delete = delete;
        List = list;
        Upsert = upsert;
    }

    public override TId CreateInternal() {
        throw new NotImplementedException();
    }

    public override void DeleteInternal(string id) {
        throw new NotImplementedException();
    }

    public override void Test_Create() {
        throw new NotImplementedException();
    }

    public override void Test_Create_WithUniqueAttributes() {
        throw new NotImplementedException();
    }

    public override void Test_Delete_ById() {
        throw new NotImplementedException();
    }

    public override void Test_Delete_ByUniqueAttributes() {
        throw new NotImplementedException();
    }

    public override void Test_Get_ById() {
        throw new NotImplementedException();
    }

    public override void Test_Get_ByUniqueAttributes() {
        throw new NotImplementedException();
    }

    public override void Test_Update_ById() {
        throw new NotImplementedException();
    }

    public override void Test_Update_ByUniqueAttributes() {
        throw new NotImplementedException();
    }

    public override void Test_Upsert() {
        throw new NotImplementedException();
    }

    public void Test_Delete() {
        var entity = parent.CreateInternal();
        try {
            var created = Upsert(entity, testData.ToUpsertData(testData.GetInsertData()));
            Delete(entity, id.Get(created));
            var existing = List(entity);
            Assert.Empty(existing);
        }
        finally {
            parent.DeleteInternal(entity.ToString());
        }
    }
}
