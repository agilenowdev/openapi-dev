using Xunit;

namespace Agile.Now.Api.Test;

public class SubEntityTests<TParentResponse, TParentId, TParentRequest, TResponse, TId, TRequest>
    : EntityTestsBase<TResponse, TId, TRequest> {

    protected readonly EntityTests<TParentResponse, TParentId, TParentRequest> Parent;

    public SubEntityTests(
        EntityTests<TParentResponse, TParentId, TParentRequest> parent,
        TestData<TResponse, TRequest> testData,
        Attribute<TResponse, TId, TRequest> id,
        Attribute<TResponse, string, TRequest>[] uniqueAttributes = null)

        : base(testData, id, uniqueAttributes) {

        Parent = parent;
    }

    public virtual string EntityName => typeof(TResponse).Name;

    protected virtual List<TResponse> List(
        string id, string name, string filters, string orders, int currentPage, int pageSize) => default;

    protected virtual TResponse Upsert(TParentId id, TRequest data) => default;
    protected virtual TResponse[] Patch(TParentId id, List<TRequest> data, string deleteNotExists) => default;
    protected virtual TResponse Delete(string id, string subId, string name, string subName) => default;

    public TResponse[] GenerateEntities(TParentId id, int count) =>
        testData.GenerateRequestData().Take(count).Select(i => Upsert(id, i)).ToArray();

    public void Delete(TParentResponse parentEntity, params TResponse[] entities) {
        foreach(var i in entities)
            Delete(
                Parent.Id.Get(parentEntity).ToString(),
                Id.Get(i).ToString(),
                Parent.Id.Name,
                $"{EntityName}{Id.Name}");
    }

    public void Test_List<TValue>(params Attribute<TResponse, TValue, TRequest>[] attributes) {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        try {
            var created = GenerateEntities(id, 2);
            try {
                foreach(var i in attributes) {
                    var filters = i.CreateFilters(created);
                    if(i.Name == "Id")
                        filters = EntityName + filters;
                    var existing = List(id.ToString(), Parent.Id.Name, filters, null, 0, DefaultPageSize);
                    AssertCollectionsEqual(created, existing);
                }
            }
            finally {
                Delete(parentEntity, created);
            }
        }
        finally {
            Parent.Delete(parentEntity);
        }
    }

    public void Test_List_ById() => Test_List(Id);
    public void Test_List_ByUniqueAttributes() => Test_List(uniqueAttributes);

    public void Test_List_Paging() {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        try {
            var created = GenerateEntities(id, 3);
            try {
                var pageSize = 2;
                var pages = new[] {
                    List(id.ToString(), Parent.Id.Name, null, null, 0, pageSize),
                    List(id.ToString(), Parent.Id.Name, null, null, 1, pageSize),
            };
                Assert.Equal(pageSize, pages[0].Count);
                Assert.Equal(1, pages[1].Count);
                Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => Id.Get(i)).Count());
            }
            finally {
                Delete(parentEntity, created);
            }
        }
        finally {
            Parent.Delete(parentEntity);
        }
    }

    void Test_List_Order(Func<IEnumerable<TId>, IOrderedEnumerable<TId>> f, string order) {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);

        try {
            var created = GenerateEntities(id, 3);
            try {
                var actual = List(
                    id.ToString(), Parent.Id.Name,
                    EntityName + Id.CreateFilters(created),
                    $"{EntityName}{Id.Name} {order}",
                    0, created.Length);
                var expected = f(created.Select(i => Id.Get(i))).ToArray();
                Assert.True(actual.Select(i => Id.Get(i)).SequenceEqual(expected));
            }
            finally {
                Delete(parentEntity, created);
            }
        }
        finally {
            Parent.Delete(parentEntity);
        }
    }

    public void Test_List_OrderAscending() => Test_List_Order(x => x.Order(), "ASC");
    public void Test_List_OrderDecending() => Test_List_Order(x => x.OrderDescending(), "DESC");

    public void Test_Upsert() {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        try {
            var data = testData.GenerateRequestData().First();
            var created = Upsert(id, data);
            try {
                testData.AssertEqualToRequest(data, created);
                var upserted = Upsert(id, data);
                Assert.Equal(Id.Get(created), Id.Get(upserted));
            }
            finally {
                Delete(parentEntity, created);
            }
        }
        finally {
            Parent.Delete(parentEntity);
        }
    }

    public void Test_Patch() {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        try {
            var data = testData.GenerateRequestData().Take(3).ToArray();
            var created = data.Take(2).Select(i => Upsert(id, i)).ToArray();
            try {
                var patched = Patch(id, data.Skip(1).Take(2).ToList(), null);
                created = created.UnionBy(patched, i => Id.Get(i)).ToArray();
                try {
                    var existing = List(id.ToString(), Parent.Id.Name, null, null, 0, DefaultPageSize);
                    AssertCollectionsEqual(existing, created);
                }
                finally {
                    Delete(parentEntity, created);
                }
            }
            finally {
                Delete(parentEntity, created);
            }
        }
        finally {
            Parent.Delete(parentEntity);
        }
    }

    public void Test_Patch_DeleteNotExists() {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        try {
            var data = testData.GenerateRequestData().Take(3).ToArray();
            var created = data.Take(2).Select(i => Upsert(id, i)).ToArray();
            try {
                var patched = Patch(id, data.Skip(1).Take(2).ToList(), true.ToString());
                try {
                    var existing = List(id.ToString(), Parent.Id.Name, null, null, 0, DefaultPageSize);
                    AssertCollectionsEqual(existing, patched);
                }
                finally {
                    Delete(parentEntity, created);
                }
            }
            finally {
                Delete(parentEntity, created);
            }
        }
        finally {
            Parent.Delete(parentEntity);
        }
    }

    public void Test_Delete_ById() {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        try {
            var created = GenerateEntities(id, 1).First();
            var deleted = Delete(id.ToString(), Id.Get(created).ToString(), Parent.Id.Name, $"{EntityName}{Id.Name}");
            testData.AssertEqualToResponse(created, deleted);
            var existing = List(id.ToString(), Parent.Id.Name, null, null, 0, DefaultPageSize);
            Assert.Empty(existing);
        }
        finally {
            Parent.Delete(parentEntity);
        }
    }

    public void Test_Delete_ByUniqueAttributes() {
        var parentEntity = Parent.GenerateEntity();
        var id = Parent.Id.Get(parentEntity);
        try {
            foreach(var i in uniqueAttributes) {
                var created = GenerateEntities(id, 1).First();
                Delete(id.ToString(), i.Get(created), Parent.Id.Name, i.Name);
                var existing = List(id.ToString(), Parent.Id.Name, null, null, 0, DefaultPageSize);
                Assert.Empty(existing);
            }
        }
        finally {
            Parent.Delete(parentEntity);
        }
    }
}
