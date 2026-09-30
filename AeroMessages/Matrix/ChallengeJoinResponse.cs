using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, MatrixMessage.ChallengeJoinResponse, MatrixVersion.V5, MatrixVersion.V32)]
    public partial class ChallengeJoinResponse
    {
        public ulong ChallengeId;
        public sbyte Success;
        public sbyte Created; // "Created" when set, "Accepted" otherwise
        public sbyte Squad; // joined with the squad
        public uint Unk4; // not passed on by the client
        [AeroArray(typeof(byte))] public ChallengeMapData[] AvailableMaps; // Lobby.GetAvailableMaps
        public uint ZoneId; // the selected map, Lobby.GetMatchParameters "zone_id"
    }

    [AeroBlock]
    public struct ChallengeMapData
    {
        public uint ZoneId;
        [AeroString] public string DisplayName;
        [AeroString] public string DisplayType;
        public byte TeamCount;
        public byte MinPlayersPerTeam;
        public byte MaxPlayersPerTeam;
    }
}