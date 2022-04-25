﻿using System.Text.Json.Serialization;

namespace EngiePowerPlantTest.Models
{
    public class Fuels
    {
        [JsonPropertyName("gas(euro/MWh)")]
        public decimal Gas { get; set; }

        [JsonPropertyName("kerosine(euro/MWh)")]
        public decimal Kerosine { get; set; }

        [JsonPropertyName("co2(euro/ton)")]
        public decimal CO2 { get; set; }

        [JsonPropertyName("wind(%)")]
        public decimal Wind { get; set; }
    }
}