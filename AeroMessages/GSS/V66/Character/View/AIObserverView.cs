using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 10, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 10, 3)]
    public partial class AIObserverView
    {
        // TODO Meaningless
        /*
        ListenerId       = 0x00,
        SpawnTime        = 0x01,
        Wallet           = 0x02,
        ScopeBubbleInfo  = 0x03,
         */
    }
}