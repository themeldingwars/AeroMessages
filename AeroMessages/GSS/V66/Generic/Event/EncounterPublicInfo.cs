using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 112)]
    public partial class EncounterPublicInfo
    {
        public EntityId EncounterId;

        [AeroString]
        public string EncounterJSON;
    }
}