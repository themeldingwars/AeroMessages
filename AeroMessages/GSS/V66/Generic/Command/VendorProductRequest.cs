using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 251, 31)]
    public partial class Generic_Command_VendorProductRequest
    {
        public uint TerminalId;
    }
}