using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 166)]
    public partial class LootDistributionUpdateEvt
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public LootDistributionData[] Unk2;
        public uint Unk3;
    }
}