using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AbilityActivated, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class AbilityActivated
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint ActivatedAbilityId;
        public uint ActivatedTime;
        public AbilityCooldownsData AbilityCooldownsData;
    }
}