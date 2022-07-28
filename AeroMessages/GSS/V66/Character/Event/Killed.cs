using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 108)]
    public partial class Killed
    {
        public ushort ShortTime;
        public EntityId Killer;
        public byte Unk1;
        public byte Unk2;
        public byte Unk3;
    }
}