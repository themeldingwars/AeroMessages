using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 32)]
    public partial class Generic_Event_EncounterToUIMessage
    {
        public EntityId EncounterId;

        [AeroString]
        public string Header;

        [AeroString]
        public string JSON;
    }
}