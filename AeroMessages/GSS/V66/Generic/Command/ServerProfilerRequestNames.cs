using System.Numerics;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 251, 18)]
    public partial class ServerProfilerRequestNames
    {
        [AeroArray(typeof(byte))] public ushort[] Unk1;
        [AeroArray(typeof(byte))] public ushort[] Unk2;
    }
}