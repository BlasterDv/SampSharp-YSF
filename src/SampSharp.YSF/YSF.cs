using SampSharp.GameMode;
using SampSharp.GameMode.World;
using System;

namespace SampSharp.YSF
{
    /// <summary>
    /// Represents a service for control the YSF.
    /// </summary>
    public partial class YSF : Extension, IYSF
    {
        public BaseMode GameMode { get; private set; }

        public override void LoadServices(BaseMode gameMode)
        {
            // Add the ysf service to the service provider.
            GameMode = gameMode;
            gameMode.Services.AddService<IYSF>(this);

            base.LoadServices(gameMode);
        }

        public static bool YSF_SetTickRate(int ticks)
        {
            return Internal.YSF_SetTickRate(ticks);
        }
        public static int YSF_GetTickRate()
        {
            return Internal.YSF_GetTickRate();
        }

        public static void YSF_EnableNightVisionFix(bool enable)
        {
            Internal.YSF_EnableNightVisionFix(enable);
        }

        public static bool YSF_IsNightVisionFixEnabled()
        {
            return Internal.YSF_IsNightVisionFixEnabled();
        }

        public static void YSF_ToggleOnServerMessage(bool toggle)
        {
            Internal.YSF_ToggleOnServerMessage(toggle);
        }
        public static bool YSF_IsOnServerMessageEnabled()
        {
            return Internal.YSF_IsOnServerMessageEnabled();
        }
        public static void YSF_SetExtendedNetStatsEnabled(bool enable)
        {
            Internal.YSF_SetExtendedNetStatsEnabled(enable);
        }
        public static bool YSF_IsExtendedNetStatsEnabled()
        {
            return Internal.YSF_IsExtendedNetStatsEnabled();
        }
        public static void YSF_SetAFKAccuracy(int time_ms)
        {
            Internal.YSF_SetAFKAccuracy(time_ms);
        }
        public static int YSF_GetAFKAccuracy()
        {
            return Internal.YSF_GetAFKAccuracy();
        }

        // Nickname
        public static bool IsValidNickName(string name)
        {
            return Internal.IsValidNickName(name);
        }
        public static bool AllowNickNameCharacter(int character, bool allow)
        {
            return Internal.AllowNickNameCharacter(character, allow);
        }
        public static bool IsNickNameCharacterAllowed(int character)
        {
            return Internal.IsNickNameCharacterAllowed(character);
        }

        // Classes
        public static int GetAvailableClasses()
        {
            return Internal.GetAvailableClasses();
        }
        public static void GetPlayerClass(int classid, out int teamid, out int modelid, out Vector3 spawn, out float z_angle, out int weapon1, out int weapon1_ammo, out int weapon2, out int weapon2_ammo, out int weapon3, out int weapon3_ammo)
        {
            Internal.GetPlayerClass(classid, out teamid, out modelid, out var spawn_x, out var spawn_y, out var spawn_z, out z_angle, out weapon1, out weapon1_ammo, out weapon2, out weapon2_ammo, out weapon3, out weapon3_ammo);
            spawn = new Vector3(spawn_x, spawn_y, spawn_z);
        }
        public static int EditPlayerClass(int classid, int teamid, int modelid, Vector3 spawn, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo)
        {
            return Internal.EditPlayerClass(classid, teamid, modelid, spawn.X, spawn.Y, spawn.Z, z_angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
        }

        // Timers
        public static int GetRunningTimers()
        {
            return GetRunningTimers();
        }

        // Per player things
        public static int SetPlayerGravity(BasePlayer player, float gravity)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.SetPlayerGravity(player.Id, gravity);
        }
        public static float GetPlayerGravity(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerGravity(player.Id);
        }
        public static void SetPlayerAdmin(BasePlayer player, bool admin)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Internal.SetPlayerAdmin(player.Id, admin);
        }
        public static void SetPlayerTeamForPlayer(BasePlayer player, BasePlayer teamplayer, int teamid)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (teamplayer == null)
                throw new ArgumentNullException(nameof(teamplayer));

            Internal.SetPlayerTeamForPlayer(player.Id, teamplayer.Id, teamid);
        }
        public static int GetPlayerTeamForPlayer(BasePlayer player, BasePlayer teamplayer)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (teamplayer == null)
                throw new ArgumentNullException(nameof(teamplayer));

            return Internal.GetPlayerTeamForPlayer(player.Id, teamplayer.Id);
        }
    }
}