using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 122)]
    public partial class ReportProjectileHit
    {
        public ushort Unk1;

        public ushort ShortTime; // Time when this hit is reported
        public byte Unk2_Always1;

        public ushort Unk3_1; // Could it be weapon recoil/shake values?
        public ushort Unk3_2; // Could it be weapon recoil/shake values?

        public byte TravelTime; // Appears related to the distance/time projectile travelled before hitting.
        public byte BodyPartHit; // Appears related to the body part, the value might reference a bone/hardpoint or something.
        public byte Unk4_Always39; // 0x27
    }
}