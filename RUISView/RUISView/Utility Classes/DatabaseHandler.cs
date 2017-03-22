using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUISView
{
    public class DatabaseHandler
    {
        private static DatabaseHandler dbHandler;
        private string ConnectionString = "DataSource=isostore:/RUISviewDB.sdf";

        private DatabaseHandler()
        {
        }

        public static DatabaseHandler DbHandler
        {
            get
            {
                if(dbHandler == null)
                {
                    dbHandler = new DatabaseHandler();
                }
                return dbHandler;
            }
        }

        private void Disconnect()
        {
            
        }
    }

    //Enum override methods voor create delete edit

    //database connect disconect = private
}
