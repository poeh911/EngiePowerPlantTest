namespace EngiePowerPlantTest.Models
{
    public class GasfiredProductionPlan : ProductionPlan
    {
        public override string Type => Constant.PowerPlantType.Gasfired;

        public GasfiredProductionPlan(Powerplant powerplant, Fuels fuels, decimal restToProduce)
        {
            Powerplant = powerplant;
            Fuels = fuels;
            RestToProduce = restToProduce;
        }

        public override Powerplant Powerplant { get; }

        public override Fuels Fuels { get; }

        public override decimal RestToProduce { get; }

        public override decimal CalculPower()
        {
            return Powerplant.PMax > RestToProduce ? RestToProduce : Powerplant.PMax;
        }

        public override decimal CalculPrice()
        {
            return (CalculPower() * Fuels.Gas) + (CalculPower() * (decimal)0.3 * Fuels.CO2);
        }
    }
}
