using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 121)]
    public partial class VendorPurchaseResponse
    {
        public byte Unk1;
        public ulong Unk2;
        public ulong Unk3;
        public uint Unk4;
        [AeroString] public string Unk5;
    }
}