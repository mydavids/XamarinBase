using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Enqueries : Model
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private string Notes { get; set; }
        private Images Pictures { get; set; }
        private DateTime EnquiryDate { get; set; }
    }
}
