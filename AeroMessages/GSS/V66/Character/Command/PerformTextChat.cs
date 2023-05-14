using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using static Aero.Gen.Attributes.AeroIfAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 145)]
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