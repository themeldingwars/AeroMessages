using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 205)]
    public partial class Character_Command_UnslotAllModulesRequest
    {
        public ulong ItemGUID;
    }
}