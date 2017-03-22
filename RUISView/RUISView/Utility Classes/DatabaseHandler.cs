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
        private DataContextBuilder db;
        private string ConnectionString = "DataSource=isostore:/RUISviewDB.sdf";
        public enum Methods { CREATE, READ, UPDATE, DELETE };

        private DatabaseHandler()
        {
            db = new DataContextBuilder(ConnectionString);
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

        public void Interact(Methods a_Interaction, DatabaseModel.Maps map, DatabaseModel.Photos photo)
        {
            switch(a_Interaction)
            {
                case Methods.CREATE:
                    break;
                case Methods.DELETE:
                    break;
                case Methods.UPDATE:
                    break;
                case Methods.READ:
                    if(map != null)
                    {

                    }
                    break;
                default:
                    break;
            }

            UpdateDB();
        }

        private void Create(DatabaseModel.Maps map, DatabaseModel.Photos photo)
        {
            if(photo != null)
            {
                db.Photos.InsertOnSubmit(photo);
            }
            if(map != null)
            {
                db.Maps.InsertOnSubmit(map);
            }
            db.SubmitChanges();
        }

        private void Delete(DatabaseModel.Maps map, DatabaseModel.Photos photo)
        {

        }

        private void ReadMap(DatabaseModel.Maps map)
        {

        }

        private void ReadPhoto(DatabaseModel.Photos photo)
        {

        }
        
        private void Update(DatabaseModel.Maps map, DatabaseModel.Photos photo)
        {
            if(photo != null)
            {
                int oldID = photo.p_PhotoID;
                var oldPhoto = db.Photos.Where(p => p.p_PhotoID == oldID).FirstOrDefault();
                oldPhoto = photo;
            }
            if (map != null)
            {
                int oldID = map.m_MapId;
                var oldMap = db.Maps.Where(m => m.m_MapId == oldID).FirstOrDefault();
                oldMap = map;
            }
        }

        private void UpdateDB()
        {
            try
            {
                db.SubmitChanges();
            }
            catch(Exception e)
            {

            }
        }
    }
}
