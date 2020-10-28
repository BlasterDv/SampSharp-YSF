using SampSharp.Core.Natives.NativeObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF.World
{
    public partial class PlayerGangZone
    {
        public class PlayerGangZoneInternal : NativeObjectSingleton<PlayerGangZoneInternal>
        {
            [NativeMethod]
            public virtual int CreatePlayerGangZone(int playerid, float minx, float miny, float maxx, float maxy)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int PlayerGangZoneDestroy(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int PlayerGangZoneShow(int playerid, int zoneid, int color)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int PlayerGangZoneHide(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int PlayerGangZoneFlash(int playerid, int zoneid, int color)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int PlayerGangZoneStopFlash(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int IsValidPlayerGangZone(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int IsPlayerInPlayerGangZone(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int IsPlayerGangZoneVisible(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int PlayerGangZoneGetColor(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int PlayerGangZoneGetFlashColor(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int IsPlayerGangZoneFlashing(int playerid, int zoneid)
            {
                throw new NativeNotImplementedException();
            }
            [NativeMethod]
            public virtual int PlayerGangZoneGetPos(int playerid, int zoneid, out float fMinX, out float fMinY, out float fMaxX, out float fMaxY)
            {
                throw new NativeNotImplementedException();
            }
        }
    }
}
