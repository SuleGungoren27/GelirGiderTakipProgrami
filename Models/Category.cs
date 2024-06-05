using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTakip.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }


        public virtual List<Income> Incomes { get; set; }
        public virtual List<Expense> Expenses { get; set; }
    }
}
