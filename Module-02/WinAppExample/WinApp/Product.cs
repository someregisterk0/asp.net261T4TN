﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public short Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public byte[] ImageFile { get; set; }

    }
}
