using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.InteractableStatusChanged, GssVersion.V1, GssVersion.V74)]
    public partial class InteractableStatusChanged
    {
        // Without a Target, (TypeCode, TypeId) marks every entity of that type, e.g. deployables (0x22) of a dbcharacter::Deployable id
        public byte TypeCode;
        public uint TypeId;
        public EntityId Target;
        public byte IsInteractable;
    }
}