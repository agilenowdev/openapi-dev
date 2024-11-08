namespace Agile.Now.Api.Test;

public class Context<TParentResponse, TParentRequest> : IDisposable {
    public readonly EntityTestsBase<TParentResponse, TParentRequest, TParentResponse, TParentRequest> Parent;
    public string ParentId;
    bool IsCleanUp;

    public Context(EntityTests<TParentResponse, TParentRequest> parent, string parentId = default) {
        Parent = parent;
        if(Parent == null)
            return;
        ParentId = parentId;
        if(ParentId == null) {
            ParentId = Parent.Id.Get(parent.GenerateEntity(null));
            IsCleanUp = Parent.IsCleanUp;
        }
    }

    public void Dispose() {
        if(IsCleanUp)
            Parent?.Delete(null, ParentId);
    }
}
