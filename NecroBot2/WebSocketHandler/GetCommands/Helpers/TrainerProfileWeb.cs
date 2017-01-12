﻿#region using directives

using POGOProtos.Data;
using POGOProtos.Data.Player;

#endregion

namespace NecroBot2.WebSocketHandler.GetCommands.Helpers
{
    internal class TrainerProfileWeb
    {
        public PlayerData Profile;
        public PlayerStats Stats;

        public TrainerProfileWeb(PlayerData profile, PlayerStats stats)
        {
            Profile = profile;
            Stats = stats;
        }
    }
}