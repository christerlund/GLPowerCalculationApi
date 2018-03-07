using GLPowerCalculationApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GLPowerCalculationApi.Controllers
{
    [Route("api/[controller]")]
    public class PowerController : Controller
    {
        /// <summary>
        /// Simple method for calculating : "Strøm på I2 ved symmetrisk last i 3 fas system"
        /// </summary>
        /// <param name="item"> </param>
        /// <returns> Calculated value for I2</returns>

        // POST api/power
        [HttpPost]
        public string Post([FromBody]CalculationItem item)
        {
            double I2 = 0;
       
            try
            {
                if (!ModelState.IsValid) { return "Model is invalid"; }

                I2 = CalculatePower(item);
            }
            catch (Exception e)
            {
                return e.Message;
            }
   
                  
            return string.Format("{{\"I2\":{0}}}", I2.ToString()); ;
        }

        private static double CalculatePower(CalculationItem item)
        {
            return (((item.P * Math.Sqrt(3)) - (item.U1 * item.I1) - (item.U3 * item.I3)) / item.U2);
        }

    }
}
