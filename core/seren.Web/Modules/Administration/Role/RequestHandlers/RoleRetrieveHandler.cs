using MyRow = seren.Administration.RoleRow;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<seren.Administration.RoleRow>;


namespace seren.Administration;

public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    public RoleRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}