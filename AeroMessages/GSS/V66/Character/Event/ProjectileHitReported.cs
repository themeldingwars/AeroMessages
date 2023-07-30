using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 97)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 97)]
    public partial class ProjectileHitReported
    {
        public ushort TraceRef; // Part of the uint used to group trace data in debugweapon.
        public ushort ShortTime; 
        public byte Unk2;
        public byte Unk3;
    }
}