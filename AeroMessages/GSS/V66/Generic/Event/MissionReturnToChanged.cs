using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 66)]
    public partial class MissionReturnToChanged
    {
        public uint MissionId; // Assumption
        public byte Unk2;
    }
}