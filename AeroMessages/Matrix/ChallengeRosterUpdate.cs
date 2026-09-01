using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeRosterUpdate, MatrixVersion.V5, MatrixVersion.V26)]
    public partial class ChallengeRosterUpdate
    {
        public ulong ChallengeId; // Assumption
        [AeroArray(typeof(byte))] public ChallengeRosterUpdateData Updates;
    }

    [AeroBlock]
    public struct ChallengeRosterUpdateData
    {
       public ulong Unk1;
       [AeroString] public string Unk2;
       public byte Unk3;
       public uint Unk4;
       public byte Unk5;
    }
}