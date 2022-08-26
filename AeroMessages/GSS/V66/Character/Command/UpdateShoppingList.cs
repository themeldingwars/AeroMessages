using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 194)]
    public partial class UpdateShoppingList
    {
        // TODO: UpdateShoppingList has some weird shit going on
        public byte FixmeCount1; // FUN_009ba270
        public byte FixmeCount2; // FUN_009ba9a0
    }
}