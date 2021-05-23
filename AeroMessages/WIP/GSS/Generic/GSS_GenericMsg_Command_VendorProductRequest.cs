/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 31
    MsgName: VendorProductRequest
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Command_VendorProductRequest
    {
        public uint TerminalId;
    }
}