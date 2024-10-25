using FluentMigrator;

namespace seren.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20231103_1400)]
public class DefaultDB_20231103_1400_InitialMovie : AutoReversingMigration
{
  public override void Up()
  {
      Create.Table("Movie")
          .WithColumn("MovieId").AsInt32()
              .Identity().PrimaryKey().NotNullable()
          .WithColumn("Title").AsString(200).NotNullable()
          .WithColumn("Description").AsString(1000).Nullable()
          .WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
          .WithColumn("Year").AsInt32().Nullable()
          .WithColumn("ReleaseDate").AsDateTime().Nullable()
          .WithColumn("Runtime").AsInt32().Nullable();
  }
}
