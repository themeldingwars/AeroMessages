using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.SetClientDailyInfo, GssVersion.V1, GssVersion.V67)]
    public partial class SetClientDailyInfo
    {
        public uint Unk1; // time?
        [AeroArray(typeof(byte))] public int[] Unk2; // 00b0af40 missions?
    }
}