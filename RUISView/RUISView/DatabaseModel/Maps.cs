using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Data.Linq;

namespace RUISView.DatabaseModel
{
    [Table(Name = "Maps")]
    public class Maps : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public Maps()
        {
           // this._P_Rules = new EntitySet<DatabaseModel.P_Rules>(delegate (P_Rules entity)
           //{
           //    this.NotifyPropertyChanging("P_Rules");
           //    entity.Maps = this;
           //},
           // delegate (P_Rules entity)
           // {
           //     this.NotifyPropertyChanged("P_Rules");
           //     entity.Maps = null;
           // });
        }

        private int _m_MapId;
        [Column(IsPrimaryKey = true, Storage ="_m_MapId", IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int m_MapId
        {
            get
            {
                return _m_MapId;
            }
        }

        //private EntitySet<P_Rules> _P_Rules;
        //[Association(Storage = "_P_Rules", OtherKey = "_m_MapId")]
        //public EntitySet<P_Rules> P_Rules
        //{
        //    get { return this._P_Rules; }
        //    set { this._P_Rules.Assign(value); }
        //}

        [Column]
        private int PhotoId;

        private EntitySet<Photos> _Photos;
        [Association(Storage = "_Photos", OtherKey = "MapId")]
        public EntitySet<Photos> Photos
        {
            get { return this._Photos; }
            set { this._Photos.Assign(value); }
        } 

        private string _m_MapName;
        [Column(Storage = "_m_MapName")]
        public string m_MapName
        {
            get
            {
                return _m_MapName;
            }
            set
            {
                if (_m_MapName != value)
                {
                    NotifyPropertyChanging("_m_MapName");
                    _m_MapName = value;
                    NotifyPropertyChanged("_m_MapName");
                }
            }
        }

        private string _m_MapLocation;
        [Column(Storage = "_m_MapLocation")]
        public string m_MapLocation
        {
            get
            {
                return _m_MapLocation;
            }
            set
            {
                if (_m_MapLocation != value)
                {
                    NotifyPropertyChanging("_m_MapLocation");
                    _m_MapName = value;
                    NotifyPropertyChanged("_m_MapLocation");
                }
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify the page that a data context property changed
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        // Used to notify the data context that a data context property is about to change
        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        #endregion
    }
}
