using SampSharp.Core.Natives.NativeObjects;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;
using SampSharp.YSF.Events;
using SampSharp.YSF.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF
{
    public partial class YSF
    {
        protected virtual void OnPlayerEnterPlayerGangZone(PlayerGangZone gangZone, PlayerEventArgs e)
        {
            PlayerEnterPlayerGangZone?.Invoke(gangZone, e);
        }
        protected virtual void OnPlayerLeavePlayerGangZone(PlayerGangZone gangZone, PlayerEventArgs e)
        {
            PlayerLeavePlayerGangZone?.Invoke(gangZone, e);   
        }
        protected virtual void OnPlayerPauseStateChange(BasePlayer player, PlayerPauseStateEventArgs e)
        {
            PlayerPauseStateChange?.Invoke(player, e);
        }
        protected virtual void OnPlayerStatsAndWeaponsUpdate(BasePlayer player, PlayerEventArgs e)
        {
            PlayerStatsAndWeaponsUpdate?.Invoke(player, e);
        }
        protected virtual void OnRemoteRCONPacket(RemoteRCONPacketEventArgs e)
        {
            RemoteRCONPacket?.Invoke(this, e);
        }
        protected virtual void OnServerMessage(ServerMessageEventArgs e)
        {
            ServerMessage?.Invoke(this, e);
        }

        public event EventHandler<PlayerEventArgs> PlayerEnterPlayerGangZone;

        public event EventHandler<PlayerEventArgs> PlayerLeavePlayerGangZone;

        public event EventHandler<PlayerPauseStateEventArgs> PlayerPauseStateChange;

        public event EventHandler<PlayerEventArgs> PlayerStatsAndWeaponsUpdate;

        public event EventHandler<RemoteRCONPacketEventArgs> RemoteRCONPacket;

        public event EventHandler<ServerMessageEventArgs> ServerMessage;
    }
}
