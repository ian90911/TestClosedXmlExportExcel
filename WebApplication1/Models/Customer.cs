using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        [DisplayName("流水號")]
        public int Id { get; set; }
        [DisplayName("姓名")]
        public string Name { get; set; }
        [DisplayName("電話")]
        public string Phone { get; set; }
    }
}