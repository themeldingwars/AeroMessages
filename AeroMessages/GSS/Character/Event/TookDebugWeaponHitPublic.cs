using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.TookDebugWeaponHitPublic, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)] // TookDebugWeaponHitPublic
    public partial class TookDebugWeaponHitPublic // TookDebugWeaponHit has the same parser
    {
        public TookDebugWeaponHitData Data;
    }
}