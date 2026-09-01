using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.LootDistributionSetState, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class LootDistributionSetState
    {
        public uint Unk1;
        public byte Unk2;
    }
}