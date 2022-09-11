using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 244)]
    public partial class FabricationApplyAction
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }
}