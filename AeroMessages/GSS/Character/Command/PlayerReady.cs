using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.PlayerReady, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class PlayerReady
    {
        public sbyte ControllerReady;
        public sbyte StreamingComplete;

        public byte HaveSquadMemberIds;
        [AeroIf(nameof(HaveSquadMemberIds), 1)]
        [AeroArray(typeof(byte))] public ulong[] SquadMemberIds;
    }
}