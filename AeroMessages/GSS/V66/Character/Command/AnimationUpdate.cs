using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 149)]
    public partial class AnimationUpdate
    {
        public uint Unk1;
        public uint Unk2;
        public sbyte Unk3;
    }
}