using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApp.Enums;

namespace BusinessApp.Models
{
   public class Account:Model
   {
       private long Id { get; set; }
       private long ClientId { get; set; }
       private string AccountName { get; set; }
       private IList<Orders> OrdersList { get; set; }
       private IList<Enqueries> EnqueriesList { get; set; }


   }
}
