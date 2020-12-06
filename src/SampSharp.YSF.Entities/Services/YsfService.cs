using System;
using System.Collections.Generic;
using System.Text;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace SampSharp.YSF.Entities
{
    public class YsfService : IYsfService
    {
        private readonly YsfServiceNative _native;

        /// <summary>
        /// Initializes a new instance of the <see cref="YsfService" /> class.
        /// </summary>
        public YsfService(INativeProxy<YsfServiceNative> nativeProxy)
        {
            _native = nativeProxy.Instance;
        }

        public bool YSF_SetTickRate(int ticks)
        {
            return _native.YSF_SetTickRate(ticks);
        }
        public int YSF_GetTickRate()
        {
            return _native.YSF_GetTickRate();
        }

        public void YSF_EnableNightVisionFix(bool enable)
        {
            _native.YSF_EnableNightVisionFix(enable);
        }

        public bool YSF_IsNightVisionFixEnabled()
        {
            return _native.YSF_IsNightVisionFixEnabled();
        }

        public void YSF_ToggleOnServerMessage(bool toggle)
        {
            _native.YSF_ToggleOnServerMessage(toggle);
        }
        public bool YSF_IsOnServerMessageEnabled()
        {
            return _native.YSF_IsOnServerMessageEnabled();
        }
        public void YSF_SetExtendedNetStatsEnabled(bool enable)
        {
            _native.YSF_SetExtendedNetStatsEnabled(enable);
        }
        public bool YSF_IsExtendedNetStatsEnabled()
        {
            return _native.YSF_IsExtendedNetStatsEnabled();
        }
        public void YSF_SetAFKAccuracy(int time_ms)
        {
            _native.YSF_SetAFKAccuracy(time_ms);
        }
        public int YSF_GetAFKAccuracy()
        {
            return _native.YSF_GetAFKAccuracy();
        }

        #region Nickname
        public bool IsValidNickName(string name)
        {
            return _native.IsValidNickName(name);
        }
        public bool AllowNickNameCharacter(int character, bool allow)
        {
            return _native.AllowNickNameCharacter(character, allow);
        }
        public bool IsNickNameCharacterAllowed(int character)
        {
            return _native.IsNickNameCharacterAllowed(character);
        }
        #endregion

        #region Classes
        public int GetAvailableClasses()
        {
            return _native.GetAvailableClasses();
        }
        public void GetPlayerClass(int classid, out int teamid, out int modelid, out Vector3 spawn, out float z_angle, out int weapon1, out int weapon1_ammo, out int weapon2, out int weapon2_ammo, out int weapon3, out int weapon3_ammo)
        {
            _native.GetPlayerClass(classid, out teamid, out modelid, out var spawn_x, out var spawn_y, out var spawn_z, out z_angle, out weapon1, out weapon1_ammo, out weapon2, out weapon2_ammo, out weapon3, out weapon3_ammo);
            spawn = new Vector3(spawn_x, spawn_y, spawn_z);
        }
        public int EditPlayerClass(int classid, int teamid, int modelid, Vector3 spawn, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo)
        {
            return _native.EditPlayerClass(classid, teamid, modelid, spawn.X, spawn.Y, spawn.Z, z_angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
        }
        #endregion
    }
}
