namespace Agile.Now.Api.Test; 

public abstract class EntityTestsBase<TReadDataId> {
    public abstract TReadDataId CreateInternal();
    public abstract void DeleteInternal(string id);
}

public abstract class EntityTestsBase<TReadData, TReadDataId, TInsertData, TUpdateData, TUpsertData, TPatchData>
    : EntityTestsBase<TReadDataId>

    where TUpdateData : class
    where TUpsertData : class {

    protected readonly Attribute<TReadData, TReadDataId, TInsertData> id;
    protected readonly TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData> testData;
    protected readonly Attribute<TReadData, string, TInsertData>[] uniqueAttributes;

    public EntityTestsBase(
        Attribute<TReadData, TReadDataId, TInsertData> id,
        TestData<TReadData, TInsertData, TUpdateData, TUpsertData, TPatchData> testData,
        Attribute<TReadData, string, TInsertData>[] uniqueAttributes) {

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
