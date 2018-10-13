using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HFI_API.Models;
using HFI_API.Models.HFI;
using HFI_API.Models.NHL;

namespace HFI_API.Services
{
    public interface INhlApiService
    {
        /// <summary>
        /// Gets the teams.
        /// </summary>
        /// <returns>The teams.</returns>
        List<NhlTeam> GetTeams();

       
        /// <summary>
        /// Gets the team roster.
        /// </summary>
        /// <returns>The team roster.</returns>
        /// <param name="teamId">Roster identifier.</param>
        NhlRoster GetTeamRosterByTeamId(int teamId);

        /// <summary>
        /// Gets the players.
        /// </summary>
        /// <returns>The players.</returns>
        /// <param name="rosterId">Roster identifier.</param>
        List<NhlPerson> GetPlayersByRosterId(int rosterId);

        List<Player> GetPlayersByTeamId(int teamId);

        Task<List<Player>> GetPlayers();
    }
}
