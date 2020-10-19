using SampSharp.Core.Natives.NativeObjects;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using SampSharp.YSF.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF
{
    public partial class YSF
    {
        protected virtual void OnPlayerPauseStateChange(BasePlayer player, PlayerPauseStateEventArgs e)
        {
            PlayerPauseStateChange?.Invoke(player, e);
        }
        protected virtual void OnPlayerStatsAndWeaponsUpdate(BasePlayer player, PlayerEventArgs e)
        {
            PlayerStatsAndWeaponsUpdate?.Invoke(player, e);
        }

        public event EventHandler<PlayerPauseStateEventArgs> PlayerPauseStateChange;
        public event EventHandler<PlayerEventArgs> PlayerStatsAndWeaponsUpdate;

    }
}
