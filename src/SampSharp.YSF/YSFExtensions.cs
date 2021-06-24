using SampSharp.GameMode;
using SampSharp.GameMode.Display;

namespace SampSharp.YSF
{
    public static class YSFExtensions
    {
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
