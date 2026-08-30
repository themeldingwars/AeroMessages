using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.PostStatEvent, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class PostStatEvent
    {
        [AeroSdb("dbstats::Stat", "Id")]
        public uint StatEventId;
        [AeroArray(typeof(uint))]
        public GenericKeyVariablePair[] Stats;
    }
}