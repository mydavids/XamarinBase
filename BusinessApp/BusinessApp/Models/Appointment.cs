using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Models
{
    public class Appointment : Model
    {
        private long Id { get; set; }
        private long ClientId { get; set; }
        private DateTime? AppointmentDate { get; set; }
        private string StartTime { get; set; }
        private string EndTime { get; set; }
        private User AppointmentUser { get; set; }
        private string Notes { get; set; }
    }
}
