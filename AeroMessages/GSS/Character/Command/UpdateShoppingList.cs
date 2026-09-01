using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.UpdateShoppingList, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class UpdateShoppingList
    {
        // TODO: UpdateShoppingList has some weird shit going on
        public byte FixmeCount1; // FUN_009ba270
        public byte FixmeCount2; // FUN_009ba9a0
    }
}