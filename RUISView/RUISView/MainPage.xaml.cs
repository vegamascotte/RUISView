using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Windows.UI.Input;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace RUISView
{
    public partial class MainPage : PhoneApplicationPage
    { 
        private bool m_isPlaying = false;
        private GestureRecognizer m_gRecon = new GestureRecognizer();
        //private bool m_sideMenuIsShowing = false;
        private PhotoView m_photoView = new PhotoView();
        private System.Windows.Threading.DispatcherTimer m_timer = new System.Windows.Threading.DispatcherTimer();
        private bool m_timerIsRunning = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data



            m_timer.Interval = new System.TimeSpan(50000000);
            
            
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }


        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (!m_isPlaying)
            {
                m_timerIsRunning = m_timer.IsEnabled;
                m_timer.Start();
                m_timer.Tick += M_timer_Tick;

                BitmapImage bmp = new BitmapImage();
                bmp.SetSource(m_photoView.GetNextPhotoLocation());
                imgSlideShow.Source = bmp;

                m_isPlaying = true;
            }
            else
            {
                m_timer.Stop();
                m_isPlaying = false;
            }
        }

        private void btnSideMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void M_gRecon_Tapped(GestureRecognizer sender, TappedEventArgs args)
        {
            //cnvOverlay.Visibility = Visibility.Visible;
        }

        private void M_timer_Tick(object sender, System.EventArgs e)
        {
            BitmapImage bmp = new BitmapImage();
            bmp.SetSource(m_photoView.GetNextPhotoLocation());
            imgSlideShow.Source = bmp;
        }

    }
}