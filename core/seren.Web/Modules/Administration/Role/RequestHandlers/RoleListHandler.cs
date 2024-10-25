using MyRow = seren.Administration.RoleRow;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<seren.Administration.RoleRow>;


namespace seren.Administration;

public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}