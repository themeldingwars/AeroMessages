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
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_EncounterPublicInfo
    {
        public EntityId EncounterId;

        [AeroString]
        public string EncounterJSON;
    }
}