using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.TookDebugWeaponHit, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)] // TookDebugWeaponHit
    public partial class TookDebugWeaponHit // TookDebugWeaponHitPublic has the same parser
    {
        public TookDebugWeaponHitData Data;
    }
}