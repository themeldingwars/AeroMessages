using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.Matrix.V25
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Message, 60)]
    public partial class ServerProfilerSendNames
    {
        [AeroArray(typeof(byte))] public ServerProfilerSendNamesData[] Unk1;
        [AeroArray(typeof(byte))] public ServerProfilerSendNamesData[] Unk2;
    }

    [AeroBlock]
    public struct ServerProfilerSendNamesData
    {
        public ushort Unk1;
        [AeroString] public string Unk2;
    }
}