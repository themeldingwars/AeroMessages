using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Killed, GssCharacterView.CombatView, GssVersion.V1, GssVersion.V67)]
    public partial class Killed
    {
        public ushort ShortTime;
        public EntityId Killer;
        public byte Unk1;
        public byte Unk2;
        public byte Unk3;
    }
}