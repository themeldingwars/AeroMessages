using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 134)]
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