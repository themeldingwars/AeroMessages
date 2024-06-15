using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 67)]
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