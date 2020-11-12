using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.YSF.Definitions
{
    public enum PlayerConnectMode
    {
        NoAction,
        DisconnectAsap,
        DisconnectAsapSilently,
        DisconnectOnNoAck,
        RequestedConnection,
        HandlingConnectionRequest,
        UnverifiedSender,
        SetEncryptionOnMultiple16B,
        Connected
    }
}
