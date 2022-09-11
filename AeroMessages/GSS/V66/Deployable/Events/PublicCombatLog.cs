using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Deployable.Events
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 35, 85)]
    public partial class PublicCombatLog
    {
        public int HaveData;
        [AeroIf(nameof(HaveData), 1)]
        [AeroArray(typeof(ushort))]
        public byte[] Data;
    }
}