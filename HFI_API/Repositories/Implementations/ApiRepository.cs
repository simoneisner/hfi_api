using System;
using System.Collections.Generic;
using HFI_API.Models;
using HFI_API.Repositories.Interfaces;
namespace HFI_API.Repositories.Implementations
{
    public class ApiRepository : IApiRepository
    {
        public Player GetPlayer(string playerId)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayers()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayers(string teamId)
        {
            throw new NotImplementedException();
        }

        public Team GetTeam(string teamId)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetTeams()
        {
            throw new NotImplementedException();
        }
    }
}
