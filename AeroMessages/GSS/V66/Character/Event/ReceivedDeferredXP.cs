using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 90)]
    public partial class ReceivedDeferredXP
    {
        [AeroArray(typeof(byte))] public DeferredXPData[] Data;
    }

    [AeroBlock]
    public struct DeferredXPData
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
    }
}