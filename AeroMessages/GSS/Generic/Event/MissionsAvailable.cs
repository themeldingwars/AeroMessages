using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.MissionsAvailable, GssVersion.V1, GssVersion.V67)]
    public partial class MissionsAvailable
    {
        [AeroArray(typeof(byte))] public MissionsAvailableData[] Missions;
        public ulong Unk2;
    }

    [AeroBlock]
    public struct MissionsAvailableData
    {
        public uint MissionId;
        public byte MissionAvailability; // 0,1,2,3
    }
}