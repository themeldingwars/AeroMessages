using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 99)]
    public partial class EncounterDebugNotification
    {
        public EntityId EncounterId;
        [AeroString] public string Notification;
        [AeroString] public string Display; // 'chat', 'broadcast' have behaviors. Defaults to log to console.
    }
}