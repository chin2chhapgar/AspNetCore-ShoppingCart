﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        
        public DateTime DateTime { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
