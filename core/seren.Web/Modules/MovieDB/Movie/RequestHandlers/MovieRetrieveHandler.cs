using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<seren.MovieDB.MovieRow>;
using MyRow = seren.MovieDB.MovieRow;

namespace seren.MovieDB;

public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
{
    public MovieRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}