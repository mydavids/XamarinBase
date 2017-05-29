using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Cart : Model
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private List<Products> productList { get; set; } 
        private DateTime cartCreated { get; set; }
        private int ItemAmount { get; set; }
        private double Total { get; set; }
    }
}
