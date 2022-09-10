using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 109)]
    public partial class StopDialogScriptMessage
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public ulong[] Unk2;
        public byte Unk3;
    }
}