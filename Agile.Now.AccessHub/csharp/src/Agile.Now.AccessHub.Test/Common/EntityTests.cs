using System;
using Agile.Now.AccessHub.Client;
using Xunit;

namespace Agile.Now.AccessHub.Test.Common {
    public abstract class EntityTestsBase {
        public abstract void Test_Create();
        public abstract void Test_Create_WithUniqueAttributes();
        public abstract void Test_Delete_ById();
        public abstract void Test_Delete_ByUniqueAttributes();
        public abstract void Test_Get_ById();
        public abstract void Test_Get_ByUniqueAttributes();
        public abstract void Test_Update_ById();
        public abstract void Test_Update_ByUniqueAttributes();
        public abstract void Test_Upsert();
    }

    public abstract class EntityTestsBase<TId> : EntityTestsBase {
        public abstract TId CreateInternal();
        public abstract void DeleteInternal(string id);
    }

    public abstract class EntityTestsBase<TReadData, TId, TInsertData, TUpdateData, TUpsertData> : EntityTestsBase<TId> {
        protected readonly Attribute<TReadData, TId, TInsertData> id;
        protected readonly TestData<TReadData, TInsertData, TUpdateData, TUpsertData> testData;

        public EntityTestsBase(
            Attribute<TReadData, TId, TInsertData> id,
            TestData<TReadData, TInsertData, TUpdateData, TUpsertData> testData) {
            this.id = id;
            this.testData = testData;
        }
    }

    public class EntityTests<TReadData, TId, TInsertData, TUpdateData, TUpsertData>
        : EntityTestsBase<TReadData, TId, TInsertData, TUpdateData, TUpsertData> {

        readonly Attribute<TReadData, string, TInsertData>[] uniqueAttributes;

        public readonly Func<TInsertData, TReadData> Create;
        public readonly Action<string, string> Delete;
        public readonly Func<string, string, TReadData> Get;
        public readonly Func<string, TUpdateData, string, TReadData> Update;
        public readonly Func<TUpsertData, TReadData> Upsert;

        public EntityTests(
            Attribute<TReadData, TId, TInsertData> id,
            TestData<TReadData, TInsertData, TUpdateData, TUpsertData> testData,
            Attribute<TReadData, string, TInsertData>[] uniqueAttributes = null,

            Func<TInsertData, TReadData> create = null,
            Action<string, string> delete = null,
            Func<string, string, TReadData> get = null,
            Func<string, TUpdateData, string, TReadData> update = null,
            Func<TUpsertData, TReadData> upsert = null)

            : base(id, testData) {

            this.uniqueAttributes = uniqueAttributes;

            Create = create;
            Delete = delete;
            Get = get;
            Update = update;
            Upsert = upsert;
        }

        public override TId CreateInternal() {
            var data = testData.GetInsertData();
            var created = Create(data);
            return id.Get(created);
        }

        public override void DeleteInternal(string id) {
            Delete(id, "Id");
        }

        public override void Test_Create() {
            var data = testData.GetInsertData();
            var created = Create(data);
            try {
                testData.AssertEqual(data, created);
            }
            finally {
                Delete(id.Get(created).ToString(), "Id");
            }
        }

        public override void Test_Create_WithUniqueAttributes() {
            foreach(var uniqueAttribute in uniqueAttributes) {
                var created = Create(testData.GetInsertData());
                try {
                    var data = testData.GetInsertData();
                    uniqueAttribute.Set(data, uniqueAttribute.Get(created));
                    Assert.Throws<ApiException>(() => Create(data));
                }
                finally {
                    Delete(id.Get(created).ToString(), "Id");
                }
            }
        }

        public override void Test_Delete_ById() {
            var created = Create(testData.GetInsertData());
            Delete(id.Get(created).ToString(), "Id");
            Assert.Throws<ApiException>(() => Get(id.Get(created).ToString(), ""));
        }

        public override void Test_Delete_ByUniqueAttributes() {
            foreach(var uniqueAttribute in uniqueAttributes) {
                var created = Create(testData.GetInsertData());
                Delete(uniqueAttribute.Get(created), uniqueAttribute.Name);
                Assert.Throws<ApiException>(() => Get(id.Get(created).ToString(), ""));
            }
        }

        public override void Test_Get_ById() {
            var created = Create(testData.GetInsertData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = Get(id.Get(created).ToString(), "Id");
                    Assert.Equal(id.Get(created), id.Get(existing));
                    return existing;
                }));
            }
            finally {
                Delete(id.Get(created).ToString(), "Id");
            }
        }

        public override void Test_Get_ByUniqueAttributes() {
            foreach(var uniqueAttribute in uniqueAttributes) {
                var created = Create(testData.GetInsertData());
                try {
                    Assert.Null(Record.Exception(() => {
                        var existing = Get(uniqueAttribute.Get(created), uniqueAttribute.Name);
                        Assert.Equal(id.Get(created), id.Get(existing));
                        return existing;
                    }));
                }
                finally {
                    Delete(id.Get(created).ToString(), "Id");
                }
            }
        }

        public override void Test_Update_ById() {
            var data = testData.GetInsertData();
            var created = Create(data);
            try {
                testData.Update(data);
                var updated = Update(id.Get(created).ToString(), testData.ToUpdateData(data), "Id");
                Assert.Equal(id.Get(created), id.Get(updated));
                testData.AssertEqual(data, updated);
            }
            finally {
                Delete(id.Get(created).ToString(), "Id");
            }
        }

        public override void Test_Update_ByUniqueAttributes() {
            var data = testData.GetInsertData();
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
                Delete(id.Get(created).ToString(), "Id");
            }
        }

        public override void Test_Upsert() {
            var data = testData.GetInsertData();
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
                Delete(id.Get(created).ToString(), "Id");
            }
        }
    }
}
