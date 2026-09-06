using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ShoppingListInit, GssVersion.V1, GssVersion.V74)]
    public partial class ShoppingListInit
    {
        [AeroArray(typeof(byte))] public ShoppingListData[] Data;
    }

    [AeroBlock]
    public struct ShoppingListData
    {
        public int Unk1;
        public uint Unk2; // unk type
    }
}