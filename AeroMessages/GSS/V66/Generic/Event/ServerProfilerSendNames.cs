using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 46)]
    public partial class ServerProfilerSendNames
    {   
        [AeroArray(typeof(byte))] public ServerProfilerNamesData[] Data1;
        [AeroArray(typeof(byte))] public ServerProfilerNamesData[] Data2;
    }

    [AeroBlock]
    public struct ServerProfilerNamesData
    {
        public ushort Unk1;
        [AeroString] public string Name; // Assumption
    }
}