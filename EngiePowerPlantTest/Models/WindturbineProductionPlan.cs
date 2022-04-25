using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngiePowerPlantTest.Models
{
    public class WindturbineProductionPlan : ProductionPlan
    {
        public override string Type => Constant.PowerPlantType.Windturbine;

        public WindturbineProductionPlan(Powerplant powerplant, Fuels fuels, decimal restToProduce)
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
            decimal windPower = Powerplant.PMax * Fuels.Wind / 100;
            return windPower > RestToProduce ? RestToProduce : windPower;
        }
        public override decimal CalculPrice()
        {
            return 0;
        }
    }
}
