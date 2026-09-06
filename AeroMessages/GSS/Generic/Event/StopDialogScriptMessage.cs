using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.StopDialogScriptMessage, GssVersion.V1, GssVersion.V74)]
    public partial class StopDialogScriptMessage
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public ulong[] Unk2;
        public byte Unk3;
    }
}