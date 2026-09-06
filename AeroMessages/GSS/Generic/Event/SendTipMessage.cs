using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.SendTipMessage, GssVersion.V1, GssVersion.V74)]
    public partial class SendTipMessage
    {
        public enum HintType : byte
        {
            None = 0,
            Movement = 1,
            TechSlot = 2
        }

        [AeroSdb("clientmissions::UiHints", "id")]
        public HintType Hint;

        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint MessageId;

        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint HeaderId;

        public HalfFloat Duration; // seconds

        public sbyte Persistent;
    }
}