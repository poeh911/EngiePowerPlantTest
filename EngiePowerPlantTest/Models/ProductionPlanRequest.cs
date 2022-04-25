using System.Collections.Generic;

namespace EngiePowerPlantTest.Models
{
    public class ProductionPlanRequest
    {
        public decimal Load { get; set; }
        public Fuels Fuels { get; set; }
        public IEnumerable<Powerplant> Powerplants { get; set; }
    }
}
