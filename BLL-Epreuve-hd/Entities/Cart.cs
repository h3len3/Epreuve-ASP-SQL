using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_hd.Entities
{
    internal class Cart
    {
        public int Id_Cart { get; set; }
        public int Id_Order { get; set; }
        public int Id_Product { get; set; }
        public int Quantity { get; set; }

        public Cart (int id_cart, int id_order, int id_product, int quantity)
        {
            Id_Cart = id_cart;
            Id_Order = id_order;
            Id_Product = id_product;
            Quantity  = quantity ;
        }
    }
}





