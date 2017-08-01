namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStockDataToMovies : DbMigration
    {
        public override void Up()
        { 
            Sql("UPDATE Movies SET NumberInStock = 692 WHERE Id = 1");
            Sql("UPDATE Movies SET NumberInStock = 811 WHERE Id = 2");
            Sql("UPDATE Movies SET NumberInStock = 215 WHERE Id = 3");
            Sql("UPDATE Movies SET NumberInStock = 382 WHERE Id = 4");
            Sql("UPDATE Movies SET NumberInStock = 534 WHERE Id = 5");
            Sql("UPDATE Movies SET NumberInStock = 557 WHERE Id = 6");
            Sql("UPDATE Movies SET NumberInStock = 863 WHERE Id = 7");
            Sql("UPDATE Movies SET NumberInStock = 606 WHERE Id = 8");
            Sql("UPDATE Movies SET NumberInStock = 483 WHERE Id = 9");
        }

        public override void Down()
        {
        }
    }
}
