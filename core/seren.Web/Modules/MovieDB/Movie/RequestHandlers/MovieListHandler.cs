using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<seren.MovieDB.MovieRow>;
using MyRow = seren.MovieDB.MovieRow;

namespace seren.MovieDB;

public interface IMovieListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
{
    public MovieListHandler(IRequestContext context)
            : base(context)
    {
    }
}