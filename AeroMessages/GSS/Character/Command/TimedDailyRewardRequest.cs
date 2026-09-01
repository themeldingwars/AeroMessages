using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.TimedDailyRewardRequest, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class TimedDailyRewardRequest
    {
        public enum RequestType : byte
        {
            // 00c0d0a0
            ROLL = 0, // Player.RequestTimedDailyRewardRoll()
            REROLL = 1,
            RICKROLL = 2,
            COMMIT = 3, // Player.RequestTimedDailyRewardCommit()
        }
        public RequestType Request;
    }
}