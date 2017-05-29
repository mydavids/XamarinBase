using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class OrderLine : Model
    {
        private long Id { get; set; }
        private long OrderNumber { get; set; }
        private long ClientNumber { get; set; }
        private string ProductName { get; set; }
        private long ProductId { get; set; }
    }
}
