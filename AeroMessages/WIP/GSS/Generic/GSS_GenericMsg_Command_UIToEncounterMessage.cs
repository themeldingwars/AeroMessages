/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 17
    MsgName: UIToEncounterMessage
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 251, 17)]
    public partial class GenericCommand_UIToEncounterMessage
    {
        [AeroString]
        public string Key1;

        [AeroString]
        public string Key2;

        [AeroString]
        public string JSON;
    }
}