using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.CurrentPoseUpdate, GssCharacterView.MovementView, GssVersion.V16, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.CurrentPoseUpdate, GssCharacterView.ObserverView, GssVersion.V74, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.CurrentPoseUpdate, GssCharacterView.EquipmentView, GssVersion.V74, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.CurrentPoseUpdate, GssCharacterView.CombatView, GssVersion.V74, GssVersion.V74)]
    public partial class CurrentPoseUpdate
    {
        public CurrentPoseUpdateData Data;
    }
}