using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 96)]
    public partial class DebugLagRaiaSample
    {
        public ushort RaiaFrameMs;
        public ushort RaiaUpdateDurationMs;
        public ushort UpdatedObjects;
        public ushort TotalObjects;
    }
}