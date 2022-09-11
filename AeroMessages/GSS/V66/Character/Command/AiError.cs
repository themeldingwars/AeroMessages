using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 191)] // Not sure what controller it would be assoicated with
    public partial class AiError
    {
        [AeroString] public string Unk;
    }
}