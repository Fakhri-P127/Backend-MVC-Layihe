﻿using Backend_MVC_Layihe.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_MVC_Layihe.Models
{
    public class Size:BaseEntity
    {
        public string Name { get; set; }
        public List<ClothesColorSize> ClothesColorSizes { get; set; }


    }
}
