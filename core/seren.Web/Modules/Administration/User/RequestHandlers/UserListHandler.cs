using MyRow = seren.Administration.UserRow;
using MyRequest = seren.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<seren.Administration.UserRow>;

namespace seren.Administration;

public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}