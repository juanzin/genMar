using BussinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace photographyWeb
{
    public partial class main : System.Web.UI.Page
    {
        public B_Photo BussinnessPhoto = new B_Photo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getAllPhotos();
            }
        }

        public void getAllPhotos() { 
            List<E_Photo> photos = new List<E_Photo>();

            photos = BussinnessPhoto.getAllPhotos();

            if (photos.Count > 0) {
                ImgAnimal.Src = photos[0].UrlPhoto;
                ImgSnapshot.Src = photos[6].UrlPhoto;
                ImgMexico.Src = photos[2].UrlPhoto;
                ImgNature.Src = photos[3].UrlPhoto;
                ImgUnfreezing.Src = photos[7].UrlPhoto;
                ImgPortrait.Src = photos[4].UrlPhoto;
            }

        }
    }
}