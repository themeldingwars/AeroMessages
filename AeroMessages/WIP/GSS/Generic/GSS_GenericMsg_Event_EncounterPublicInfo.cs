/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 112
    MsgName: DisplayUiNotification
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 112)]
    public partial class Generic_Event_EncounterPublicInfo
    {
        public EntityId EncounterId;

        [AeroString]
        public string EncounterJSON;
    }
}