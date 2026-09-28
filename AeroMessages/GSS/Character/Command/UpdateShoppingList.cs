using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.UpdateShoppingList, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class UpdateShoppingList
    {
        [AeroArray(typeof(byte))] public ShoppingListUIntEntry[] Unk1; // FUN_009ba270
        [AeroArray(typeof(byte))] public ShoppingListByteEntry[] Unk2; // FUN_009ba9a0
    }

    [AeroBlock]
    public struct ShoppingListUIntEntry
    {
        public uint Key;
        public uint Value;
    }

    [AeroBlock]
    public struct ShoppingListByteEntry
    {
        public uint Key;
        public byte Value;
    }
}