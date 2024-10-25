using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace seren.MovieDB;

[ConnectionKey("Default"), Module("MovieDB"), TableName("Movie")]
[DisplayName("Movie-TitleSaatDiGrid"), InstanceName("Movie-TitleBtnNTitlePageSaatAddEdit")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Movie Id"), Identity, IdProperty]
    public int? MovieId { get => fields.MovieId[this]; set => fields.MovieId[this] = value; }

    //[DisplayName("Title"), Size(200), NotNull, NameProperty, QuickSearch]
    [DisplayName("Title"), Size(200), NotNull, NameProperty, QuickSearch(SearchType.StartsWith)]  // start with string
    
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(1000), QuickSearch]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Storyline"), QuickSearch]
    public string Storyline { get => fields.Storyline[this]; set => fields.Storyline[this] = value; }
    //[DisplayName("Year")]
    [DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly: 1)]  //only match 4 digit year
    public int? Year { get => fields.Year[this]; set => fields.Year[this] = value; }

    [DisplayName("Release Date")]
    public DateTime? ReleaseDate { get => fields.ReleaseDate[this]; set => fields.ReleaseDate[this] = value; }

    [DisplayName("Runtime (Mins)")]
    public int? Runtime { get => fields.Runtime[this]; set => fields.Runtime[this] = value; }

    //[DisplayName("Kind"), NotNull]  // tambahkan enum kind
    //public MovieKind? Kind { get => fields.Kind[this]; set => fields.Kind[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field MovieId;
        public StringField Title;
        public StringField Description;
        public StringField Storyline;
        public Int32Field Year;
        public DateTimeField ReleaseDate;
        public Int32Field Runtime;

        //public EnumField<MovieKind> Kind;  // tambahkan enum kind

    }
}
