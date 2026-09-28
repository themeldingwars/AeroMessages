using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.MissionsAvailable, GssVersion.V1, GssVersion.V74)]
    public partial class MissionsAvailable
    {
        [AeroArray(typeof(byte))] public MissionsAvailableData[] Missions;
        public ulong Npc; // the mission giver's entity id, 0 = none
    }

    [AeroBlock]
    public struct MissionsAvailableData
    {
        public uint MissionId;
        public byte MissionAvailability; // 0,1,2,3
    }
}