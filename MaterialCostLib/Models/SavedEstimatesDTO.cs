using System;

namespace MaterialCostLib.Models
{
    public class SavedEstimatesDTO
    {
        public int EstimateId { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        public DateTime Date { get; set; }
    }
}
