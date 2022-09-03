using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 165)]
    public partial class LootDistributionStartEvt
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] LootDistributionData[] Unk2;
        public uint Unk3;
        public uint Unk4;
        public uint Unk5;
        public uint Unk6;
        [AeroArray(typeof(byte))] public uint[] Unk7;
        public byte Unk8;
        public byte Unk9;
    }
}