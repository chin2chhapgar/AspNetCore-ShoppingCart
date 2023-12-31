﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Session
    {        
        [Key]
        public string Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
