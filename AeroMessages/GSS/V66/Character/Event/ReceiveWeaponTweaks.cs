using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 84)]
    public partial class ReceiveWeaponTweaks
    {
        public byte Unk1;
        public sbyte Unk2;

        // TODO: Consume remaining data
    }

}