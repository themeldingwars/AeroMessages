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
        public byte Unk1; // 2 deployable, 1 character, 0 when tracking ends
        public uint Unk2; // dbcharacter::Deployable id for deployables
        public byte Unk3;
        [AeroString] public string Text;
        public byte Unk4;
    }
}