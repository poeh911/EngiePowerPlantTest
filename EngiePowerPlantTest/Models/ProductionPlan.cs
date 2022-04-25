namespace EngiePowerPlantTest.Models
{
    public abstract class ProductionPlan
    {
        public abstract string Type { get; }
        public abstract Powerplant Powerplant { get; }
        public abstract Fuels Fuels { get; }
        public abstract decimal RestToProduce { get; }
        public abstract decimal CalculPower();
        public abstract decimal CalculPrice();
    }
}
