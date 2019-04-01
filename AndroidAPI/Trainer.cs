using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndroidAPI
{
    public class Trainer
    {
        public int ID { get; set; }
        public string TrainerName { get; set; }
        public string Phone { get; set; }
        public double Rating { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public double Price { get; set; }

        public virtual ICollection<TimeSlot> Timeslots { get; set; }
    }
}
