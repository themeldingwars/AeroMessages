using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 231)]
    public partial class FlushCharacterCache
    {
        public sbyte All;
        public sbyte Items;
        public sbyte XpLevel;
        public sbyte FactionReputation;
        public sbyte Mission;
    }
}