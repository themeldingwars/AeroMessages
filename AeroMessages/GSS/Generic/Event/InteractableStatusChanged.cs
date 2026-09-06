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
        public byte Unk1;
        public uint Unk2;
        public EntityId Target;
        public byte Unk3;
    }
}