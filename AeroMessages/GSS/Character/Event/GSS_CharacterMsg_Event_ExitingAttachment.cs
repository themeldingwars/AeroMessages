using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 164)]
    public partial class Character_Event_ExitingAttachment
    {
        // Guessing
        public QuantisedVector3 Direction;
    }
}