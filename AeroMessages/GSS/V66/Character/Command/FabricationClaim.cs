using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 247)]
    public partial class FabricationClaim
    {
        public uint Unk1;
        public uint Unk2;
    }
}