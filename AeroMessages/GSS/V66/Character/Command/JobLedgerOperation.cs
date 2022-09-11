using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 215)]
    public partial class JobLedgerOperation
    {
        [AeroString] public string Unk1;
        [AeroArray(typeof(byte))] public float[] Unk2; // Unsure about type
    }
}