using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialCostLib.Models
{
    public class MainDTO
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public float Qty { get; set; }
        public float UnitCost { get; set; }
        public string Cost { get; set; }
        
    }
}
