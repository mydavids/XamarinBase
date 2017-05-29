using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Categories : Model
    {
        private long Id { get; set; }
        private string CategoryName { get; set; }
        private List<Products> Products { get; set; }
        
    }
}
