using FluentMigrator;

namespace Nop.Data.Migrations
{
    [Migration(1)]
    public class InitMigration : ForwardOnlyMigration
    {
        private readonly IDataProvider _dataProvider;

        public InitMigration(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public override void Up() 
        { 
            
        }
    }
}
