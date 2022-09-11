using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 116)]
    public partial class AbilityActivated
    {   
        [AeroSdb("apt::AbilityData", "id")]
        public uint ActivatedAbilityId;
        public uint ActivatedTime;
        public AbilityCooldownsData AbilityCooldownsData;
    }
}