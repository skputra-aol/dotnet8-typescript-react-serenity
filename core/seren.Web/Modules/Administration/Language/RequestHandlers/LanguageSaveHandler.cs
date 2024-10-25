﻿using MyRow = seren.Administration.LanguageRow;
using MyRequest = Serenity.Services.SaveRequest<seren.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;


namespace seren.Administration;

public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}