using SampSharp.GameMode;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.World;

namespace SampSharp.YSF
{
    public static class YSFExtensions
    {
        // Pause functions
        public static bool IsPaused(this BasePlayer player)
        {
            return YSF.Internal.IsPlayerPaused(player.Id) == 1 ? true : false;
        }
        public static int GetPausedTime(this BasePlayer player)
        {
            return YSF.Internal.GetPlayerPausedTime(player.Id);
        }

        public static void SetPosition(this TextDraw textDraw, Vector2 position)
        {
            YSF.Internal.TextDrawSetPos(textDraw.Id, position.X, position.Y);
        }

        public static void SetPosition(this PlayerTextDraw playerTextDraw, Vector2 position)
        {
            YSF.Internal.PlayerTextDrawSetPos(playerTextDraw.Owner.Id, playerTextDraw.Id, position.X, position.Y);
        }
    }
}
