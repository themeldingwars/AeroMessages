/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 123
    MsgName: AddOrUpdateInteractives
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 123)]
    public partial class Character_Event_AddOrUpdateInteractives
    {
        [AeroArray(typeof(byte))]
        public ulong[] Entities;

        [AeroArray(typeof(byte))]
        public byte[] InteractionTypes;

        [AeroArray(typeof(byte))]
        public uint[] InteractionDurationsMs;
    }
}