using SampSharp.Core.Natives.NativeObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF
{
    public partial class YSF
    {
        protected static YSFInternal Internal;

        static YSF()
        {
            Internal = NativeObjectProxyFactory.CreateInstance<YSFInternal>();
        }

        public class YSFInternal
        {
            // YSF settings
            [NativeMethod]
            public virtual bool YSF_SetTickRate(int ticks)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int YSF_GetTickRate()
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]

            public virtual void YSF_EnableNightVisionFix(bool enable)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]

            public virtual bool YSF_IsNightVisionFixEnabled()
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]

            public virtual void YSF_ToggleOnServerMessage(bool toggle)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool YSF_IsOnServerMessageEnabled()
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual void YSF_SetExtendedNetStatsEnabled(bool enable)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool YSF_IsExtendedNetStatsEnabled()
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual void YSF_SetAFKAccuracy(int time_ms)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int YSF_GetAFKAccuracy()
            {
                throw new NativeNotImplementedException();
            }

            // Nickname
            [NativeMethod]
            public virtual bool IsValidNickName(string name)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool AllowNickNameCharacter(int character, bool allow)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool IsNickNameCharacterAllowed(int character)
            {
                throw new NativeNotImplementedException();
            }

            // Classes
            [NativeMethod]
            public virtual int GetAvailableClasses()
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerClass(int classid, out int teamid, out int modelid, out float spawn_x, out float spawn_y, out float spawn_z, out float z_angle, out int weapon1, out int weapon1_ammo, out int weapon2, out int weapon2_ammo, out int weapon3, out int weapon3_ammo)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int EditPlayerClass(int classid, int teamid, int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo)
            {
                throw new NativeNotImplementedException();
            }

            // Timers
            [NativeMethod]
            public virtual int GetRunningTimers()
            {
                throw new NativeNotImplementedException();
            }

            // Per player things
            [NativeMethod]
            public virtual int SetPlayerGravity(int playerid, float gravity)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual float GetPlayerGravity()
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerAdmin(int playerid, bool admin)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerTeamForPlayer(int playerid, int teamplayerid, int teamid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerTeamForPlayer(int playerid, int teamplayerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSkinForPlayer(int playerid, int skinplayerid, int skin)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool GetPlayerSkinForPlayer(int playerid, int skinplayerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool SetPlayerNameForPlayer(int playerid, int nameplayerid, string playername)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool GetPlayerNameForPlayer(int playerid, int nameplayerid, out string playername, int size)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerFightStyleForPlayer(int playerid, int styleplayerid, int style)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerFightStyleForPlayer(int playerid, int skinplayerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerPosForPlayer(int playerid, int posplayerid, float fX, float fY, float fZ, bool forcesync)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerRotationQuatForPlayer(int playerid, int quatplayerid, float w, float x, float y, float z, bool forcesync)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int ApplyAnimationForPlayer(int playerid, int animplayerid, string animlib, string animname, float fDelta, int loop, int lockx, int locky, int freeze, int time)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerWeather(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int TogglePlayerWidescreen(int playerid, bool set)
            {
                throw new NativeNotImplementedException();
            }
        }
    }
}
