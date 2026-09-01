using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.PerformTextChat, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class PerformTextChat
    {
        [AeroString] public string Message;
        public byte Channel;

        public byte HaveEntity;
        [AeroIf(nameof(HaveEntity), 1)]
        public ulong Entity;

        public byte HaveTargetName;
        [AeroIf(nameof(HaveTargetName), 1)]
        [AeroString] public string TargetName;

        public ChatMessageAlternateData AlternateData;
    }
}