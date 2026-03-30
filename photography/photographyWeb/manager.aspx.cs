using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace photographyWeb
{
    public partial class manager : System.Web.UI.Page
    {

        private B_Photographer BussinessPhotographer = new B_Photographer();
        protected void Page_Load(object sender, EventArgs e)
        {
            // loading page, the personal information
        }

        public void onUpdateInfo(object sender, EventArgs e) {

            string username = inputUsername.Value;
            string email = inputEmail.Value;
            string phone = inputPhoneNumber.Value;
            string location = inputPhoneNumber.Value;
            string instagram = inputInstagram.Value;
            string facebook = inputFacebook.Value;
            string biography = inputBio.Value;


            bool response = BussinessPhotographer.UpdateInfo(username, email, phone, location, instagram, facebook, biography);

            if (!response)
            {
               // display error message
            }
        }
    }
}