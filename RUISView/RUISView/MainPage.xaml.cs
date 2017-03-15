using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RUISView.Resources;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RUISView
{
    public partial class MainPage : PhoneApplicationPage, INotifyPropertyChanged
    {
        //Datacontext for the local db
        private Utility_Classes.DataContextBuilder Database;

        // Definition for observable collection that controls can be bound to
        private ObservableCollection<DatabaseModel.Photos> _Photos;
        public ObservableCollection<DatabaseModel.Photos> Photos
        {
            get
            {
                return _Photos;
            }
            set
            {
                if(_Photos != value)
                {
                    _Photos = value;
                    NotifyPropertyChanged("DatabaseModel.Photos");
                }
            }
        }

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Database = new Utility_Classes.DataContextBuilder(Utility_Classes.DataContextBuilder.DBConnectionString);
            this.DataContext = this;
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            // Define the query to gather all of the to-do items.
            //var dbPhotos = from DatabaseModel.Photos photos in Database.Photos select photos;

            // Execute the query and place the results into a collection.
            //Photos = new ObservableCollection<DatabaseModel.Photos>(dbPhotos);

            // Call the base method.
            base.OnNavigatedTo(e);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify the app that a property has changed.
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}