using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 45)]
    public partial class ChallengeJoinResponse
    {
        public ulong ChallengeId; // Assumption
        public byte Unk1;
        public byte Unk2;
        public byte Unk3;
        public uint Unk4;
        [AeroArray(typeof(byte))] public ChallengeJoinResponseUnk5Data Unk5;
        public uint Unk6;
    }

    [AeroBlock]
    public struct ChallengeJoinResponseUnk5Data
    {
        // This may be inaccurate
        public uint Unk1;
        [AeroString] public string Unk2;
        [AeroString] public string Unk3;
        public byte Unk4;
        public byte Unk5;
        public byte Unk6;
    }
}