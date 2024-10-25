using MyRow = seren.Administration.LanguageRow;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<seren.Administration.LanguageRow>;


namespace seren.Administration;

public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
{
    public LanguageRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}