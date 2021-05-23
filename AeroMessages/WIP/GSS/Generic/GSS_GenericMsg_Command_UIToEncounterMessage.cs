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
namespace AeroMessages.GSS.Generic
{
    [Aero]
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