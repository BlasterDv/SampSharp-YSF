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
    }
}