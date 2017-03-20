using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RUISView
{
    class PhotoView
    {
        private System.IO.Stream m_nextPhotoLocation;
        private string m_currentPhotoName = string.Empty;
        private string m_nextPhotoName = string.Empty;
        private int m_times = 0;

        public PhotoView ()
        {
            
        }

        #region PublicMethods


        public void GetNextPhotoName()
        {
            GetNewPhoto(); // needs to be async
            m_currentPhotoName = m_nextPhotoName;
        }



        #endregion

        #region GettersAndSetters

        public Stream GetNextPhotoLocation()
        {
            GetNewPhotoName();
            return m_nextPhotoLocation;
        }


        #endregion

        #region PrivateMethods

        private void GetNewPhotoName()
        {
            // call the photo manager to see what the new photo will be.
            int test = m_times % 3;
            switch (test)
            {
                case 0:
                    m_nextPhotoName = "testImage1.jpg";
                    m_nextPhotoLocation = new MemoryStream(Resources.AppResources.testImage1);
                    m_times++;
                    break;

                case 1:
                    m_nextPhotoName = "testImage2.jpg";
                    m_nextPhotoLocation = new MemoryStream(Resources.AppResources.testImage2);
                    m_times++;
                    break;

                case 2:
                    m_nextPhotoName = "testImage3.jpg";
                    m_nextPhotoLocation = new MemoryStream(Resources.AppResources.testImage3);
                    m_times++;
                    break;
                default:

                    break;
            }
        }

        private string GetNewPhoto()
        {
            //need to add a call to the db handler for the new photo using the m_nextPhoto variable.
            return null;
        }

        #endregion



    }
}