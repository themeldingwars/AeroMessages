using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 101)]
    public partial class Character_Event_JumpActioned
    {
        public ushort ShortTime;
    }
}