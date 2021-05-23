/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 135
    MsgName: TrackerEvent
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_TrackerPulse
    {
        public EntityId Entity;

        [AeroArray(6)]
        public byte[] Unk1;

        [AeroString]
        public string Text;

        public byte Unk2;

        // Nothing concrete
        public EntityId OtherEntity;

        [AeroArray(28)]
        public byte[] Unk3;

        [AeroArray(3)]
        public float[] FloatArray1;

        [AeroArray(8)]
        public byte[] Unk4;
    }
}