using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
using Nop.Core.Data;

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
