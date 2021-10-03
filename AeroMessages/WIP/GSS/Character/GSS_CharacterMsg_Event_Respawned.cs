/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 8
    TypeName: Character::ObserverView
    MsgId: 103
    MsgName: Respawned
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 8, 103)]
    public partial class Character_Event_Respawned
    {
        public ushort ShortTime;

        [AeroArray(2)]
        public byte[] Unk;
    }
}