using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 56)]
    public partial class ForceUnqueue
    {
        public enum QueueErrorReason : byte
        {
            Unknown = 0,
            DidNotAccept = 1,
            ServerError = 2,
            InChallenge = 3,
            NotEnoughPlayers = 4,
            TooManyPlayers = 5,
            InvalidTeamId = 6,
            LackingAccess = 7,
            TooManyPLayersPvP = 8,
            CannotQueueFromThisInstance = 9,
            InvalidQueues = 10,
            NotSquadLeader = 11,
            NotInSquad = 12,
            SquadDoesNotExist = 13,
            SquadReadyTimedOut = 14,
            InvalidLFGCategory = 15,
            TooManyQuitters = 16,
            InvalidZoneId = 17,
            MinimumLevelNotMet = 18,
            DeserterDebuff = 19
        }

        public QueueErrorReason ReasonType;
        [AeroArray(typeof(byte))] public EntityId[] CausingCharacters;
        public uint ReasonValue;
    }
}