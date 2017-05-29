using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
   public class MenuItem : Model
    {
        private long Id { get; set; }
        private int OrderNumber { get; set; }
        private string Name { get; set; }
    }
}
