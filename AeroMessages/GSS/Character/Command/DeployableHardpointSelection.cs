using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.DeployableHardpointSelection, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class DeployableHardpointSelection
    {
        public EntityId Unk1;
        public uint Unk2;
    }
}