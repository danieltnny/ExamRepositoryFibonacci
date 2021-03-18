using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FibonacciAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {
        private IFibonacciService _fibonacciService;

        public FibonacciController(IFibonacciService fibonacciService)
        {
            _fibonacciService = fibonacciService;
        }

        [HttpGet("v1/{index}")]
        public ActionResult getFibonacciByIndex_v1 (int index){
            try{
                var result = new {result =_fibonacciService.getFibonacciByIndex_v1(index)};
                return Ok(result);
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("v2/{index}")]
        public ActionResult getFibonacciByIndex_v2 (int index){
            try{
                var result = new {result =_fibonacciService.getFibonacciByIndex_v2(index)};
                return Ok(result);
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }
    }
}
