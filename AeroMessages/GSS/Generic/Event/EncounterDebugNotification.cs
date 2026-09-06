using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.EncounterDebugNotification, GssVersion.V1, GssVersion.V74)]
    public partial class EncounterDebugNotification
    {
        public EntityId EncounterId;
        [AeroString] public string Notification;
        [AeroString] public string Display; // 'chat', 'broadcast' have behaviors. Defaults to log to console.
    }
}