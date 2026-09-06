using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.DropCarryableObject, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class DropCarryableObject
    {
        public EntityId Carryable;
    }
}