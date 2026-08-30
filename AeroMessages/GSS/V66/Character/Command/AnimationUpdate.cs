using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.AnimationUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class AnimationUpdate
    {
        public uint Unk1;
        public uint Unk2;
        public sbyte Unk3;
    }
}