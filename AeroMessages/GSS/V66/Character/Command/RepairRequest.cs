using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 203)]
    public partial class RepairRequest
    {
        [AeroArray(typeof(byte))] public ulong[] Data;
    }
}