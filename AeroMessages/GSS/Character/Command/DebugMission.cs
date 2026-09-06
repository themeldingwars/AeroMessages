using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.DebugMission, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class DebugMission
    {
        public uint Unk1; // Mission I imagine
        [AeroString] public string Unk2;
    }
}