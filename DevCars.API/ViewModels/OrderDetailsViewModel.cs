﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.ViewModels
{
    public class OrderDetailsViewModel
    {
        public List<string> ExtraItems { get; set; }
        public decimal TotalCost { get; set; }
        public int IdCar { get; set; }
        public int IdCustomer { get; set; }


    }
}
