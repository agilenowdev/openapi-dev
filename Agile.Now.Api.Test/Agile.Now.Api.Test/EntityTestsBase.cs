namespace Agile.Now.Api.Test; 

public abstract class EntityTestsBase<TId> {
    public abstract TId CreateInternal();
    public abstract void DeleteInternal(string id);
}

public abstract class EntityTestsBase<TResponseData, TId, TRequestData> : EntityTestsBase<TId> {
    protected readonly Attribute<TResponseData, TId, TRequestData> id;
    protected readonly TestData<TResponseData, TRequestData> testData;
    protected readonly Attribute<TResponseData, string, TRequestData>[] uniqueAttributes;

    public EntityTestsBase(
        Attribute<TResponseData, TId, TRequestData> id,
        TestData<TResponseData, TRequestData> testData,
        Attribute<TResponseData, string, TRequestData>[] uniqueAttributes) {

        this.id = id;
        this.testData = testData;
        this.uniqueAttributes = uniqueAttributes;
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
