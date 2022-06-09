using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 97)]
    public partial class Character_Event_ProjectileHitReported_View
    {
        // TODO: Verify if same as controller or not
        public ushort Unk1; // Matches Unk1 in ReportProjectileHit?
        public ushort ShortTime; 
        public byte Unk2;
        public byte Unk3_Always1;
    }
}