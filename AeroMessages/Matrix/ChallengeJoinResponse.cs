using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeJoinResponse, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ChallengeJoinResponse
    {
        public ulong ChallengeId; // Assumption
        public sbyte Unk1;
        public sbyte Unk2;
        public sbyte Unk3;
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