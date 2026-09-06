using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.ScoreBoardRemovePlayer, GssVersion.V1, GssVersion.V74)]
    public partial class ScoreBoardRemovePlayer
    {
        public EntityId Player;
    }
}