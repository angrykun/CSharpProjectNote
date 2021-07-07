using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model
{
    public class Distributor
    {
        public int Id { get; set; }
        public ICollection<Address> ShippingAddresses { get; set; }
    }
}
