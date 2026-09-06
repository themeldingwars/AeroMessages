using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ListActiveBountyDetails, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ListActiveBountyDetails
    {
        public uint Unk1;
        public byte Unk2;
    }
}