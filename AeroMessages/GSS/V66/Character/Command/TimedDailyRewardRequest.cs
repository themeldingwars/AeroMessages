using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 201)]
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