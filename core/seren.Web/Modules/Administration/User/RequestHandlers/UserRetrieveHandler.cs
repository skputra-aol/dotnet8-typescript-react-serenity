﻿using MyRow = seren.Administration.UserRow;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<seren.Administration.UserRow>;


namespace seren.Administration;

public interface IUserRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class UserRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserRetrieveHandler
{
    public UserRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}