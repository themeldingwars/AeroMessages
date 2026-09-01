using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.VendorTokenMachineResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class VendorTokenMachineResponse
    {
        public byte Unk1;
        public byte Unk2;
        public uint Unk3;
        public uint Unk4;
        public byte Unk5;
        [AeroArray(typeof(byte))] public VendorTokenThing[] Unk6;
    }

    [AeroBlock]
    public struct VendorTokenThing
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }
}