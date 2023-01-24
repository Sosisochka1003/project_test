using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Sale
    {
        [Column("sale_id")]
        public int Id { get; set; }
        public string DateSale { get; set; }
        public int CountSale { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Tour Tour { get; set; }
    }
}
