using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Country
    {
        [Key]
        [Column("country_id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
