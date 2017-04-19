﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HPCN.UnionOnline.Models
{
    public class OrderDetail : Entity
    {
        [Required]
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Bonus Point Price")]
        public double BonusPointPrice { get; set; }

        [Required]
        [Display(Name = "Money Price")]
        public double MoneyPrice { get; set; }

        [Required]
        public Order Order { get; set; }
    }
}
