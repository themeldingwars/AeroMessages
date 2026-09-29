using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.VendorTokenMachineResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class VendorTokenMachineResponse
    {
        public VendorTokenMachineAction Action;
        public byte Unk2;
        public uint VendorId;
        public uint TokenId;
        public VendorTokenMachineState State;
        [AeroArray(typeof(byte))] public VendorTokenThing[] Items;
    }

    [AeroBlock]
    public struct VendorTokenThing
    {
        public uint ItemSdbId;
        public uint Quantity;
        public uint Quality;
    }
}