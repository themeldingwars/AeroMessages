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
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_Respawned
    {
        public ushort ShortTime;

        [AeroArray(2)]
        public byte[] Unk;
    }
}