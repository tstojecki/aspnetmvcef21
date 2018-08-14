using System;

namespace NetCoreApp.Data
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public OrderStatus Status { get; set; }
    }
}