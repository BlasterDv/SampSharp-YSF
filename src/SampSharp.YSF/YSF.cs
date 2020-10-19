using SampSharp.GameMode;
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

        public bool YSF_SetTickRate(int ticks)
        {
            return Internal.YSF_SetTickRate(ticks);
        }
        public int YSF_GetTickRate()
        {
            return Internal.YSF_GetTickRate();
        }

        public void YSF_EnableNightVisionFix(bool enable)
        {
            Internal.YSF_EnableNightVisionFix(enable);
        }

        public bool YSF_IsNightVisionFixEnabled()
        {
            return Internal.YSF_IsNightVisionFixEnabled();
        }

        public void YSF_ToggleOnServerMessage(bool toggle)
        {
            Internal.YSF_ToggleOnServerMessage(toggle);
        }
        public bool YSF_IsOnServerMessageEnabled()
        {
            return Internal.YSF_IsOnServerMessageEnabled();
        }
        public void YSF_SetExtendedNetStatsEnabled(bool enable)
        {
            Internal.YSF_SetExtendedNetStatsEnabled(enable);
        }
        public bool YSF_IsExtendedNetStatsEnabled()
        {
            return Internal.YSF_IsExtendedNetStatsEnabled();
        }
        public void YSF_SetAFKAccuracy(int time_ms)
        {
            Internal.YSF_SetAFKAccuracy(time_ms);
        }
        public int YSF_GetAFKAccuracy()
        {
            return Internal.YSF_GetAFKAccuracy();
        }

        // Nickname
        public bool IsValidNickName(string name)
        {
            return Internal.IsValidNickName(name);
        }
        public bool AllowNickNameCharacter(int character, bool allow)
        {
            return Internal.AllowNickNameCharacter(character, allow);
        }
        public bool IsNickNameCharacterAllowed(int character)
        {
            return Internal.IsNickNameCharacterAllowed(character);
        }

        // Classes
        public int GetAvailableClasses()
        {
            return Internal.GetAvailableClasses();
        }
        public void GetPlayerClass(int classid, out int teamid, out int modelid, out Vector3 spawn, out float z_angle, out int weapon1, out int weapon1_ammo, out int weapon2, out int weapon2_ammo, out int weapon3, out int weapon3_ammo)
        {
            Internal.GetPlayerClass(classid, out teamid, out modelid, out var spawn_x, out var spawn_y, out var spawn_z, out z_angle, out weapon1, out weapon1_ammo, out weapon2, out weapon2_ammo, out weapon3, out weapon3_ammo);
            spawn = new Vector3(spawn_x, spawn_y, spawn_z);
        }
        public int EditPlayerClass(int classid, int teamid, int modelid, Vector3 spawn, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo)
        {
            return Internal.EditPlayerClass(classid, teamid, modelid, spawn.X, spawn.Y, spawn.Z, z_angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
        }

        // Timers
        public int GetRunningTimers()
        {
            return GetRunningTimers();
        }
    }
}