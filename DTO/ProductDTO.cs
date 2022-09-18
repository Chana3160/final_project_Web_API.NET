using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class ProductDTO
    {

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int? PriceProduct { get; set; }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public string Image { get; set; }
        
    }
}
