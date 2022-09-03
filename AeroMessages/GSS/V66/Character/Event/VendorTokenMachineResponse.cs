using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 149)]
    public partial class VendorTokenMachineResponse
    {
        public byte Unk1;
        public byte Unk2;
        public uint Unk3;
        public uint Unk4;
        public byte Unk5;
        [AeroArray(typeof(byte))] VendorTokenThing[] Unk6;
    }

    [AeroBlock]
    public struct VendorTokenThing
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }
}