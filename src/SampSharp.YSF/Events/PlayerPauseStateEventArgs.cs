using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF.Events
{
    public class PlayerPauseStateEventArgs : PlayerEventArgs
    {
        public PlayerPauseStateEventArgs(BasePlayer player, bool pauseState)
            : base(player)
        {
            PauseState = pauseState;
        }

        public bool PauseState { get; }
    }
}
