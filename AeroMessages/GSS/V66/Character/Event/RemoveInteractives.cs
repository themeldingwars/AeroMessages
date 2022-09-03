using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 124)]
    public partial class RemoveInteractives
    {
        [AeroArray(typeof(byte))]
        public EntityId[] Entities;
    }
}