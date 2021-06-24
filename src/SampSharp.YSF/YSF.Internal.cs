using SampSharp.Core.Natives.NativeObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF
{
    public partial class YSF
    {
        public static YSFInternal Internal { get; }

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
            public virtual float GetPlayerGravity(int playerid)
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
            public virtual int ApplyAnimationForPlayer(int playerid, int animplayerid, string animlib, string animname, float fDelta, bool loop, bool lockx, bool locky, bool freeze, int time)
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
            [NativeMethod]
            public virtual bool IsPlayerWidescreenToggled(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetSpawnInfo(int playerid, out int teamid, out int modelid, out float spawn_x, out float spawn_y, out float spawn_z, out float z_angle, out int weapon1, out int weapon1_ammo, out int weapon2, out int weapon2_ammo, out int weapon3, out int weapon3_ammo)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerSkillLevel(int playerid, int skill)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int IsPlayerCheckpointActive(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual void GetPlayerCheckpoint(int playerid, out float fX, out float fY, out float fZ, out float fSize)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int IsPlayerRaceCheckpointActive(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerRaceCheckpoint(int playerid, out float fX, out float fY, out float fZ, out float fNextX, out float fNextY, out float fNextZ, out float fSize)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerWorldBounds(int playerid, out float x_max, out float x_min, out float y_max, out float y_min)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int IsPlayerInModShop(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerSirenState(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerLandingGearState(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerHydraReactorAngle(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual float GetPlayerTrainSpeed(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual float GetPlayerZAim(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerSurfingOffsets(int playerid, out float fOffsetX, out float fOffsetY, out float fOffsetZ)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerRotationQuat(int playerid, out float w, out float x, out float y, out float z)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerSpectateID(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerSpectateType(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerLastSyncedVehicleID(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerLastSyncedTrailerID(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SendBulletData(int sender, int forplayerid, int hitid, int hittype, int weaponid, float fHitOriginX, float fHitOriginY, float fHitOriginZ, float fHitTargetX, float fHitTargetY, float fHitTargetZ, float fCenterOfHitX, float fCenterOfHitY, float fCenterOfHitZ)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int ShowPlayerForPlayer(int forplayerid, int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int HidePlayerForPlayer(int forplayerid, int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerChatBubbleForPlayer(int forplayerid, int playerid, string text, int color, float drawdistance, int expiretime)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerVersion(int playerid, string version)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool IsPlayerSpawned(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual bool IsPlayerControllable(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SpawnForWorld(int playerid)
            {
                throw new NativeNotImplementedException();
            }

            //
            [NativeMethod]
            public virtual int TogglePlayerGhostMode(int playerid, bool toggle)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod]
            public virtual int GetPlayerGhostMode(int playerid)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod]
            public virtual int SetPlayerSyncKeys(int playerid, int keys, int updown, int leftright)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod]
            public virtual int SetPlayerSyncPos(int playerid, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod]
            public virtual int SetPlayerSyncVelocity(int playerid, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod]
            public virtual int SetPlayerSyncRotationQuat(int playerid, float w, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncCameraFrontVector(int playerid, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncCameraPos(int playerid, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncCameraMode(int playerid, int mode)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncWeapon(int playerid, int weaponid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int GetPlayerSyncWeapon(int playerid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncWeaponState(int playerid, int weaponstate)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncSpecialAction(int playerid, int actionid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncHealth(int playerid, float health)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncArmour(int playerid, float armour)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncPosition(int playerid, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncVehicleId(int playerid, int vehicleid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncVehicleSeat(int playerid, int seat)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncVehiclePosition(int playerid, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncVehicleVelocity(int playerid, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncVehicleRotQuat(int playerid, float w, float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncVehicleHealth(int playerid, float health)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SetPlayerSyncTrainSpeed(int playerid, float speed)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int SendPlayerDeath(int playerid, int forplayerid = -1)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int UpdatePlayerSyncData(int playerid, int type = -1)
            {
                throw new NativeNotImplementedException();
            }

            // Textdraw - Global
            [NativeMethod]
            public virtual void TextDrawSetPos(int textdrawid, float fX, float fY) // You can change textdraw pos with it, but you need to use TextDrawShowForPlayer() after that
            {
                throw new NativeNotImplementedException();
            }

            // Textdraw - Player
            [NativeMethod]
            public virtual void PlayerTextDrawSetPos(int playerid, int textdrawid, float fX, float fY)
            {
                throw new NativeNotImplementedException();
            }
        }
    }
}
