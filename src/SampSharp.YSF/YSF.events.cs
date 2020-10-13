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
        protected virtual void OnPlayerPauseStateChange(BasePlayer @object, PlayerPauseStateEventArgs e)
        {
            PlayerPauseStateChange?.Invoke(@object, e);
        }

        public event EventHandler<PlayerPauseStateEventArgs> PlayerPauseStateChange;

    }
}
