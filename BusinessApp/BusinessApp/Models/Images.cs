using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Images : Model
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private byte[] ImageBytes { get; set; }
        private string ImageName { get; set; }
        private string ImageExtension { get; set; }
    }
}

