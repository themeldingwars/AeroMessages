using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 44)]
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