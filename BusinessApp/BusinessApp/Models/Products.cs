using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Products : Model
    {
        private long Id { get; set; }
        private string Name { get; set; }
        private Price PriceAmout { get; set; }
        private long CatergoryId { get; set; }
        private string Description { get; set; }
        private int Quantity { get; set; }
        private Images ProductImage { get; set; }
    }
}
