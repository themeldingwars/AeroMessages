using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 139)]
    public partial class SetNoSpreadFlag
    {
        public byte Unk1;
        public byte Unk2;
    }
}