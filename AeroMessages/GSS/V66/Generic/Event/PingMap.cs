using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 110)]
    public partial class PingMap
    {   
        public Vector3 Position;

        [AeroArray(4)]
        public byte[] Unk1;
    }
}