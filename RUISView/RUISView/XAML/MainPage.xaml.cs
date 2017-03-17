using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
<<<<<<< HEAD:RUISView/RUISView/MainPage.xaml.cs
using Microsoft.Phone.Shell;
using RUISView.Resources;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;
=======
using Windows.UI.Popups;
>>>>>>> master:RUISView/RUISView/XAML/MainPage.xaml.cs

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


        private ObservableCollection<DatabaseModel.Maps> _Maps;
        public ObservableCollection<DatabaseModel.Maps> Maps
        {
            get
            {
                return _Maps;
            }
            set
            {
                if (_Maps != value)
                {
                    _Maps = value;
                    NotifyPropertyChanged("DatabaseModel.Maps");
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

<<<<<<< HEAD:RUISView/RUISView/MainPage.xaml.cs
        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = Database.DatabaseExists().ToString();
        }
=======
        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSideMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
>>>>>>> master:RUISView/RUISView/XAML/MainPage.xaml.cs
    }
}