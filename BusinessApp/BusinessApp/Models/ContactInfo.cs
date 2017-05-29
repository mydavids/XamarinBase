using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class ContactInfo : Model
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private string Email { get; set; }
        private long PhoneNumber { get; set; }
        private string SecondaryEmail { get; set; }
    }
}

