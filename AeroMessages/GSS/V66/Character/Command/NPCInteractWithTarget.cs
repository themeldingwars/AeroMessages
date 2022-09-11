using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 135)]
    public partial class NPCInteractWithTarget
    {
        public uint Unk1;
        public ulong Unk2;
        public uint Unk3;
        public uint Unk4;
    }
}