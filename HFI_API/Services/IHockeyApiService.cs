using System;
using System.Collections.Generic;
using HFI_API.Models;

namespace HFI_API.Services
{
    public interface IHockeyApiService
    {
        void Index();
        /// <summary>
        /// Get list of players
        /// </summary>
        /// <returns>List of Type Player</returns>
        List<Player> GetPlayers();

        /// <summary>
        /// Gets the players by team.
        /// </summary>
        /// <returns>List of Players associated with a Team.</returns>
        /// <param name="team_id">Team identifier.</param>
        List<Player> GetPlayersByTeam(string team_id);
    }


}
