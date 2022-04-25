namespace EngiePowerPlantTest.Models
{
    public class TurbojetProductionPlan : ProductionPlan
    {
        public override string Type => Constant.PowerPlantType.Turbojet;

        public TurbojetProductionPlan(Powerplant powerplant, Fuels fuels, decimal restToProduce)
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
            return CalculPower() * Fuels.Kerosine;
        }
    }
}
