using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve_hd.Entities
{
    public class Media
    {
        public int Id_Media { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public int Id_Product { get; set; }
        
    }
}


