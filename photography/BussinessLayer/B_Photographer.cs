using dataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class B_Photographer
    {
        private D_Photographer DataPhotographer;
        private const int TYPE_USER = 1;
        public B_Photographer()
        {
            this.DataPhotographer = new D_Photographer();

        }

        public bool UpdateInfo(string username, string email, string phone, string location, string instagram, string facebook, string bio)
        {
            bool response = false;
            if (string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(phone)
                || string.IsNullOrEmpty(location)
                || string.IsNullOrEmpty(instagram)
                || string.IsNullOrEmpty(facebook)
                || string.IsNullOrEmpty(bio)) {
            } else { 
                response = DataPhotographer.UpdateInfo(new E_Photographer { 
                    Name = "",
                    Paterno = "",
                    Materno = "",
                    Username = username,
                    Password = "newPassword",
                    Instagram = instagram,
                    Facebook = facebook,
                    Email = email,
                    Biography = bio,
                    TypeUser = TYPE_USER

                });
            }


            return response;
        }
    }
}
