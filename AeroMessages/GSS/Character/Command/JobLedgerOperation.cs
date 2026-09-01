using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.JobLedgerOperation, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class JobLedgerOperation
    {
        [AeroString] public string Unk1;
        [AeroArray(typeof(byte))] public float[] Unk2; // Unsure about type
    }
}