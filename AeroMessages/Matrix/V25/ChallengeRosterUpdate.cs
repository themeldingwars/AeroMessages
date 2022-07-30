using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 52)]
    public partial class ChallengeRosterUpdate
    {
        public ulong ChallengeId; // Assumption
        [AeroArray(typeof(byte))] ChallengeRosterUpdateData Updates;
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