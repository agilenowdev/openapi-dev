using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Client;
using Xunit;

namespace Agile.Now.AccessHub.Test.Common {
    public abstract class EntityTestsBase<TId> {
        public abstract TId CreateInternal();
        public abstract void DeleteInternal(string id);
    }

    public abstract class EntityTestsBase<TReadData, TId, TInsertData, TUpdateData, TUpsertData, TPatchData> : EntityTestsBase<TId>
        where TUpdateData : class
        where TUpsertData : class {

        protected readonly Attribute<TReadData, TId, TInsertData> id;
        protected readonly TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData> testData;

        public EntityTestsBase(
            Attribute<TReadData, TId, TInsertData> id,
            TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData> testData) {
            this.id = id;
            this.testData = testData;
        }

        public abstract void Test_List_ById();
        public abstract void Test_List_ByUniqueAttributes();
        public abstract void Test_List_Paging();
        public abstract void Test_Get_ById();
        public abstract void Test_Get_ByUniqueAttributes();
        public abstract void Test_Create();
        public abstract void Test_Create_WithUniqueAttributes();
        public abstract void Test_Update_ById();
        public abstract void Test_Update_WithUniqueAttributes();
        public abstract void Test_Update_ByUniqueAttributes();
        public abstract void Test_Upsert();
        public abstract void Test_Patch();
        public abstract void Test_Delete_ById();
        public abstract void Test_Delete_ByUniqueAttributes();
    }

