using SampSharp.Core.Callbacks;
using SampSharp.GameMode.World;
using SampSharp.YSF.Events;
using SampSharp.YSF.World;
using System;

namespace SampSharp.YSF
{
    public partial class YSF
    {
        [Callback]
        internal void OnPlayerEnterPlayerGangZone(int playerid, int zoneid)
        {
            var player = BasePlayer.FindOrCreate(playerid);

            var gangZone = PlayerGangZone.Find(player, zoneid);

            if (gangZone == null)
                return;

            OnPlayerEnterPlayerGangZone(gangZone, new GameMode.Events.PlayerEventArgs(player));
        }

        [Callback]
        internal void OnPlayerLeavePlayerGangZone(int playerid, int zoneid)
        {
            var player = BasePlayer.FindOrCreate(playerid);

            var gangZone = PlayerGangZone.Find(player, zoneid);

            if (gangZone == null)
                return;

            OnPlayerLeavePlayerGangZone(gangZone, new GameMode.Events.PlayerEventArgs(player));
        }

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

        [Callback]
        internal void OnRemoteRCONPacket(string ipaddr, int port, string password, int success, string command)
        {
            OnRemoteRCONPacket(new RemoteRCONPacketEventArgs(ipaddr, port, password, success, command));
        }

        [Callback]
        internal void OnServerMessage(string msg)
        {
            OnServerMessage(new ServerMessageEventArgs(msg));
        }
    }
}
