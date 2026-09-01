using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.LootDistributionSetVotes, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class LootDistributionSetVotes
    {
        public uint Unk1;
        [AeroArray(typeof(byte))] public ulong[] Unk2;
    }
}