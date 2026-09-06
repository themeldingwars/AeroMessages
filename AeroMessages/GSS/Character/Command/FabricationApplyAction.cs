using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.Fabrication_ApplyAction, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FabricationApplyAction
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }
}