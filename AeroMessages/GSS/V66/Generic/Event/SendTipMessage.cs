using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 92)]
    public partial class SendTipMessage
    {   
        public byte Unk1;
        public uint Unk2;
        public uint Unk3;
        public half Unk4;
        public sbyte Unk5;
    }
}