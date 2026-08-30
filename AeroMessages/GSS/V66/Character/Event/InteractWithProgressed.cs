using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.InteractedWithProgressed, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class InteractedWithProgressed
    {
        public EntityId Unk1;
        public byte Unk2;
        public uint Unk3;
    }
}