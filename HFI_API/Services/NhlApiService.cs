using System;
using HFI_API.Models;
using Microsoft.Extensions.Configuration;
using RestSharp;
using Flurl;
using Newtonsoft.Json;
using System.Collections.Generic;
using HFI_API.Models.NHL;

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
            return JsonConvert.DeserializeObject<List<NhlTeam>>(response.Content);
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

        public List<NhlPlayer> GetPlayersByTeamId(int teamId)
        {
            List<NhlPlayer> players = new List<NhlPlayer>();

            NhlRoster roster = GetTeamRosterByTeamId(teamId);
            players = roster.roster;

            return players;
        }
    }
}
