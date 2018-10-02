using System;
using System.Collections.Generic;
using HFI_API.Models;

namespace HFI_API.Repositories.Interfaces
{
    public interface IApiRepository
    {
        Player GetPlayer(string playerId);
        List<Player> GetPlayers();
        List<Player> GetPlayers(string teamId);

        Team GetTeam(string teamId);
        List<Team> GetTeams();

    }
}
