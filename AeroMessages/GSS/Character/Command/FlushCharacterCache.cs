using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.FlushCharacterCache, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FlushCharacterCache
    {
        public sbyte All;
        public sbyte Items;
        public sbyte XpLevel;
        public sbyte FactionReputation;
        public sbyte Mission;
    }
}