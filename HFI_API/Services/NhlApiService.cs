using System;
using HFI_API.Models;
using Microsoft.Extensions.Configuration;
using RestSharp;
using Flurl;
using Newtonsoft.Json;
using System.Collections.Generic;
using HFI_API.Models.NHL;
using HFI_API.Models.HFI;
using System.Threading.Tasks;
using System.Linq;

namespace HFI_API.Services
{
    public class NhlApiService:INhlApiService
    {
        readonly IConfiguration _configuration;
        readonly string _externalApiRoot;
        readonly string _externalApiKey;

        public NhlApiService(IConfiguration configuration)
        {
            _configuration = configuration;
            _externalApiRoot = _configuration.GetSection("ExternalHockeyApiEndpoint").Value;
            _externalApiKey = _configuration.GetSection("ExternalHockeyApiKey").Value;
        }


        public void Index()
        {
            throw new NotImplementedException();
        }

            

       
        /// <summary>
        /// Get a list of teams
        /// </summary>
        /// <returns>A list of type "Team"</returns>
        public List<NhlTeam> GetTeams()
        {
            List<NhlTeam> teams = new List<NhlTeam>();
            string url = _externalApiRoot.AppendPathSegment("teams");

            //TODO: USE FACTORY HERE?
            //.SetQueryParam("api_key", "dswtyyp5acknms3meetzj7zp");

            var client = new RestClient(url);
            var response = client.Execute<List<NhlTeam>>(new RestRequest());
            NhlTeamList teamList = JsonConvert.DeserializeObject<NhlTeamList>(response.Content);
            teams = teamList.teams;
            return teams;
            
        }




        public NhlRoster GetTeamRosterByTeamId(int teamId)
        {
            NhlRoster roster = new NhlRoster();
            string url = _externalApiRoot.AppendPathSegment("teams")
                                         .AppendPathSegment(teamId)
                                         .AppendPathSegment("roster");

            var client = new RestClient(url);
            var response = client.Execute<NhlRoster>(new RestRequest());
            return JsonConvert.DeserializeObject<NhlRoster>(response.Content);
        }



        public List<NhlPerson> GetPlayersByRosterId(int rosterId)
        {
            List<NhlPerson> players = new List<NhlPerson>();
            string url = _externalApiKey.AppendPathSegment("people")
                                        .AppendPathSegment(rosterId)
                                        .SetQueryParam("hydrate", "stats(splits = statsSingleSeason)");

            var client = new RestClient(url);
            var response = client.Execute<List<NhlPerson>>(new RestRequest());

            return JsonConvert.DeserializeObject<List<NhlPerson>>(response.Content);
        }

        public async Task<List<Player>> GetPlayers()
        {
            List<Player> players = new List<Player>();
            List<NhlTeam> teams = new List<NhlTeam>();

            teams = GetTeams();

            Parallel.ForEach(teams.ToList(), (team) =>
            {
                int teamId = team.id;
                GetPlayersByTeamId(teamId).ForEach(p => players.Add(p));
            });
   
            return players;
        }


        public List<Player> GetPlayersByTeamId(int teamId)
        {

            List<NhlPlayer> nhlPlayers = new List<NhlPlayer>();
            List<Player> hfiPlayers = new List<Player>();
            NhlRoster roster = GetTeamRosterByTeamId(teamId);

            nhlPlayers = roster.roster;
            
            //TODO: map objects without foreach
            //TODO: check null or count
            foreach(NhlPlayer nhlPlayer in nhlPlayers)
            {
                Player player = new Player();
                player.nhlPlayer = nhlPlayer;
                player.nhlPlayerStatsContainer = new NhlPlayerStatsContainer();
                NhlPlayerStatsContainer container =  GetPlayerStats(nhlPlayer.person.id);
                player.nhlPlayerStatsContainer = container;
                hfiPlayers.Add(player);
                //break;
            }



            return hfiPlayers;
        }

        public NhlPlayerStatsContainer GetPlayerStats(int playerId)
        {

            NhlPlayerStatsContainer container = new NhlPlayerStatsContainer();
            string url = _externalApiRoot.AppendPathSegment("people")
                                        .AppendPathSegment(playerId)
                                        .AppendPathSegment("stats")
                                        .SetQueryParam("stats", "statsSingleSeason")
                                        .SetQueryParam("season",_configuration.GetSection("CurrentSeason").Value);

            var client = new RestClient(url);
            var response = client.Execute<NhlPlayerStatsContainer>(new RestRequest());
            container = JsonConvert.DeserializeObject<NhlPlayerStatsContainer>(response.Content);
            return container;
        }
    }
}
