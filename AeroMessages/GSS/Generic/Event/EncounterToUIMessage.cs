using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.EncounterToUIMessage, GssVersion.V1, GssVersion.V74)]
    public partial class EncounterToUIMessage
    {
        public EntityId EncounterId;

        [AeroString]
        public string Header;

        // JSON text up to the end of the message, the closing quote of every string is sent as a 0 byte
        [AeroBlob]
        public byte[] JSON;
    }
}