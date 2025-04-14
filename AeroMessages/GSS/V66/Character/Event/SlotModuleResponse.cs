using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 152)]
    public partial class SlotModuleResponse
    {
        public ulong ItemGUID;
        [AeroArray(typeof(byte))] public SlotModuleResponseData[] Unk1;
        public sbyte Unk2;
    }

    [AeroBlock]
    public struct SlotModuleResponseData
    {
        public uint Unk1; // Module id then?
        public byte Unk2; // Ok or no?
    }
}