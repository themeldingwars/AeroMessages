using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.Referee_ExecuteCommand, MatrixVersion.V1, MatrixVersion.V32)]
    public partial class RefereeExecuteCommand
    {
        public byte Unk1;
        public ulong Unk2;
        [AeroArray(typeof(byte))] [AeroString] public string[] Unk3;
    }
}