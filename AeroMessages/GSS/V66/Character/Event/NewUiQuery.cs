using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 143)]
    public partial class NewUiQuery
    {
        public ulong Unk1;
        public uint Unk2;
        public uint Unk3;
        [AeroArray(typeof(byte))] public NewUiQuery2x4Data[] Unk4;
    }

    [AeroBlock]
    public struct NewUiQuery2x4Data
    {
        public uint Unk1;
        public uint Unk2;
    }
}