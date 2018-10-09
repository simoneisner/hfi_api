using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HFI_API.Services;
using HFI_API.Models;
using HFI_API.Models.NHL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HFI_API.Controllers
{
    [Route("api/[controller]")]
    public class HockeyController : Controller
    {
    
        private INhlApiService _hockeyApiService;
      
        public HockeyController(INhlApiService hockeyApiService)
        {
            _hockeyApiService = hockeyApiService;
        }

        [Route("")]
        public ActionResult<IEnumerable<string>> Index()
        {
            return new string[] { "value1", "value2" };
        }


        [Route("players")]
        public ActionResult<List<NhlPlayer>> GetPlayers(int teamId){
            teamId = teamId == 0 ? 7 : teamId;
            List<NhlPlayer> players = new List<NhlPlayer>();
            NhlRoster roster = new NhlRoster();
            roster   =  _hockeyApiService.GetTeamRosterByTeamId(teamId);
            players = roster.roster;
            return Ok(players);
        }

        /*  // GET: api/values
           [HttpGet]
           public IEnumerable<string> Get()
           {
               return new string[] { "value1", "value2" };
           }

           // GET api/values/5
           [HttpGet("{id}")]
           public string Get(int id)
           {
               return "value";
           }

           // POST api/values
           [HttpPost]
           public void Post([FromBody]string value)
           {
           }

           // PUT api/values/5
           [HttpPut("{id}")]
           public void Put(int id, [FromBody]string value)
           {
           }

           // DELETE api/values/5
           [HttpDelete("{id}")]
           public void Delete(int id)
           {
           }*/
    }
}
