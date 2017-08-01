namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeDataToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '1993-06-10' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthday = '1997-03-22' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
