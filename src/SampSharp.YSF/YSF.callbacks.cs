using SampSharp.Core.Callbacks;
using SampSharp.Core.Natives.NativeObjects;
using SampSharp.GameMode.World;
using SampSharp.YSF.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF
{
    public partial class YSF
    {

        [Callback]
        internal void OnPlayerPauseStateChange(int playerid, bool pausestate)
        {
            var player = BasePlayer.FindOrCreate(playerid);

            OnPlayerPauseStateChange(player, new PlayerPauseStateEventArgs(player, pausestate));
        }
        [Callback]
        internal void OnPlayerStatsAndWeaponsUpdate(int playerid)
        {
            var player = BasePlayer.FindOrCreate(playerid);

            OnPlayerStatsAndWeaponsUpdate(player, new GameMode.Events.PlayerEventArgs(player));
        }
    }
}
