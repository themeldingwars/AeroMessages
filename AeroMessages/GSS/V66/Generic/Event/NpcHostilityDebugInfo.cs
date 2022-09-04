using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 55)]
    public partial class NpcHostilityDebugInfo
    {
        public EntityId Target; // Assumption
        [AeroArray(typeof(byte))] public NpcHosilityDebugInfoData[] Data;
    }

    [AeroBlock]
    public struct NpcHosilityDebugInfoData
    {
        public ulong Unk1;
        public uint Unk2;
    }
}