using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class E_Photo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string UrlPhoto { get; set; }
        public DateTime CreatedDate { get; set; }
        public int PhotographerId { get; set; }
        public int CategoryId { get; set; }
    }
}
