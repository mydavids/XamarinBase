using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Price : Model
    {
        private long Id { get; set; }
        private string Currency { get; set; }
        private double Amount { get; set; }

    }
}
