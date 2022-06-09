using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 126)]
    public partial class Character_Event_InteractionCompleted
    {
        public byte Percent;
    }
}