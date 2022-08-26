using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 164)]
    public partial class RequestRerollBounties
    {
        [AeroArray(typeof(byte))] uint[] Unk1;
    }
}