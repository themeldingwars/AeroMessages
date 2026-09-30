using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.Matrix
{
    [Aero]
    [AeroMessageId(MsgType.Matrix, MsgSrc.Command, MatrixMessage.RequestSigscan, MatrixVersion.V18, MatrixVersion.V32)]
    public partial class RequestSigscan
    {
        public uint Unk1; // passed through from RedHanded, the client reuses the last SigscanData for the same value
        public byte Unk2; // negated flag passed through from RedHanded
    }
}