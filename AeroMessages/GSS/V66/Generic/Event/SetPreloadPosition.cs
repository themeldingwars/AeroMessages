using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 105)]
    public partial class SetPreloadPosition
    {   
        public uint Unk1;
        [AeroArray(typeof(byte))] public int[] Unk2; // 00b0af40
        [AeroArray(4)] public Vector4 Unk3;
    }
}