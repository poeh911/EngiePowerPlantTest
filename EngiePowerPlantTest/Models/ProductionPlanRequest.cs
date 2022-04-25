using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EngiePowerPlantTest.Models
{
    public class ProductionPlanRequest
    {
        [Required]
        public decimal Load { get; set; }

        [Required]
        public Fuels Fuels { get; set; }

        [Required]
        public IEnumerable<Powerplant> Powerplants { get; set; }
    }
}
