using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 44)]
    public partial class MatchLoadingState
    {
        public sbyte Unk1;
        [AeroArray(typeof(byte))] public MatchLoadingStateData[] Unk2;
    }

    [AeroBlock]
    public struct MatchLoadingStateData
    {
        public ulong Unk1;
        [AeroString] public string Unk2;
        public byte Unk3;
    }
}