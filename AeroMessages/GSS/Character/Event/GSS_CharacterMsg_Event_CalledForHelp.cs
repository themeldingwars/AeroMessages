using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 8, 104)]
    public partial class Character_Event_CalledForHelp
    {
        public ushort ShortTime;
    }
}