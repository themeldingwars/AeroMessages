/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 134
    MsgName: TrackerEvent
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_TrackerEvent
    {
        public EntityId Entity;

        [AeroArray(6)]
        public byte[] Unk1;

        [AeroString]
        public string Text;

        public byte Unk2;
    }
}