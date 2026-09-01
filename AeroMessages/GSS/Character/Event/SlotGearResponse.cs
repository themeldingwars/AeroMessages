using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.SlotGearResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class SlotGearResponse
    {
        public int LoadoutId;
        public ulong ItemGUID;

        [AeroSdb("dbitems::LoadoutSlot", "id")]
        public byte SlotIdx;

        public uint Unk1;
        public sbyte Result; // 1 = Success, 0 = Failure
    }
}