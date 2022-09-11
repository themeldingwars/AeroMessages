using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 105)]
    public partial class TookHit
    {
        // These are in DealtHit too
        public byte HaveDamage;
        [AeroIf(nameof(HaveDamage), 1)] public DamageHitStruct DamageData;
        public byte Unk1;
        public DamageResponseFlags DamageFlags;

        // Unique to TookHit
        public ushort ShortTime;
        public byte Unk2;
    }
}