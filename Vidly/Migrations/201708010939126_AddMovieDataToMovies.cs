namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieDataToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma''s House', 'Comedy', 2001-6-15, GetDate())");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma''s Heart Surgery', 'Drama', 2002-03-7, GetDate())");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma''s Funeral', 'Drama', 2003-05-19, GetDate())");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma isn''t Dead!?', 'Dramatic Comedy', 2004-08-10, GetDate())");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma''s Seance', 'Comedy', 2005-10-26, GetDate())");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma''s a Demon', 'Comedy Horror', 2007-10-31, GetDate())");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma''s Defiled Corpse', 'Action Horror', 2008-10-31, GetDate())");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma''s Finally Laid to Rest', 'Adventure', 2011-09-17, GetDate())");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleaseDate, DateAdded) VALUES ('Big Momma''s Christmas Special', 'Anime', 2012-12-23, GetDate())");
        }
        
        public override void Down()
        {
        }
    }
}
