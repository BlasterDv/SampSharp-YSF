# SampSharp YSF

Wrapper of the YSF plugin for [SampSharp]

[SampSharp]:https://github.com/ikkentim/SampSharp/

Getting Started
--------------

SampSharp.GameMode
```C#
using SampSharp.GameMode.SAMP.Commands;
using SampSharp.GameMode.World;
using SampSharp.GameMode;
using SampSharp.YSF;

namespace Test
{
    public class Commands
    {
        [Command("test")]
        private static void test(BasePlayer player)
        {
            if(!player.IsPaused())
            {
              var textDraw = new TextDraw(new Vector2(0.0f, 0.0f), "TextDraw");
              textDraw.SetPosition(new Vector2(10.0f, 10.0f));
            }
        }
    }
}
```
