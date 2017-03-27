using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Threading;
using Microsoft.Phone.Controls;

namespace RUISView
{
    public partial class MainPage : PhoneApplicationPage
    {
        private bool m_isPlaying;
        private readonly PhotoView m_photoView = new PhotoView();
        private readonly DispatcherTimer m_timer = new DispatcherTimer();
        private bool m_timerIsRunning;
        private PopUpManager m_popUpManager = new PopUpManager();
        private bool m_popUpIsActive = false;
        private readonly Popup m_popUp = new Popup();
        private readonly PopUp m_popUpChild = new PopUp();

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            m_timer.Interval = new TimeSpan(50000000);

        }

        protected override void OnNavigatedTo(NavigationEventArgs p_e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void btnPlayPause_Click(object p_sender, RoutedEventArgs p_e)
        {
            if (!m_isPlaying)
            {
                m_timerIsRunning = m_timer.IsEnabled;
                m_timer.Start();
                m_timer.Tick += M_timer_Tick;

                m_isPlaying = true;

                ImageBrush i_img = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri("Assets/pause.png", UriKind.Relative))
                };
                btnPlayPause.Background = i_img;
            }
            else
            {
                m_timer.Stop();
                m_isPlaying = false;

                ImageBrush i_img = new ImageBrush();
                i_img.ImageSource = new BitmapImage(new Uri("Assets/play.png", UriKind.Relative));
                btnPlayPause.Background = i_img;
            }
        }

        private void btnSideMenu_Click(object p_sender, RoutedEventArgs p_e)
        {
            cnvSideMenu.Visibility = cnvSideMenu.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
        }

        private void M_timer_Tick(object p_sender, EventArgs p_e)
        {
            BitmapImage i_bmp = new BitmapImage();
            i_bmp.SetSource(m_photoView.GetNextPhotoLocation());
            imgSlideShow.Source = i_bmp;
        }

        private void LayoutRoot_Tap(object p_sender, GestureEventArgs p_e)
        {
            if (m_popUpIsActive) return;
            btnPlayPause.Visibility = btnPlayPause.Visibility == Visibility.Visible
                ? Visibility.Collapsed
                : Visibility.Visible;

            btnSideMenu.Visibility = btnSideMenu.Visibility == Visibility.Visible
                ? Visibility.Collapsed
                : Visibility.Visible;
        }

        private void Opties_Click(object sender, RoutedEventArgs e)
        {
            m_popUp.Child = m_popUpChild;
            m_popUp.IsOpen = true;
            m_popUpIsActive = m_popUp.IsOpen;

            if (!LayoutRoot.Children.Contains(m_popUp))
            {
                LayoutRoot.Children.Add(m_popUp);
            }
            m_popUp.HorizontalOffset = ActualWidth / 4;
            m_popUp.VerticalOffset = ActualHeight / 4;

            m_popUpChild.cnvOptions.Visibility = Visibility.Visible;

            cnvSideMenu.Visibility = Visibility.Collapsed;
            btnPlayPause.Visibility = Visibility.Collapsed;

        }

        protected override void OnBackKeyPress(CancelEventArgs e)
        {
            base.OnBackKeyPress(e);
            if (m_popUpChild == null || !m_popUp.IsOpen) return;
            m_popUp.IsOpen = false;
            m_popUpIsActive = m_popUp.IsOpen;
            e.Cancel = true;
        }
    }
}