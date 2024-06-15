using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 103)]
    public partial class DisplayUiNotification
    {
        public enum BannerType : byte
        {
            Normal = 1,
            MoneyBomb = 2,
        }

        [AeroSdb("dblocalization::LocalizedText", "id")]
        public uint LocalizedTextId;

        public uint Duration; // seconds

        [AeroArray(typeof(byte))] public UiNotificationData[] Unk2; // Formatted args for localized text?

        [AeroSdb("dbcharacter::BannerType", "id")]
        public BannerType Banner;
    }

    [AeroBlock]
    public struct UiNotificationData
    {
        public byte Unk1; // 0 (?), 1 (%u), 2 (%.2f)
        [AeroString] public string Unk2; // txt?
        public int Unk3; // uint?
        public int Unk4; // float?
    }
}