using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUISView
{
    public class PopUpManager
    {
        PopUp m_popUp = new PopUp();

        public enum PopUps {Options, Statistics, Info}

        PopUpManager()
        {
            m_popUp.cnvInfo.Visibility = System.Windows.Visibility.Collapsed;
            m_popUp.cnvOptions.Visibility = System.Windows.Visibility.Collapsed;
            m_popUp.cnvStatistics.Visibility = System.Windows.Visibility.Collapsed;
        }

        public void SetPopUpActive(PopUps a_popUpName)
        {
            switch (a_popUpName)
            {
                case PopUps.Options:
                    m_popUp.cnvOptions.Visibility = System.Windows.Visibility.Visible;
                    break;
                case PopUps.Statistics:
                    m_popUp.cnvStatistics.Visibility = System.Windows.Visibility.Visible;
                    break;
                case PopUps.Info:
                    m_popUp.cnvInfo.Visibility = System.Windows.Visibility.Visible;
                    break;
                default:
                    m_popUp.cnvInfo.Visibility = System.Windows.Visibility.Collapsed;
                    m_popUp.cnvOptions.Visibility = System.Windows.Visibility.Collapsed;
                    m_popUp.cnvStatistics.Visibility = System.Windows.Visibility.Collapsed;
                    break;
            }
        }

        public void SetPopUpsInactive()
        {
            m_popUp.cnvInfo.Visibility = System.Windows.Visibility.Collapsed;
            m_popUp.cnvOptions.Visibility = System.Windows.Visibility.Collapsed;
            m_popUp.cnvStatistics.Visibility = System.Windows.Visibility.Collapsed;
        }
        



    }
}