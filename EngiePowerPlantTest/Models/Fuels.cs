using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EngiePowerPlantTest.Models
{
    public class Fuels
    {
        [Required]
        [JsonPropertyName("gas(euro/MWh)")]
        public decimal Gas { get; set; }

        [Required]
        [JsonPropertyName("kerosine(euro/MWh)")]
        public decimal Kerosine { get; set; }

        [Required]
        [JsonPropertyName("co2(euro/ton)")]
        public decimal CO2 { get; set; }

        [Required]
        [JsonPropertyName("wind(%)")]
        public decimal Wind { get; set; }
    }
}