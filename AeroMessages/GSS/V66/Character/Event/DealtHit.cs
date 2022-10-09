using Aero.Gen.Attributes;
using AeroMessages.Common;
using System;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 107)]
    public partial class DealtHit
    {
        public byte HaveDamage;
        [AeroIf(nameof(HaveDamage), 1)] public DamageHitStruct DamageData;
        public byte RepeatHitIdx; // Value that allows for repeating previously sent hits without including the full data
        public DamageResponseFlags DamageFlags;
    }
}