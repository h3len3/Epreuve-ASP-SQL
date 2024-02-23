using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_hd.Entities
{
    public class Media
    {
        public int Id_Media { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        public string Url { get; set; }
        public int Id_Product { get; set; }

        public Media(int id_Media, string name, string type,  string url, int id_product)
        {
            Id_Media = id_Media;
            Name= name;
            Type = type;
            Url = url;
            Id_Product = id_product;
        }

    }
}


      