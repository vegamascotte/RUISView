using System;
using System.Collections.Generic;
using System.Linq;

namespace RUISView
{
    public class DatabaseHandler
    {
        private static DatabaseHandler dbHandler;
        private DataContextBuilder db;
        private string ConnectionString = Resources.AppResources.DataConnectionString;
        public enum Methods { CREATE, UPDATE, DELETE };
        public enum Reads { FULLPHOTOPATH, ALLPHOTOSFROMMAP, ALLPHOTOS, DATACONTEXT }

        private DatabaseHandler()
        {
            db = new DataContextBuilder(ConnectionString);
        }

        //declares the databasehandler singleton 
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

        /// <summary>
        /// Basic database interactions: 0 = create, 1 = edit, 2 = delete
        /// </summary>
        /// <param name="a_Interaction"></param> 
        /// <param name="a_Map"></param>
        /// <param name="a_Photo"></param>
        public void Interact(Methods a_Interaction, DatabaseModel.Maps a_Map, DatabaseModel.Photos a_Photo)
        {
            switch(a_Interaction)
            {
                case Methods.CREATE:
                    Create(a_Map, a_Photo);
                    break;
                case Methods.DELETE:
                    Delete(a_Map, a_Photo);
                    break;
                case Methods.UPDATE:
                    Update(a_Map, a_Photo);
                    break;
                default:
                    break;
            }
            UpdateDB();
        }

        public object Read(Reads a_ReadType, DatabaseModel.Maps a_Map, DatabaseModel.Photos a_Photo)
        {
            switch (a_ReadType)
            {
                case Reads.FULLPHOTOPATH:
                    return GetPhotoPath(a_Photo);
                case Reads.ALLPHOTOSFROMMAP:
                    return GetAllPhotosFromMap(a_Map);
                case Reads.ALLPHOTOS:
                    return GetAllPhotos();
                case Reads.DATACONTEXT:
                default:
                    return null;                    
            }
        }

        #region interactions
        private void Create(DatabaseModel.Maps a_Map, DatabaseModel.Photos a_Photo)
        {
            if (a_Photo != null)
            {
                db.Photos.InsertOnSubmit(a_Photo);
            }
            if (a_Map != null)
            {
                if(db != null)
                    if(db.Maps != null)
                    db.Maps.InsertOnSubmit(a_Map);
            }
        }

        private void Delete(DatabaseModel.Maps a_Map, DatabaseModel.Photos a_Photo)
        {
            if (a_Map != null)
            {
                db.Maps.DeleteOnSubmit(a_Map);
            }
            if (a_Photo != null)
            {
                db.Photos.DeleteOnSubmit(a_Photo);
            }
        }

        private void Update(DatabaseModel.Maps a_Map, DatabaseModel.Photos a_Photo)
        {
            if (a_Photo != null)
            {
                int oldID = a_Photo.p_PhotoID;
                var oldPhoto = db.Photos.Where(p => p.p_PhotoID == oldID).FirstOrDefault();
                DatabaseModel.Maps map = db.Maps.Where(m => m.m_MapId == a_Photo.m_MapId).FirstOrDefault();
                oldPhoto = a_Photo;
            }
            if (a_Map != null)
            {
                int oldID = a_Map.m_MapId;
                var oldMap = db.Maps.Where(m => m.m_MapId == oldID).FirstOrDefault();
                oldMap = a_Map;
            }
        }
        #endregion

        #region reads
        private string GetPhotoPath(DatabaseModel.Photos a_Photo)
        {
            string mapPath = db.Maps.Where(m => m.m_MapId == a_Photo.m_MapId).Select(m => m.m_MapLocation).ToString();
            mapPath += ("/" + a_Photo.p_PhotoName);
            return mapPath;
        }

        private List<DatabaseModel.Photos> GetAllPhotosFromMap(DatabaseModel.Maps a_Map)
        {
            return db.Photos.Where(p => p.m_MapId == a_Map.m_MapId).ToList();
        }

        private List<DatabaseModel.Photos> GetAllPhotos()
        {
            return db.Photos.ToList();
        }

        private DataContextBuilder GetContext()
        {
            return db;
        }

        #endregion        

        private string UpdateDB()
        {
            try
            {
                db.SubmitChanges();
            }
            catch(Exception e)
            {
                return string.Format("Canceled update with errorcode: {0}", e);
            }

            return "The update was succesful.";
        }
    }
}
