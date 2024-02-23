using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve_hd.Entities
{
    public class Cart
    {
        public int Id_Cart { get; set; }
        public int Id_Order { get; set; }
        public int Id_Product { get; set; }
        public int Quantity { get; set; }
    }
}



