using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ClientQueryInteractionStatus, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ClientQueryInteractionStatus
    {
        public EntityId Entity;
        public byte StopQuery; // 1 on the last query for the entity, after that the client stops polling it
    }
}