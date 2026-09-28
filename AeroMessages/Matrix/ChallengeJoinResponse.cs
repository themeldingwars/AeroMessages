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
        public sbyte Success;
        public sbyte Created; // "Created" when set, "Accepted" otherwise
        public sbyte Squad; // joined with the squad
        public uint Unk4; // not passed on by the client
        [AeroArray(typeof(byte))] public ChallengeJoinResponseUnk5Data[] Unk5; // the challenge roster
        public uint Unk6; // selects the roster member with this MemberId
    }

    [AeroBlock]
    public struct ChallengeJoinResponseUnk5Data
    {
        public uint MemberId;
        [AeroString] public string Unk2;
        [AeroString] public string Unk3;
        public byte Unk4;
        public byte Unk5;
        public byte Unk6;
    }
}