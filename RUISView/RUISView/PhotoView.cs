using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUISView
{
    class PhotoView
    {
        private object m_nextPhoto;
        private string m_currentPhotoName;
        private string m_nextPhotoName;
       
        PhotoView ()
        {
            
        }

        #region PublicMethods


        public void GetNextPhoto()
        {
            GetNewPhoto(); // needs to be async
            m_currentPhotoName = m_nextPhotoName;
        }
        


        #endregion

        #region PrivateMethods

        private void GetNewPhotoName()
        {
            // call the photo manager to see what the new photo will be.
        }

        private object GetNewPhoto()
        {
            //need to add a call to the db handler for the new photo using the m_nextPhoto variable.
            return null;
        }

        #endregion



    }
}