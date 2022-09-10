using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 114)]
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