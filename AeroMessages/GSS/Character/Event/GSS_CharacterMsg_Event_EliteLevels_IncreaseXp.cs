using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 190)]
    public partial class Character_Event_EliteLevels_IncreaseXp
    {
        public uint XP;
    }
}