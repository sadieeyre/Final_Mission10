using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BowlerAPI.Data;
using BowlerAPI.Data;

namespace BowlerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRespository;
        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRespository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRespository.Bowlers.ToArray();
            return bowlerData;
        }
    }
}