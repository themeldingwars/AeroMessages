using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 167)]
    public partial class LootDistributionCompletionEvt
    {
        public uint Unk1;
        public byte Unk2;
        [AeroArray(typeof(byte))] public LootDistributionData[] Unk3;
        public ulong Unk4;
    }
}