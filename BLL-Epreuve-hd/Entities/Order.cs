using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Epreuve_hd.Entities
{
    internal class Order
    {
        public int Id_Order { get; set; }
        public DateTime OrderDate { get; set; }       
        public Order (int id_order, DateTime orderdate)
        {
            Id_Order = id_order;
            OrderDate = orderdate;
          
        }
    }
}
