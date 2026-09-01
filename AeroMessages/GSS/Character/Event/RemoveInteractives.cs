using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.RemoveInteractives, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class RemoveInteractives
    {
        [AeroArray(typeof(byte))]
        public EntityId[] Entities;
    }
}