﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AndroidAPI
{
    public class TimeSlot
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int? TrainerId { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }

    }
}
