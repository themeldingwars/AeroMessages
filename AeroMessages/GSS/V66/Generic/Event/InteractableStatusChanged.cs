using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 91)]
    public partial class InteractableStatusChanged
    {
        public byte Unk1;
        public uint Unk2;
        public EntityId Target;
        public byte Unk3;
    }
}