using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.LeaveEncounterParty, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class LeaveEncounterParty
    {
        public EntityId EncounterId;
    }
}
