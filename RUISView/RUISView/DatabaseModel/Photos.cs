﻿using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Data.Linq;

namespace RUISView.DatabaseModel
{
    [Table(Name = "Photos")]
    public class Photos : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private int _p_PhotoId;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int p_PhotoID
        {
            get
            {
                return _p_PhotoId;
            }
            private set
            {
                if (_p_PhotoId != value)
                {
                    NotifyPropertyChanging("_p_PhotoId");
                    _p_PhotoId = value;
                    NotifyPropertyChanged("_p_PhotoId");
                }
            }
        }

        private int _m_MapId;
        [Column]
        public int m_MapId
        {
            get
            {
                return _m_MapId;
            }
            set
            {
                if (_m_MapId != value)
                {
                    NotifyPropertyChanging("_m_MapId");
                    _p_PhotoId = value;
                    NotifyPropertyChanged("_m_MapId");
                }
            }
        }

        private string _p_PhotoName;
        [Column]
        public string p_PhotoName
        {
            get
            {
                return _p_PhotoName;
            }
            set
            {
                if (_p_PhotoName != value)
                {
                    NotifyPropertyChanging("_p_PhotoName");
                    _p_PhotoName = value;
                    NotifyPropertyChanged("_p_PhotoName");
                }
            }
        }

        private int _p_ShowTime;
        [Column]
        public int p_ShowTime
        {
            get
            {
                return _p_ShowTime;
            }
            set
            {
                if (_p_ShowTime != value)
                {
                    NotifyPropertyChanging("_p_ShowTime");
                    _p_ShowTime = value;
                    NotifyPropertyChanged("_p_ShowTime");
                }
            }
        }

        private int _p_TimesShown;
        [Column]
        public int p_TimesShown
        {
            get
            {
                return _p_TimesShown;
            }
            set
            {
                if (_p_TimesShown != value)
                {
                    NotifyPropertyChanging("_p_TimesShown");
                    _p_TimesShown = value;
                    NotifyPropertyChanged("_p_TimesShown");
                }
            }
        }

        private string _p_Location;
        [Column]
        public string p_Location
        {
            get
            {
                return _p_Location;
            }
            set
            {
                if (_p_Location != value)
                {
                    NotifyPropertyChanging("_p_Location");
                    _p_Location = value;
                    NotifyPropertyChanged("_p_Location");
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
