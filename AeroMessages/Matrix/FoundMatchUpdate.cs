using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.FoundMatchUpdate, MatrixVersion.V3, MatrixVersion.V26)]
    public partial class FoundMatchUpdate
    {
        public enum MatchUpdateState : byte
        {
            Initializing = 0, // Mission Approved
            WaitingForPlayers = 1,
            WaitingForServer = 2,
            Launching = 3,
        }
        public uint Matchmaker;
        public ulong MatchId;
        public MatchUpdateState State;
        public ushort NumPlayersNeeded;
        public ushort NumPlayersAccepted;
        public ushort StateSecondsTotal;
        public ushort StateSecondsRemaining;
    }
}