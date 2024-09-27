using Xunit;

namespace Agile.Now.Api.Test;

public class SubEntityTests<TParentId, TResponseData, TId, TRequestData>
    : EntityTestsBase<TResponseData, TId, TRequestData> {

    readonly EntityTestsBase<TParentId> parent;

    public readonly Action<TParentId, TId> Delete;
    public readonly Func<TParentId, List<TResponseData>> List;
    public readonly Func<TParentId, TRequestData, TResponseData> Upsert;
    public readonly Func<TParentId, List<TRequestData>, IEnumerable<TResponseData>> Patch;

    public SubEntityTests(
        EntityTestsBase<TParentId> parent,
        Attribute<TResponseData, TId, TRequestData> id,
        TestData<TResponseData, TRequestData> testData,
        Attribute<TResponseData, string, TRequestData>[] uniqueAttributes = null,

        Func<TParentId, List<TResponseData>> list = null,
        Func<TParentId, TRequestData, TResponseData> upsert = null,
        Func<TParentId, List<TRequestData>, IEnumerable<TResponseData>> patch = null,
        Action<TParentId, TId> delete = null)

        : base(id, testData, uniqueAttributes) {

        this.parent = parent;

        List = list;
        Upsert = upsert;
        Patch = patch;
        Delete = delete;
    }

    public override TId CreateInternal() => default;
    public override void DeleteInternal(string id) { }

    public override void Test_List_ById() {
        var entityId = parent.CreateInternal();
        try {
            var created = testData.GenerateInsertData().Take(2).Select(i => Upsert(entityId, i)).ToArray();
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
            var created = Upsert(entityId, testData.GenerateInsertData().First());
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
            var created = Upsert(entityId, data[0]);
            try {
                var patched = Patch(entityId, new[] { data[1] }.ToList()).ToArray();
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
            var created = Upsert(entity, testData.GenerateInsertData().First());
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
