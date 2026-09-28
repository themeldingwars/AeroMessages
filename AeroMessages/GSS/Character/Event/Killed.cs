using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Killed, GssCharacterView.CombatView, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.Killed, GssCharacterView.CombatController, GssVersion.V74, GssVersion.V74)]
    public partial class Killed
    {
        public ushort ShortTime;
        public EntityId Killer;
        public byte Unk1; // Always 6 (Living) in 1962 data, maybe the state before death
        public CharacterStateData.CharacterStatus State; // Dead or Incapacitated, CharacterState.Time matches ShortTime
        public CombatLogRow.CombatSourceType SourceType;
    }
}