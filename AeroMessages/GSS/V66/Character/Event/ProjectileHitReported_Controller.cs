using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 97)]
    public partial class ProjectileHitReported_Controller
    {
        // TODO: Verify if same as view or not
        [AeroArray(2)]
        public byte[] Unk1;
        public ushort ShortTime;
    }
}