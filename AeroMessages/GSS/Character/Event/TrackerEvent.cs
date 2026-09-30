using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.TrackerEvent, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class TrackerEvent
    {
        public EntityId Entity;
        public byte TrackingType; // 0 stops tracking, 1 and 3 character, 2 and 4 deployable, 5 vehicle
        public uint Unk2; // dbcharacter::Deployable id for deployables
        public byte Unk3;
        [AeroString] public string Text;
        public byte PulseFlags; // TrackerPulse fields the marker uses: 0x01 Unk8, 0x02 Health/MaxHealth, 0x10 Position, 0x20 Heading
    }
}