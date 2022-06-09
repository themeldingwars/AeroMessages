using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 186)]
    public partial class Character_Command_ClientQueryInteractionStatus
    {
       public EntityId Entity;
       public byte Unk;
    }
}