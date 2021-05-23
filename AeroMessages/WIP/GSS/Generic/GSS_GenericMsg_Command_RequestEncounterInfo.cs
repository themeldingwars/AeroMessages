/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 25
    MsgName: RequestEncounterInfo
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Command_RequestEncounterInfo
    {
        public EntityId EncounterId;
    }
}