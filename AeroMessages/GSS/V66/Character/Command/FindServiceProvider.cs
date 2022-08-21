using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 195)]
    public partial class FindServiceProvider
    {
        public byte Unk1;
    }
}