﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Tour
    {
        [Key]
        [Column("tour_id")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public Country Country { get; set; }
        public Hotel Hotel { get; set; }
    }
}
