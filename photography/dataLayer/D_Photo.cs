using EntityLayer;
// using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataLayer
{
    public class D_Photo
    {

        public List<E_Photo> GetAllPhotos() { 
            List<E_Photo> photos = new List<E_Photo>();

            using (SqlConnection conn = Connection.GetConnection()) {
                SqlCommand cmd = new SqlCommand("Get_All_Photos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    photos.Add(
                        new E_Photo { 
                            Title = reader["Title"].ToString(),
                            Description = reader["Title"].ToString(),
                            UrlPhoto = reader["Url_Photo"].ToString(),
                            CreatedDate = Convert.ToDateTime(reader["Created_date"]),
                            PhotographerId = Convert.ToInt32(reader["Photographer_Id"]),
                            CategoryId = Convert.ToInt32(reader["Category_Id"])
                        }
                     );                
                }
            }

                return photos;
        }

        public List<E_Photo> getLocalPhotos()
        {
            List<E_Photo> photos = new List<E_Photo>();
            photos.Add(new E_Photo
            {
                UrlPhoto = "images/snapshot.png",
            });

            photos.Add(new E_Photo
            {
                UrlPhoto = "images/mexico.png",
            });

            photos.Add(new E_Photo
            {
                UrlPhoto = "images/nature.png",
            });

            photos.Add(new E_Photo
            {
                UrlPhoto = "images/unfreezing.png",
            });

            photos.Add(new E_Photo
            {
                UrlPhoto = "images/portrait.png",
            });

            photos.Add(new E_Photo
            {
                UrlPhoto = "images/animal.png",
            });

            return photos;
        }
    }
}
