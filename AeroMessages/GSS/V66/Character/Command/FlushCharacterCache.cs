using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 231)]
    public partial class FlushCharacterCache
    {
        public sbyte Items;
        public sbyte SlotGear;
        public sbyte XpLevel;
        public sbyte Mission;
        public sbyte All;
    }
}