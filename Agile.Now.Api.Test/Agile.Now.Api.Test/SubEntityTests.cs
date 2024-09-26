using Xunit;

namespace Agile.Now.Api.Test;

public class SubEntityTests<TParentId, TReadData, TReadDataId, TInsertData, TUpdateData, TUpsertData, TPatchData>
    : EntityTestsBase<TReadData, TReadDataId, TInsertData, TUpdateData, TUpsertData, TPatchData>
        where TInsertData : class
        where TUpdateData : class
        where TUpsertData : class {

    readonly EntityTestsBase<TParentId> parent;

    public readonly Action<TParentId, TReadDataId> Delete;
    public readonly Func<TParentId, List<TReadData>> List;
    public readonly Func<TParentId, TUpsertData, TReadData> Upsert;
    public readonly Func<TParentId, List<TPatchData>, IEnumerable<TReadData>> Patch;

    public SubEntityTests(
        EntityTestsBase<TParentId> parent,
        Attribute<TReadData, TReadDataId, TInsertData> id,
        TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData> testData,
        Attribute<TReadData, string, TInsertData>[] uniqueAttributes = null,

        Func<TParentId, List<TReadData>> list = null,
        Func<TParentId, TUpsertData, TReadData> upsert = null,
        Func<TParentId, List<TPatchData>, IEnumerable<TReadData>> patch = null,
        Action<TParentId, TReadDataId> delete = null)

        : base(id, testData, uniqueAttributes) {

        this.parent = parent;

        List = list;
        Upsert = upsert;
        Patch = patch;
        Delete = delete;
    }

    public override TReadDataId CreateInternal() => default;
    public override void DeleteInternal(string id) { }

    public override void Test_List_ById() {
        var entityId = parent.CreateInternal();
        try {
            var created = testData.GenerateInsertData().Take(2).Select(i => Upsert(entityId, testData.ToUpsertData(i))).ToArray();
            try {
                var existing = List(entityId);
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                foreach(var i in created)
                    Delete(entityId, id.Get(i));
            }
        }
        finally {
            parent.DeleteInternal(entityId.ToString());
        }
    }

    public override void Test_Upsert() {
        var entityId = parent.CreateInternal();
        try {
            var created = Upsert(entityId, testData.ToUpsertData(testData.GenerateInsertData().First()));
            try {
                var existing = List(entityId);
                Assert.Contains(existing, i => id.Get(i).Equals(id.Get(created)));
            }
            finally {
                Delete(entityId, id.Get(created));
            }
        }
        finally {
            parent.DeleteInternal(entityId.ToString());
        }
    }

    public override void Test_Patch() {
        var entityId = parent.CreateInternal();
        try {
            var data = testData.GenerateInsertData().Take(2).ToArray();
            var created = Upsert(entityId, testData.ToUpsertData(data[0]));
            try {
                var patched = Patch(entityId, new[] { testData.ToPatchData(data[1]) }.ToList()).ToArray();
                try {
                    Assert.Equal(1, patched.Length);
                    var existing = List(entityId);
                    Assert.Contains(existing, i => id.Get(i).Equals(id.Get(created)));
                    Assert.Contains(existing, i => id.Get(i).Equals(id.Get(patched[0])));
                }
                finally {
                    foreach(var i in patched)
                        Delete(entityId, id.Get(i));
                }
            }
            finally {
                Delete(entityId, id.Get(created));
            }
        }
        finally {
            parent.DeleteInternal(entityId.ToString());
        }
    }

    public override void Test_Delete_ById() {
        var entity = parent.CreateInternal();
        try {
            var created = Upsert(entity, testData.ToUpsertData(testData.GenerateInsertData().First()));
            Delete(entity, id.Get(created));
            var existing = List(entity);
            Assert.Empty(existing);
        }
        finally {
            parent.DeleteInternal(entity.ToString());
        }
    }

    public override void Test_Create() {
        throw new NotImplementedException();
    }

    public override void Test_List_ByUniqueAttributes() {
        throw new NotImplementedException();
    }

    public override void Test_Create_WithUniqueAttributes() {
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

    public override void Test_Update_WithUniqueAttributes() {
        throw new NotImplementedException();
    }

    public override void Test_List_Paging() {
        throw new NotImplementedException();
    }
}
