using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AbilityFailed, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class AbilityFailed
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint FailedAbilityId;
        public uint Unk2; // FailedTime? Its 0 in captures though.
        public AbilityCooldownsData AbilityCooldownsData;
    }
}