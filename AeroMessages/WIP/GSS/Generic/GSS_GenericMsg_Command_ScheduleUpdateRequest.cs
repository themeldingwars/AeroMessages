/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 19
    MsgName: ScheduleUpdateRequest
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Command_ScheduleUpdateRequest
    {
        public uint Time;
    }
}