using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 47)]
    public partial class ServerProfilerSendFrame
    {   
        [AeroArray(typeof(byte))] public ServerProfilerFrameData[] Unk1;
    }

    [AeroBlock]
    public struct ServerProfilerFrameData
    {
        public ushort Unk1;
        [AeroArray(typeof(byte))] public ServerProfilerStruct[] Unk2;
    }

    [AeroBlock]
    public struct ServerProfilerStruct
    {
        public ushort Unk1;
        public ushort Unk2;
        public ushort Unk3;
        public ushort Unk4;
        public ushort Unk5;
        public ushort Unk6;
        public ushort Unk7;
        public ushort Unk8;
        public ushort Unk9;
        public byte FIXME_Unk10ArrayCount; // 0074ca80 FIXME: Aero doesnt handle an array of the same struct inside the struct
    }
}