using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.SetClientDailyInfo, GssVersion.V1, GssVersion.V74)]
    public partial class SetClientDailyInfo
    {
        public uint RefreshTime; // unix seconds
        [AeroArray(typeof(byte))] public int[] DailyMissionIds;
    }
}