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
    public partial class about : System.Web.UI.Page
    {
        private B_Photographer BussinnessPhotographer = new B_Photographer();
        public string linkInstagram = "https://www.instagram.com/";
        public string linkFacebook = "https://www.facebook.com/";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
                EllinkInstagram.HRef = linkInstagram;
                EllinkFacebook.HRef = linkFacebook;
                onGetAboutInformation();
            }
        }

        public void onGetAboutInformation () {
            E_Photographer photographer = BussinnessPhotographer.getInfo();
            EllinkFacebook.HRef = photographer.Facebook;
            EllinkInstagram.HRef= photographer.Instagram;
            TextGreeting.InnerText = "Hi, I am " + photographer.Name;
            TextPresenting.InnerText = photographer.Biography;
        }
    }
}