    public class EntityTests<TReadData, TId, TInsertData, TUpdateData, TUpsertData, TPatchData>
        : EntityTestsBase<TReadData, TId, TInsertData, TUpdateData, TUpsertData, TPatchData>
        where TUpdateData : class
        where TUpsertData : class {

        readonly Attribute<TReadData, string, TInsertData>[] uniqueAttributes;

        public readonly Func<string, int, int, List<TReadData>> List;
        public readonly Func<string, string, TReadData> Get;
        public readonly Func<TInsertData, TReadData> Create;
        public readonly Func<string, TUpdateData, string, TReadData> Update;
        public readonly Func<TUpsertData, TReadData> Upsert;
        public readonly Action<string, string> Delete;

        public EntityTests(
            Attribute<TReadData, TId, TInsertData> id,
            TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData> testData,
            Attribute<TReadData, string, TInsertData>[] uniqueAttributes = null,

            Func<string, int, int, List<TReadData>> list = null,
            Func<string, string, TReadData> get = null,
            Func<TInsertData, TReadData> create = null,
            Func<string, TUpdateData, string, TReadData> update = null,
            Func<TUpsertData, TReadData> upsert = null,
            Action<string, string> delete = null)

            : base(id, testData) {

            this.uniqueAttributes = uniqueAttributes;

            List = list;
            Get = get;
            Create = create;
            Update = update;
            Upsert = upsert;
            Delete = delete;
        }

        public override TId CreateInternal() => id.Get(Create(testData.GetInsertData().First()));

        public override void DeleteInternal(string id) => Delete(id, this.id.Name);

        public override void Test_List_ById() {
            var created = testData.GetInsertData().Take(2).Select(i => Create(i)).ToArray();
            try {
                var existing = List(
                    $"{id.Name} In {string.Join(id.GetSeparator(), created.Select(i => id.Get(i)))}", 0, 50);
                Assert.Equal(created.Length, existing.Count);
            }
            finally {
                foreach(var i in created)
                    Delete(id.Get(i).ToString(), id.Name);
            }
        }

        public override void Test_List_ByUniqueAttributes() {
            var created = testData.GetInsertData().Take(2).Select(i => Create(i)).ToArray();
            try {
                foreach(var uniqueAttribute in uniqueAttributes) {
                    var existing = List(
                        $"{uniqueAttribute.Name} In {string.Join(uniqueAttribute.GetSeparator(), created.Select(i => uniqueAttribute.Get(i)))}",
                        0, 50);
                    Assert.Equal(created.Length, existing.Count);
                }
            }
            finally {
                foreach(var i in created)
                    Delete(id.Get(i).ToString(), id.Name);
            }
        }

        public override void Test_List_Paging() {
            var created = testData.GetInsertData().Take(3).Select(i => Create(i)).ToArray();
            try {
                var filters = $"{id.Name} In {string.Join(id.GetSeparator(), created.Select(i => id.Get(i)))}";
                var pageSize = 2;
                var pages = new[] {
                    List(filters, 0, pageSize),
                    List(filters, 1, pageSize),
                };
                Assert.Equal(pageSize, pages[0].Count);
                Assert.Equal(1, pages[1].Count);
                Assert.Equal(created.Length, pages[0].Concat(pages[1]).GroupBy(i => id.Get(i)).Count());
            }
            finally {
                foreach(var i in created)
                    Delete(id.Get(i).ToString(), id.Name);
            }
        }

        public override void Test_Get_ById() {
            var created = Create(testData.GetInsertData().First());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = Get(id.Get(created).ToString(), id.Name);
                    Assert.Equal(id.Get(created), id.Get(existing));
                    return existing;
                }));
            }
            finally {
                Delete(id.Get(created).ToString(), id.Name);
            }
        }

        public override void Test_Get_ByUniqueAttributes() {
            var created = Create(testData.GetInsertData().First());
            try {
                foreach(var uniqueAttribute in uniqueAttributes) {
                    Assert.Null(Record.Exception(() => {
                        var existing = Get(uniqueAttribute.Get(created), uniqueAttribute.Name);
                        Assert.Equal(id.Get(created), id.Get(existing));
                        return existing;
                    }));
                }
            }
            finally {
                Delete(id.Get(created).ToString(), id.Name);
            }
        }

        public override void Test_Create() {
            var data = testData.GetInsertData().First();
            var created = Create(data);
            try {
                testData.AssertEqual(data, created);
            }
            finally {
                Delete(id.Get(created).ToString(), id.Name);
            }
        }

        public override void Test_Create_WithUniqueAttributes() {
            var created = Create(testData.GetInsertData().First());
            try {
                foreach(var uniqueAttribute in uniqueAttributes) {
                    var data = testData.GetInsertData().First();
                    uniqueAttribute.Set(data, uniqueAttribute.Get(created));
                    Assert.Throws<ApiException>(() => Create(data));
                }
            }
            finally {
                Delete(id.Get(created).ToString(), id.Name);
            }
        }

        public override void Test_Update_ById() {
            var data = testData.GetInsertData().First();
            var created = Create(data);
            try {
                testData.Update(data);
                var updated = Update(id.Get(created).ToString(), testData.ToUpdateData(data), id.Name);
                Assert.Equal(id.Get(created), id.Get(updated));
                testData.AssertEqual(data, updated);
            }
            finally {
                Delete(id.Get(created).ToString(), id.Name);
            }
        }

        public override void Test_Update_WithUniqueAttributes() {
            var created = Create(testData.GetInsertData().First());
            try {
                var data = testData.GetInsertData().First();
                var toUpdate = Create(data);
                try {
                    foreach(var uniqueAttribute in uniqueAttributes) {
                        data = testData.GetInsertData().First();
                        uniqueAttribute.Set(data, uniqueAttribute.Get(created));
                        Assert.Throws<ApiException>(() =>
                        Update(id.Get(toUpdate).ToString(), testData.ToUpdateData(data), id.Name));
                    }
                }
                finally {
                    Delete(id.Get(toUpdate).ToString(), id.Name);
                }
            }
            finally {
                Delete(id.Get(created).ToString(), id.Name);
            }
        }

        public override void Test_Update_ByUniqueAttributes() {
            var data = testData.GetInsertData().First();
            var created = Create(data);
            try {
                foreach(var uniqueAttribute in uniqueAttributes) {
                    testData.Update(data);
                    var updated = Update(
                        uniqueAttribute.Get(created), testData.ToUpdateData(data), uniqueAttribute.Name);
                    Assert.Equal(id.Get(created), id.Get(updated));
                    testData.AssertEqual(data, updated);
                }
            }
            finally {
                Delete(id.Get(created).ToString(), id.Name);
            }
        }

        public override void Test_Upsert() {
            var data = testData.GetInsertData().First();
            var created = Upsert(testData.ToUpsertData(data));
            try {
                testData.AssertEqual(data, created);
                testData.Update(data);
                id.Set(data, id.Get(created));
                var updated = Upsert(testData.ToUpsertData(data));
                Assert.Equal(id.Get(created), id.Get(updated));
                testData.AssertEqual(data, updated);
            }
            finally {
                Delete(id.Get(created).ToString(), id.Name);
            }
        }

        public override void Test_Patch() {
            throw new NotImplementedException();
        }

        public override void Test_Delete_ById() {
            var created = Create(testData.GetInsertData().First());
            Delete(id.Get(created).ToString(), id.Name);
            Assert.Throws<ApiException>(() => Get(id.Get(created).ToString(), ""));
        }

        public override void Test_Delete_ByUniqueAttributes() {
            foreach(var uniqueAttribute in uniqueAttributes) {
                var created = Create(testData.GetInsertData().First());
                Delete(uniqueAttribute.Get(created), uniqueAttribute.Name);
                Assert.Throws<ApiException>(() => Get(id.Get(created).ToString(), ""));
            }
        }
    }
}
