using Xunit;

namespace Agile.Now.Api.Test;

public class SubEntityTests<TParentId, TResponse, TId, TRequest> : EntityTestsBase<TResponse, TId, TRequest> {
    readonly EntityTestsBase<TParentId> parent;

    public SubEntityTests(
        EntityTestsBase<TParentId> parent,
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TId, TRequest> id,
        Attribute<TResponse, string, TRequest>[] uniqueAttributes = null)

        : base(testData, id, uniqueAttributes) {

        this.parent = parent;
    }

    protected virtual List<TResponse> List(TParentId id) => default;
    protected virtual TResponse Upsert(TParentId id, TRequest data) => default;
    protected virtual IEnumerable<TResponse> Patch(TParentId id, List<TRequest> data) => default;
    protected virtual void Delete(TParentId id, TId subId) { }

    public override TId CreateInternal() => default;
    public override void DeleteInternal(string id) { }

    public void Test_List_ById() {
        var entityId = parent.CreateInternal();
        try {
            var created = testData.GenerateRequestData().Take(2).Select(i => Upsert(entityId, i)).ToArray();
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

    public void Test_Upsert() {
        var entityId = parent.CreateInternal();
        try {
            var created = Upsert(entityId, testData.GenerateRequestData().First());
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

    public void Test_Patch() {
        var entityId = parent.CreateInternal();
        try {
            var data = testData.GenerateRequestData().Take(2).ToArray();
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

    public void Test_Delete_ById() {
        var entity = parent.CreateInternal();
        try {
            var created = Upsert(entity, testData.GenerateRequestData().First());
            Delete(entity, id.Get(created));
            var existing = List(entity);
            Assert.Empty(existing);
        }
        finally {
            parent.DeleteInternal(entity.ToString());
        }
    }

    public void Test_Create() {
        throw new NotImplementedException();
    }

    public void Test_List_ByUniqueAttributes() {
        throw new NotImplementedException();
    }

    public void Test_Create_WithUniqueAttributes() {
        throw new NotImplementedException();
    }

    public void Test_Delete_ByUniqueAttributes() {
        throw new NotImplementedException();
    }

    public void Test_Get_ById() {
        throw new NotImplementedException();
    }

    public void Test_Get_ByUniqueAttributes() {
        throw new NotImplementedException();
    }

    public void Test_Update_ById() {
        throw new NotImplementedException();
    }

    public void Test_Update_ByUniqueAttributes() {
        throw new NotImplementedException();
    }

    public void Test_Update_WithUniqueAttributes() {
        throw new NotImplementedException();
    }

    public void Test_List_Paging() {
        throw new NotImplementedException();
    }
}
