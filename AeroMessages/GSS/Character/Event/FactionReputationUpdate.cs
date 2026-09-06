using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.FactionReputationUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
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