﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYYouTubeBootCampModule501.Dtos
{
    public class ResultProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}