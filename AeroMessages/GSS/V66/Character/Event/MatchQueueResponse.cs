using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 146)]
    public partial class MatchQueueResponse
    {
        public sbyte Unk1;
        public byte Unk2;
        [AeroArray(typeof(byte))] public ulong[] Unk3;
        public uint Unk4;
        public ulong Unk5;
        public ulong Unk6;
        public uint Unk7;
    }
}