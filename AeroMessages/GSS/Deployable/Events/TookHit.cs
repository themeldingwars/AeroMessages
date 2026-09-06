using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Deployable.Events
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssDeployableMessage.TookHit, GssDeployableView.ObserverView, GssVersion.V1, GssVersion.V74)]
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