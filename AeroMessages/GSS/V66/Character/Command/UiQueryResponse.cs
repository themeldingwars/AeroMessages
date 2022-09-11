using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 59)]
    public partial class UiQueryResponse
    {
        public ulong Unk1;
        public uint Unk2;
        public byte Unk3;
        [AeroArray(typeof(byte))] public UiQueryResponseData Unk4;
    }

    [AeroBlock]
    public struct UiQueryResponseData
    {
        public uint Unk1;
        public uint Unk2;
    }
}