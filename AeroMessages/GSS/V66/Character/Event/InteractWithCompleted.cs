using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 128)]
    public partial class InteractedWithCompleted
    {
        public EntityId Unk1;
        public byte Unk2;
        public byte Unk3;
    }
}