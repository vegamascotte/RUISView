using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUISView
{
    public class DataContextBuilder : DataContext
    {
        public static string DBConnectionString = Resources.AppResources.DataConnectionString;
        public Table<DatabaseModel.Maps> Maps;
        public Table<DatabaseModel.Photos> Photos;

        public DataContextBuilder(string connectionString)
            : base(connectionString)
        {
        }        
    }
}
