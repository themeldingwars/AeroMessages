using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 225)]
    public partial class Character_Command_AcceptRewards
    {
        public uint IndexId;
    }
}