using System.Windows;

namespace RUISView
{
    public class PopUpManager
    {
        PopUp m_popUp = new PopUp();

        public enum PopUps {Options, Statistics, Info}

        public PopUpManager()
        {
            m_popUp.cnvInfo.Visibility = Visibility.Collapsed;
            m_popUp.cnvOptions.Visibility = Visibility.Collapsed;
            m_popUp.cnvStatistics.Visibility = Visibility.Collapsed;
        }

        public void SetPopUpActive(PopUps a_popUpName)
        {
            switch (a_popUpName)
            {
                case PopUps.Options:
                    m_popUp.cnvOptions.Visibility = Visibility.Visible;
                    break;
                case PopUps.Statistics:
                    m_popUp.cnvStatistics.Visibility = Visibility.Visible;
                    break;
                case PopUps.Info:
                    m_popUp.cnvInfo.Visibility = Visibility.Visible;
                    break;
                default:
                    m_popUp.cnvInfo.Visibility = Visibility.Collapsed;
                    m_popUp.cnvOptions.Visibility = Visibility.Collapsed;
                    m_popUp.cnvStatistics.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        public void SetPopUpsInactive()
        {
            m_popUp.cnvInfo.Visibility = Visibility.Collapsed;
            m_popUp.cnvOptions.Visibility = Visibility.Collapsed;
            m_popUp.cnvStatistics.Visibility = Visibility.Collapsed;
        }
        



    }
}