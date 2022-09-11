using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 184)]
    public partial class PostStatEvent
    {
        [AeroSdb("dbstats::Stat", "Id")]
        public uint StatEventId;
        [AeroArray(typeof(uint))]
        public GenericKeyVariablePair[] Stats;
    }
}