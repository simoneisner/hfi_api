using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HFI_API.Services;
using HFI_API.Models;
using HFI_API.Models.NHL;
using HFI_API.Models.HFI;

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

        //TODO: Make these calls Async, as well as the RestSharp calls.
        [Route("players")]
        public ActionResult<List<Player>> GetPlayers(int teamId){
            teamId = teamId == 0 ? 7 : teamId;
            List<Player> players = new List<Player>();
            NhlRoster roster = new NhlRoster();
            players   =  _hockeyApiService.GetPlayersByTeamId(teamId);

            return Ok(players);
        }
        
    }
}
