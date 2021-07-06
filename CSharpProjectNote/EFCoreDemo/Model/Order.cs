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
        public string Description { get; set; }
    }

    public enum OrderStatus
    {
        Created,
        Cancel,
        WaitingForPay
    }

    public class Address
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
