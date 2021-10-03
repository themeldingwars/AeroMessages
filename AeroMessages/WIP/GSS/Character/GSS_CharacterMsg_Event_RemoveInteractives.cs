/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 124
    MsgName: RemoveInteractives
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 124)]
    public partial class Character_Event_RemoveInteractives
    {
        //[AeroArray(typeof(byte))]
        //public ulong[] Entity;
        
        public byte Unk1; // TODO: Test if length
        public EntityId Entity;
    }
}