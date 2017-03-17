using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUISView.Utility_Classes
{
    class DataContextBuilder : DataContext
    {
        public static string DBConnectionString = "DataSource=isostore:/RUISviewDB.sdf";
        public Table<DatabaseModel.Maps> Maps;
        public Table<DatabaseModel.Photos> Photos;
        //public Table<DatabaseModel.P_Rules> P_Rules;

        public DataContextBuilder(string connectionString)
            : base(connectionString)
        {
        }        
    }
}
