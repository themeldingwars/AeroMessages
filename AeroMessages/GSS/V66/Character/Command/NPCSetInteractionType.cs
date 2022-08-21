using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 141)]
    public partial class NPCSetInteractionType
    {
        public byte Unk1;
        public ushort Unk2; // FUN_007377d0 TODO: Seems like something more is read based of this
    }
}