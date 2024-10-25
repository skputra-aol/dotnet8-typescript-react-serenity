﻿import { MovieForm, MovieRow, MovieService } from '@/ServerTypes/MovieDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('seren.MovieDB.MovieDialog')
export class MovieDialog extends EntityDialog<MovieRow, any> {
    protected getFormKey() { return MovieForm.formKey; }
    protected getRowDefinition() { return MovieRow; }
    protected getService() { return MovieService.baseUrl; }

    protected form = new MovieForm(this.idPrefix);
}