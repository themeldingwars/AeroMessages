using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 114)]
    public partial class Character_Event_ForcedMovementCancelled
    {

        [AeroSdb("apt::BaseCommandDef", "id")]
        public uint CommandId;

        public ushort ShortTime;
    }
}