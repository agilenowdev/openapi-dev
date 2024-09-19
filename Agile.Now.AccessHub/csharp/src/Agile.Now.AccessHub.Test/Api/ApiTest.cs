using System;
using Agile.Now.AccessHub.Client;
using Xunit;

namespace Agile.Now.AccessHub.Test.Api {
    public class ApiTest {
        public readonly EntityTest Entity;

        public ApiTest(EntityTest entity) {
            Entity = entity;
        }
    }

    public abstract class EntityTest {
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

    public class EntityTest<TEntity, TId, TCreateData, TUpdateData, TUpsertData> : EntityTest {
        public readonly Attribute<TEntity, TId, TCreateData> Id;
        public readonly Func<TEntity, TId> UpdatedId;
        public readonly Attribute<TEntity, TId, TCreateData>[] UniqueAttributes;

        public readonly Methods<TEntity, TId, TCreateData, TUpdateData, TUpsertData> Methods;
        public readonly TestData<TEntity, TCreateData, TUpdateData, TUpsertData> TestData;

        public EntityTest(
            Attribute<TEntity, TId, TCreateData> id,
            Func<TEntity, TId> updatedId,
            Attribute<TEntity, TId, TCreateData>[] uniqueAttributes,
            Methods<TEntity, TId, TCreateData, TUpdateData, TUpsertData> methods,
            TestData<TEntity, TCreateData, TUpdateData, TUpsertData> testData) {

            Id = id;
            UpdatedId = updatedId;
            UniqueAttributes = uniqueAttributes;
            Methods = methods;
            TestData = testData;
        }

        public override void Test_Create() {
            var data = TestData.GetCreateData();
            var created = Methods.Create(data);
            try {
                TestData.AssertEqual(data, created);
            }
            finally {
                Methods.Delete(Id.Get(created), "Id");
            }
        }

        public override void Test_Create_WithUniqueAttributes() {
            foreach(var uniqueAttribute in UniqueAttributes) {
                var created = Methods.Create(TestData.GetCreateData());
                try {
                    var data = TestData.GetCreateData();
                    uniqueAttribute.Set(data, uniqueAttribute.Get(created).ToString());
                    Assert.Throws<ApiException>(() => Methods.Create(data));
                }
                finally {
                    Methods.Delete(Id.Get(created), "Id");
                }
            }
        }

        public override void Test_Delete_ById() {
            var created = Methods.Create(TestData.GetCreateData());
            Methods.Delete(Id.Get(created), "Id");
            Assert.Throws<ApiException>(() => Methods.Get(Id.Get(created), ""));
        }

        public override void Test_Delete_ByUniqueAttributes() {
            foreach(var uniqueAttribute in UniqueAttributes) {
                var created = Methods.Create(TestData.GetCreateData());
                Methods.Delete(uniqueAttribute.Get(created), uniqueAttribute.Name);
                Assert.Throws<ApiException>(() => Methods.Get(Id.Get(created), ""));
            }
        }

        public override void Test_Get_ById() {
            var created = Methods.Create(TestData.GetCreateData());
            try {
                Assert.Null(Record.Exception(() => {
                    var existing = Methods.Get(Id.Get(created), "Id");
                    Assert.Equal(Id.Get(created), UpdatedId(existing));
                    return existing;
                }));
            }
            finally {
                Methods.Delete(Id.Get(created), "Id");
            }
        }

        public override void Test_Get_ByUniqueAttributes() {
            foreach(var uniqueAttribute in UniqueAttributes) {
                var created = Methods.Create(TestData.GetCreateData());
                try {
                    Assert.Null(Record.Exception(() => {
                        var existing = Methods.Get(uniqueAttribute.Get(created), uniqueAttribute.Name);
                        Assert.Equal(Id.Get(created), UpdatedId(existing));
                        return existing;
                    }));
                }
                finally {
                    Methods.Delete(Id.Get(created), "Id");
                }
            }
        }

        public override void Test_Update_ById() {
            var data = TestData.GetCreateData();
            var created = Methods.Create(data);
            try {
                TestData.Update(data);
                var updated = Methods.Update(Id.Get(created), TestData.GetUpdateData(data), "Id");
                Assert.Equal(Id.Get(created), UpdatedId(updated));
                TestData.AssertEqual(data, updated);
            }
            finally {
                Methods.Delete(Id.Get(created), "Id");
            }
        }

        public override void Test_Update_ByUniqueAttributes() {
            var data = TestData.GetCreateData();
            var created = Methods.Create(data);
            try {
                foreach(var uniqueAttribute in UniqueAttributes) {
                    TestData.Update(data);
                    var updated = Methods.Update(
                        uniqueAttribute.Get(created), TestData.GetUpdateData(data), uniqueAttribute.Name);
                    Assert.Equal(Id.Get(created), UpdatedId(updated));
                    TestData.AssertEqual(data, updated);
                }
            }
            finally {
                Methods.Delete(Id.Get(created), "Id");
            }
        }

        public override void Test_Upsert() {
            var data = TestData.GetCreateData();
            var created = Methods.Upsert(TestData.GetUpsertData(data));
            try {
                TestData.AssertEqual(data, created);
                TestData.Update(data);
                Id.Set(data, Id.Get(created).ToString());
                var updated = Methods.Upsert(TestData.GetUpsertData(data));
                Assert.Equal(Id.Get(created), UpdatedId(updated));
                TestData.AssertEqual(data, updated);
            }
            finally {
                Methods.Delete(Id.Get(created), "Id");
            }
        }
    }

    public class Attribute<TEntity, TId, TCreateData> {
        public readonly string Name;
        public readonly Func<TEntity, TId> Get;
        public readonly Action<TCreateData, string> Set;

        public Attribute(string name, Func<TEntity, TId> get, Action<TCreateData, string> set) {
            this.Name = name;
            this.Get = get;
            this.Set = set;
        }
    }

    public class Methods<TEntity, TId, TCreateData, TUpdateData, TUpsertData> {
        public readonly Func<TCreateData, TEntity> Create;
        public readonly Action<TId, string> Delete;
        public readonly Func<TId, string, TEntity> Get;
        public readonly Func<TId, TUpdateData, string, TEntity> Update;
        public readonly Func<TUpsertData, TEntity> Upsert;

        public Methods(
            Func<TCreateData, TEntity> create,
            Action<TId, string> delete,
            Func<TId, string, TEntity> get,
            Func<TId, TUpdateData, string, TEntity> update,
            Func<TUpsertData, TEntity> upsert) {

            Create = create;
            Delete = delete;
            Get = get;
            Update = update;
            Upsert = upsert;
        }
    }

    public class TestData<TEntity, TCreateData, TUpdateData, TUpsertData> {
        public readonly Func<TCreateData> GetCreateData;
        public readonly Func<TCreateData, TUpdateData> GetUpdateData;
        public readonly Func<TCreateData, TUpsertData> GetUpsertData;
        public readonly Action<TCreateData> Update;
        public readonly Action<TCreateData, TEntity> AssertEqual;

        public TestData(
            Func<TCreateData> getCreateData,
            Func<TCreateData, TUpdateData> getUpdateData,
            Func<TCreateData, TUpsertData> getUpsertData,
            Action<TCreateData> update,
            Action<TCreateData, TEntity> assertEqual) {

            GetCreateData = getCreateData;
            GetUpdateData = getUpdateData;
            GetUpsertData = getUpsertData;
            Update = update;
            AssertEqual = assertEqual;
        }
    }
}
