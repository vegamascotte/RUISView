using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUISView
{
    class PhotoView
    {
        private string m_nextPhotoName;
        private string m_currentPhotoName;

        PhotoView ()
        {

        }

        #region PublicMethods


        public object GetNextPhoto()
        {
            GetNewPhoto(); // needs to be async

        }

        #endregion

        #region PrivateMethods

        private void GetNewNextPhoto() 
        {
            //need to add a call to photomanager to see what will be the next photo.
            m_currentPhotoName = m_nextPhotoName;
            m_nextPhotoName = null; // here is where the call will be.
        }

        private object GetNewPhoto()
        {
            //need to add a call to the db handler for the new photo using the m_nextPhoto variable.
            return null;
        }

        #endregion



    }
}