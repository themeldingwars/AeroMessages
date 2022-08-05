using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 103)]
    public partial class DisplayUiNotification
    {
        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint LocalizedTextId;

        [AeroArray(6)]
        public byte[] Unk;
    }
}