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
        public uint Unk1;
        [AeroArray(typeof(byte))] public UiNotificationData[] Unk2;
        public byte Unk3;
    }

    [AeroBlock]
    public struct UiNotificationData
    {
        public byte Unk1;
        [AeroString] public string Unk2;
        public int Unk3;
        public int Unk4;
    }
}