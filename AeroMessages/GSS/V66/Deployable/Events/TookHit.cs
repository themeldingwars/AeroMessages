using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Deployable.Events
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 35, 83)]
    public partial class TookHit
    {
        // These are in DealtHit too
        public byte HaveDamage;
        [AeroIf(nameof(HaveDamage), 1)] public DamageHitStruct DamageData;
        public byte RepeatHitIdx; // Value that allows for repeating previously sent hits without including the full data
        public DamageResponseFlags DamageFlags;

        // Unique to TookHit
        public ushort ShortTime;
        public byte Unk2;
    }
}