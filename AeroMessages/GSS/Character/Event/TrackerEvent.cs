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
        public byte TrackingType; // 0 stops tracking, 1 character, 2 deployable
        public uint Unk2; // dbcharacter::Deployable id for deployables
        public byte Unk3;
        [AeroString] public string Text;
        public byte Unk4; // Flags: 0x02 uses the pulse values, 0x10 sets a marker flag
    }
}