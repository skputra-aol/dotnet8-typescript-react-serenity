import { MovieColumns, MovieRow, MovieService } from '@/ServerTypes/MovieDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { MovieDialog } from './MovieDialog';

import { QuickSearchField } from '@serenity-is/corelib'; //(#createdropdownlist)
import { localText } from '@serenity-is/corelib'; //(#createdropdownlist)

@Decorators.registerClass('seren.MovieDB.MovieGrid')
export class MovieGrid extends EntityGrid<MovieRow> {
    protected getColumnsKey() { return MovieColumns.columnsKey; }
    protected getDialogType() { return MovieDialog; }
    protected getRowDefinition() { return MovieRow; }
    protected getService() { return MovieService.baseUrl; }

    //Begin-create dropdown list search by field name (#createdropdownlist)
    // note : dotnet sergen t (https://serenity.is/docs/tutorials/movies/05-customizing-quick-search)
    protected getQuickSearchFields(): QuickSearchField[] {
        const txt = s => localText(`Db.${MovieRow.localTextPrefix}.${s}`);
        const fld = MovieRow.Fields;
        return [
            { name: "", title: "All" },
            { name: fld.Description, title: txt(fld.Description) },
            { name: fld.Storyline, title: txt(fld.Storyline) },
            { name: fld.Year, title: txt(fld.Year) }
        ];
    }
    //End
}