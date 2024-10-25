﻿using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = seren.MovieDB.MovieRow;

namespace seren.MovieDB;

public interface IMovieDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class MovieDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieDeleteHandler
{
    public MovieDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}