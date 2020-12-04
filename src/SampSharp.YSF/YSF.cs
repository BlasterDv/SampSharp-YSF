using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
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
        public static void SetPlayerSkinForPlayer(BasePlayer player, BasePlayer skinplayer, int skin)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (skinplayer == null)
                throw new ArgumentNullException(nameof(skinplayer));

            Internal.SetPlayerSkinForPlayer(player.Id, skinplayer.Id, skin);
        }
        public static bool GetPlayerSkinForPlayer(BasePlayer player, BasePlayer skinplayer)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (skinplayer == null)
                throw new ArgumentNullException(nameof(skinplayer));

            return Internal.GetPlayerSkinForPlayer(player.Id, skinplayer.Id);
        }
        public static void SetPlayerNameForPlayer(BasePlayer player, BasePlayer nameplayer, string playername)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (nameplayer == null)
                throw new ArgumentNullException(nameof(nameplayer));

            Internal.SetPlayerNameForPlayer(player.Id, nameplayer.Id, playername);
        }
        public static bool GetPlayerNameForPlayer(BasePlayer player, BasePlayer nameplayer, out string playername, int size)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (nameplayer == null)
                throw new ArgumentNullException(nameof(nameplayer));

            return Internal.GetPlayerNameForPlayer(player.Id, nameplayer.Id, out playername, size);
        }
        public static void SetPlayerFightStyleForPlayer(BasePlayer player, BasePlayer styleplayer, FightStyle style)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (styleplayer == null)
                throw new ArgumentNullException(nameof(styleplayer));

            Internal.SetPlayerFightStyleForPlayer(player.Id, styleplayer.Id, (int)style);
        }
        public static int GetPlayerFightStyleForPlayer(BasePlayer player, BasePlayer skinplayer)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (skinplayer == null)
                throw new ArgumentNullException(nameof(skinplayer));

            return Internal.GetPlayerFightStyleForPlayer(player.Id, skinplayer.Id);
        }

        public static int SetPlayerPosForPlayer(BasePlayer player, BasePlayer posPlayer, Vector3 position, bool forcesync)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            if (posPlayer == null)
                throw new ArgumentNullException(nameof(posPlayer));

            return Internal.SetPlayerPosForPlayer(player.Id, posPlayer.Id, position.X, position.Y, position.Z, forcesync);
        }
        
        public static int SetPlayerRotationQuatForPlayer(BasePlayer player, BasePlayer quatPlayer, Quaternion quat, bool forcesync)
        {
            return Internal.SetPlayerRotationQuatForPlayer(player.Id, quatPlayer.Id, quat.W, quat.X, quat.Y, quat.Z, forcesync);
        }
        
        public static int ApplyAnimationForPlayer(BasePlayer player, BasePlayer animPlayer, string animLib, string animName, float fDelta, bool loop, bool lockX, bool lockY, bool freeze, int time)
        {
            return Internal.ApplyAnimationForPlayer(player.Id, animPlayer.Id, animLib, animName, fDelta, loop, lockX, lockY, freeze, time);
        }
        
        public static int GetPlayerWeather(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerWeather(player.Id);
        }

        public static void TogglePlayerWidescreen(BasePlayer player, bool set)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Internal.TogglePlayerWidescreen(player.Id, set);
        }
        
        public static bool IsPlayerWidescreenToggled(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.IsPlayerWidescreenToggled(player.Id);
        }

        public static void GetSpawnInfo(BasePlayer player, out int teamid, out int modelid, out Vector3 spawn, out float z_angle, out int weapon1, out int weapon1_ammo, out int weapon2, out int weapon2_ammo, out int weapon3, out int weapon3_ammo)
        {
            Internal.GetSpawnInfo(player.Id, out teamid, out modelid, out var spawnX, out var spawnY, out var spawnZ, out z_angle, out weapon1, out weapon1_ammo, out weapon2, out weapon2_ammo, out weapon3, out weapon3_ammo);
            spawn = new Vector3(spawnX, spawnY, spawnZ);
        }
        
        public static int GetPlayerSkillLevel(BasePlayer player, int skill)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerSkillLevel(player.Id, skill);
        }
        
        public static int IsPlayerCheckpointActive(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return IsPlayerCheckpointActive(player);
        }
        
        public static void GetPlayerCheckpoint(BasePlayer player, out Vector3 position, out float fSize)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Internal.GetPlayerCheckpoint(player.Id, out var fX, out var fY, out var fZ, out fSize);
            position = new Vector3(fX, fY, fZ);
        }
        
        public static int IsPlayerRaceCheckpointActive(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.IsPlayerRaceCheckpointActive(player.Id);
        }
        
        public static void GetPlayerRaceCheckpoint(BasePlayer player, out Vector3 position, out Vector3 next, out float fSize)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Internal.GetPlayerRaceCheckpoint(player.Id, out var fX, out var fY, out var fZ, out var fNextX, out var fNextY, out var fNextZ, out fSize);
            position = new Vector3(fX, fY, fZ);
            next = new Vector3(fNextX, fNextY, fNextZ);
        }
        
        public static void GetPlayerWorldBounds(BasePlayer player, out float x_max, out float x_min, out float y_max, out float y_min)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Internal.GetPlayerWorldBounds(player.Id, out x_max, out x_min, out y_max, out y_min);
        }
        
        public static int IsPlayerInModShop(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.IsPlayerInModShop(player.Id);
        }
        
        public static int GetPlayerSirenState(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerSirenState(player.Id);
        }
        
        public static int GetPlayerLandingGearState(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerLandingGearState(player.Id);
        }
        
        public static int GetPlayerHydraReactorAngle(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerHydraReactorAngle(player.Id);
        }
        
        public static float GetPlayerTrainSpeed(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerTrainSpeed(player.Id);
        }
        
        public static float GetPlayerZAim(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerZAim(player.Id);
        }
        
        public static void GetPlayerSurfingOffsets(BasePlayer player, out Vector3 offset)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Internal.GetPlayerSurfingOffsets(player.Id, out var fOffsetX, out var fOffsetY, out var fOffsetZ);
            offset = new Vector3(fOffsetX, fOffsetY, fOffsetZ);
        }
        
        public static void GetPlayerRotationQuat(BasePlayer player, out Quaternion quat)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            Internal.GetPlayerRotationQuat(player.Id, out var w, out var x, out var y, out var z);
            quat = new Quaternion(x, y, z, w);
        }
        
        public static int GetPlayerSpectateID(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerSpectateID(player.Id);
        }

        public static int GetPlayerSpectateType(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return Internal.GetPlayerSpectateType(player.Id);
        }
        
        public static BaseVehicle GetPlayerLastSyncedVehicleID(BasePlayer player)
        {
            if (player == null)
                throw new ArgumentNullException(nameof(player));

            return BaseVehicle.Find(Internal.GetPlayerLastSyncedVehicleID(player.Id));
        }
        
        public static int GetPlayerLastSyncedTrailerID(BasePlayer player)
        {
            return Internal.GetPlayerLastSyncedTrailerID(player.Id);
        }
        
        public static void SendBulletData(BasePlayer senderId, BasePlayer forPlayerId, int weaponid, int hittype, int hitid, float fHitOriginX, float fHitOriginY, float fHitOriginZ, float fHitTargetX, float fHitTargetY, float fHitTargetZ, float fCenterOfHitX, float fCenterOfHitY, float fCenterOfHitZ)
        {
             Internal.SendBulletData(senderId.Id, forPlayerId.Id, weaponid, hittype, hitid, fHitOriginX, fHitOriginY, fHitOriginZ, fHitTargetX, fHitTargetY, fHitTargetZ, fCenterOfHitX, fCenterOfHitY, fCenterOfHitZ);
        }

        public static void SendBulletData(BasePlayer senderId, int weaponid, int hittype, int hitid, float fHitOriginX, float fHitOriginY, float fHitOriginZ, float fHitTargetX, float fHitTargetY, float fHitTargetZ, float fCenterOfHitX, float fCenterOfHitY, float fCenterOfHitZ)
        {
            Internal.SendBulletData(senderId.Id, -1, weaponid, hittype, hitid, fHitOriginX, fHitOriginY, fHitOriginZ, fHitTargetX, fHitTargetY, fHitTargetZ, fCenterOfHitX, fCenterOfHitY, fCenterOfHitZ);
        }

        public static void ShowPlayerForPlayer(BasePlayer forPlayer, BasePlayer player)
        {
            Internal.ShowPlayerForPlayer(forPlayer.Id, player.Id);
        }
        
        public static void HidePlayerForPlayer(BasePlayer forPlayer, BasePlayer player)
        {
            Internal.HidePlayerForPlayer(forPlayer.Id, player.Id);
        }
        
        public static void SetPlayerChatBubbleForPlayer(BasePlayer forPlayer, BasePlayer player, string text, int color, float drawdistance, int expiretime)
        {
            Internal.SetPlayerChatBubbleForPlayer(forPlayer.Id, player.Id, text, color, drawdistance, expiretime);
        }
        
        public static void SetPlayerVersion(BasePlayer player, string version)
        {
            Internal.SetPlayerVersion(player.Id, version);
        }
        
        public static bool IsPlayerSpawned(BasePlayer player)
        {
            return Internal.IsPlayerSpawned(player.Id);
        }
        
        public static bool IsPlayerControllable(BasePlayer player)
        {
            return Internal.IsPlayerControllable(player.Id);
        }
        
        public static void SpawnForWorld(BasePlayer player)
        {
            Internal.SpawnForWorld(player.Id);
        }
    }
}