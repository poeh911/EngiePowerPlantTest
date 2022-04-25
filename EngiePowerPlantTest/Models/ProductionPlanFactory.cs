using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngiePowerPlantTest.Models
{
    public static class ProductionPlanFactory
    {
        public static ProductionPlan GetProductionPlan(Powerplant powerplant, Fuels fuels, decimal restToProduce)
        {
            switch (powerplant.Type)
            {
                case Constant.PowerPlantType.Gasfired:
                    return new GasfiredProductionPlan(powerplant, fuels, restToProduce);
                case Constant.PowerPlantType.Turbojet:
                    return new TurbojetProductionPlan(powerplant, fuels, restToProduce);
                case Constant.PowerPlantType.Windturbine:
                    return new WindturbineProductionPlan(powerplant, fuels, restToProduce);
                default:
                    return null;
            }

        }
    }
}
