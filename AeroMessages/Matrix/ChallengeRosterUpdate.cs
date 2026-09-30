using System;
using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeRosterUpdate, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ChallengeRosterUpdate
    {
        public ulong ChallengeId;
        [AeroArray(typeof(byte))] public ChallengeRosterUpdateData[] Updates; // replaces the whole roster
    }

    [AeroBlock]
    public struct ChallengeRosterUpdateData
    {
       public ulong MemberId;
       [AeroString] public string Name;
       public byte IsSpectator;
       public uint Team; // 1 or 2
       public ChallengeMemberFlags Flags;
    }

    [Flags]
    public enum ChallengeMemberFlags : byte
    {
        Accepted = 1 << 0,
        AdminPrivilege = 1 << 1,
        PowerPrivilege = 1 << 2,
        Ready = 1 << 3,
    }
}