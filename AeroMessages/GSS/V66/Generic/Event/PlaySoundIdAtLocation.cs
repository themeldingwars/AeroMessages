using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 107)]
    public partial class PlaySoundIdAtLocation
    {   
        public long Unk1; // An int64?
        public Vector3 Position;
    }
}