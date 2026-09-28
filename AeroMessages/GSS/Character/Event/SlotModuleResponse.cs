using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.SlotModuleResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SlotModuleResponse
    {
        public ulong ItemGUID;
        [AeroArray(typeof(byte))] public SlotModuleResponseData[] Slotted;
        public sbyte Success;
    }

    [AeroBlock]
    public struct SlotModuleResponseData
    {
        public uint ModuleSdbId;
        public byte SlotIndex; // Lua gets SlotIndex - 3
    }
}