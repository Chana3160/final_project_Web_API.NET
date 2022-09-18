using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class OrderDTO
    {
       
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? UserId { get; set; }
        public string Price { get; set; }
        public virtual ICollection<OrderItemDTO> OrderItems { get; set; }


    }
}
