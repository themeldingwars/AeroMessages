using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 138)]
    public partial class FoundResourceAreas
    {
        [AeroArray(typeof(byte))] public ResourceAreaData[] Data;
    }

    [AeroBlock]
    public struct ResourceAreaData
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
        public uint Unk5;
    }
}