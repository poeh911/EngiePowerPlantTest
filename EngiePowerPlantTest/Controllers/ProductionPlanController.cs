using EngiePowerPlantTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace EngiePowerPlantTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductionPlanController : ControllerBase
    {
        private ILogger<ProductionPlanController> _logger;

        public ProductionPlanController(ILogger<ProductionPlanController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public IEnumerable<ProductionPlanResponse> Post([FromBody] ProductionPlanRequest request)
        {
            var response = new List<ProductionPlanResponse>();
            foreach (var powerplant in request.Powerplants.OrderByDescending(o => o.Efficiency))
            {
                decimal restToProduce = request.Load - response.Sum(s => s.Power);
                var productionPlan = ProductionPlanFactory.GetProductionPlan(powerplant, request.Fuels, restToProduce);

                if (productionPlan == null)
                    _logger.LogWarning($"ProductionPlan: wrong type: {powerplant.Type}");
                else
                    response.Add(new ProductionPlanResponse()
                    {
                        Name = productionPlan.Powerplant.Name,
                        Power = productionPlan.CalculPower(),
                        Price = productionPlan.CalculPrice()
                    });
            }

            return response;
        }
    }
}
