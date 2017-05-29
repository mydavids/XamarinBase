using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Enums;

namespace BusinessApp.Models
{
    public class PaymentOption : Model
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private PaymentType PayType { get; set; }

    }
}
