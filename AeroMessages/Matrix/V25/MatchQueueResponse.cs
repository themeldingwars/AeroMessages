using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 42)]
    public partial class MatchQueueResponse
    {
        [AeroArray(typeof(byte))] public MatchQueueResponseData Unk1;
        public uint Unk2;
    }

    [AeroBlock]
    public struct MatchQueueResponseData
    {
        public uint Unk1;
        public uint Unk2;
        [AeroString] public string Unk3;
        [AeroString] public string Unk4;
    }
}