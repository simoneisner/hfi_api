using System;
using HFI_API.Repositories.Interfaces;
using HFI_API.Repositories.Implementations;
using System.Collections.Generic;
using HFI_API.Models;
using Microsoft.Extensions.Configuration;
using RestSharp;
using Flurl;
using Newtonsoft.Json;

namespace HFI_API.Services
{
    public class HockeyApiService:IHockeyApiService
    {

        private readonly IConfiguration _configuration;
        private readonly string _externalApiRoot;

        public HockeyApiService(IConfiguration configuration)
        {
            _configuration = configuration;
            _externalApiRoot = _configuration.GetSection("ExternalHockeyApiEndpoint").Value;
        }



        public void Index()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All Players in League
        /// </summary>
        /// <returns>List of Type Player</returns>
        public List<Player> GetPlayersByTeam(string team_id){
            List<Player> players = new List<Player>();

            var url = _externalApiRoot.AppendPathSegment("teams")
                                      .AppendPathSegment("4415ce44-0f24-11e2-8525-18a905767e44")
                                      .AppendPathSegment("profile.json")
                                      .SetQueryParam("api_key", new { api_key = "dswtyyp5acknms3meetzj7zp" });
                                      //.SetQueryParam(new{ api_key = "dswtyyp5acknms3meetzj7zp"});

            return players;
        }

        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();
            Team team = GetTeam();
            return team.players;
        }

        public Team GetTeam()
        {
            Team team = new Team();
            string url = _externalApiRoot.ToString().AppendPathSegment("teams")
                        .AppendPathSegment("4415ce44-0f24-11e2-8525-18a905767e44")
                        .AppendPathSegment("profile.json")
                        .SetQueryParam("api_key", "dswtyyp5acknms3meetzj7zp");

            var client = new RestClient(url);
            var response = client.Execute<Team>(new RestRequest());

            team = JsonConvert.DeserializeObject<Team>(response.Content);

            return team;
        }

    }
}
