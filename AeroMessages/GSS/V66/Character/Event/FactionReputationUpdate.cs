using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 172)]
    public partial class FactionReputationUpdate
    {
        [AeroArray(typeof(byte))] public FactionReputationData[] Data;
        public sbyte HideUiNotification;
    }

    [AeroBlock]
    public struct FactionReputationData
    {
        [AeroSdb("dbcharacter::Faction", "id")]
        public byte FactionId;

        public uint Points;
    }
}