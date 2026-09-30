using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ListActiveBounties, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ListActiveBounties, GssCharacterView.MissionAndMarkerController, GssVersion.V74, GssVersion.V74)]
    public partial class ListActiveBounties
    {
        public BountyCategory Category;
        public byte Unk2;
    }
}