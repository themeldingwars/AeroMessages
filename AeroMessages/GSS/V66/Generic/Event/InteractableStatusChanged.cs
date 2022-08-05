using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 91)]
    public partial class InteractableStatusChanged
    {
        public EntityId Target;

        [AeroArray(5)]
        public byte[] Unk;

        public byte Interactable;
    }
}