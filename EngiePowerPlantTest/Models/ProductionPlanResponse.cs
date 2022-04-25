using System.Text.Json.Serialization;

namespace EngiePowerPlantTest.Models
{
    public class ProductionPlanResponse
    {
        public string Name { get; set; }

        [JsonPropertyName("p")]
        public decimal Power { get; set; }

        [JsonIgnore]
        public decimal Price { get; set; }
    }
}
