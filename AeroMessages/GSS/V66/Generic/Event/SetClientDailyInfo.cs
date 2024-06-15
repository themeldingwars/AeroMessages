using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 115)]
    public partial class SetClientDailyInfo
    {   
        public uint Unk1; // time?
        [AeroArray(typeof(byte))] public int[] Unk2; // 00b0af40 missions?
    }
}