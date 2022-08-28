using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 172)]
    public partial class FactionReputationUpdate
    {
        [AeroArray(typeof(byte))] public FactionReputationData[] Data;
        public byte Unk2;
    }

    [AeroBlock]
    public struct FactionReputationData
    {
        public byte Unk1;
        public uint Unk2;
    }
}