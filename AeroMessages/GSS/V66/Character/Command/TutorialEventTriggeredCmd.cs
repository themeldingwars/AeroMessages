using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 239)]
    public partial class TutorialEventTriggeredCmd
    {
        public uint Unk1;
        public ulong Unk2;
        public sbyte Unk3;
    }
}