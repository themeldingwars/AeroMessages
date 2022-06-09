using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 117)]
    public partial class Character_Command_CameraPoseUpdate
    {
        public byte Unk1;
        public EntityId FollowingEntity;
    }
}