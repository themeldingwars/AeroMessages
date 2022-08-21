using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 90)]
    public partial class MatchQueue
    {
        [AeroArray(typeof(byte))] public MatchQueueData[] Unk1;
        public ulong Unk2;
        public ulong Unk3;
        [AeroArray(typeof(byte))] public float[] Unk4;
        public uint Unk5;
        public ulong Unk6;
        public uint Unk7;
        public uint Unk8;
        [AeroString] public string Unk9;
        public byte Unk10;
        [AeroString] public string Unk11;
    }

    [AeroBlock]
    public struct MatchQueueData
    {
        public uint Unk1; // Type uncertain
        public uint Unk2; // Type uncertain
    }
}