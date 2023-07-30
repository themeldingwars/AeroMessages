using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 122)]
    public partial class ReportProjectileHit
    {
        public ushort TraceRef; // Part of the uint used to group trace data in debugweapon.
        public ushort ShortTime; // Time when this hit is reported
        public byte Unk2; // Usually 1?
        public sbyte Unk3;
        public sbyte Unk4;
        public sbyte Unk5;
        public HalfFloat Unk6;
        public ushort BodyPartHit; // Appears related to the body part, the value might reference a bone/hardpoint or something.
    }
}