using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 83)]
    public partial class MissionCompletionCounts
    {
        [AeroArray(typeof(byte))] public MissionCompletionCountsData[] Unk1;
        [AeroString] public string Unk2;
    }

    [AeroBlock]
    public struct MissionCompletionCountsData
    {
        public uint Unk1;
        public ulong Unk2;
        public uint Unk3;
    }
}