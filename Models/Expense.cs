using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTakip.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public string Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }


        public virtual Category Category { get; set; }
    }
}
