using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>() {
                new Customer(){ Id=1,Name="王小明1",Phone="0912345678"},
                new Customer(){ Id=2,Name="王小明2",Phone="0912345678"},
                new Customer(){ Id=3,Name="王小明3",Phone="0912345678"},
                new Customer(){ Id=4,Name="王小明4",Phone="0912345678"},
                new Customer(){ Id=5,Name="王小明5",Phone="0912345678"},
                new Customer(){ Id=6,Name="王小明6",Phone="0912345678"},
            };
        }
    }
}