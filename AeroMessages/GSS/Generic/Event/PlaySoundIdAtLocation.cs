using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.PlaySoundIdAtLocation, GssVersion.V1, GssVersion.V67)]
    public partial class PlaySoundIdAtLocation
    {
        public long Unk1; // An int64?
        public Vector3 Position;
    }
}