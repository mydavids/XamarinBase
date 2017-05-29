using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Client : Model
    {
        private long Id { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private long PhoneNumber { get; set; }
        private string name { get; set; }
        private string Surname { get; set; }
        private IList<Address> ClientAddress { get; set; }
    }
}