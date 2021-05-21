[Aero(AeroType.Msg, AeroMsgType.GSS, AeroSrc.Client, 5, 122, Ver: 1962)]
public partial class CharacterCombatControllerReportProjectileHit : AeroBase
{
    public ushort Unk1;

    public ushort ShortTime; // Time when this hit is reported
    public byte Unk2_Always1;

    public ushort Unk3_1;
    public ushort Unk3_2;
    public float Unk3_1_Float; // Could it be weapon recoil/shake values?
    public float Unk3_2_Float; // Could it be weapon recoil/shake values?

    public byte TravelTime; // Appears related to the distance/time projectile travelled before hitting.
    public byte BodyPartHit; // Appears related to the body part, the value might reference a bone/hardpoint or something.
    public byte Unk4_Always39; // 0x27
}