using MyRow = seren.Administration.LanguageRow;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;


namespace seren.Administration;

public interface ILanguageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageDeleteHandler
{
    public LanguageDeleteHandler(IRequestContext context)
         : base(context)
    {
    }
}