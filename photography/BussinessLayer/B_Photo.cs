using dataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class B_Photo
    {
        private D_Photo photoData;
        public B_Photo() { 
            photoData = new D_Photo();
        }
        public List<E_Photo> getAllPhotos() { 
            List<E_Photo> photos = new List<E_Photo>();

            photos = photoData.GetAllPhotos();

            return photos;
        
        }
    }
}
