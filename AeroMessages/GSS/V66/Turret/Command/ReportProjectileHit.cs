using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Turret.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 39, 87)]
    public partial class ReportProjectileHit
    {
        public ushort Unk1;
        public ushort ShortTime; // Time when this hit is reported
        public byte Unk2;
        public sbyte Unk3;
        public sbyte Unk4;
        public sbyte Unk5;
        public ushort TravelTime; // Appears related to the distance/time projectile travelled before hitting.
        public ushort BodyPartHit; // Appears related to the body part, the value might reference a bone/hardpoint or something.
    }
}