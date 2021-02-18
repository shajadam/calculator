﻿using CalculatorAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculatorAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DefaultController : ApiController
    {
        public IHttpActionResult PostNewStudent(CalculatorViewModel Vmodel)
        {
            decimal? result = 0;
            var Num1 = Vmodel.Number1;
            var Num2 = Vmodel.Number2;
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            if(Vmodel.Operator== Operand.Add)
            {
                result = Num1 + Num2;
            }
            else if (Vmodel.Operator == Operand.Subtract)
            {
                result = Num1 - Num2;

            }
            else if (Vmodel.Operator == Operand.Multiply)
            {

                result = Num1 * Num2;
            }
            else
            {
                result =(Num2!=0)? (decimal?)(Num1 / Num2):null;
            }

            var msg = result != null ? "Invalid division" : "Result is " + result;
            return Ok(result);
        }
    }
}
