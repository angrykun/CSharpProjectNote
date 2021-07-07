using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Address Address { get; set; }
        public Address ShippingAddress { get; set; }
        public string Description { get; set; }
        public DetailedOrder DetailedOrder { get; set; }
        public int OrderNumbers { get; set; }
    }
}
