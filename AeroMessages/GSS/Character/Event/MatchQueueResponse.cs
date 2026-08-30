using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.MatchQueueResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
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