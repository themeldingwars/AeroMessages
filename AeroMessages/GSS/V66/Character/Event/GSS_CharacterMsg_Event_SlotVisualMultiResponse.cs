using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 156)]
    public partial class SlotVisualMultiResponse
    {   
        // Not confirmed that these are the loadout and config
        // Alternatively it could be the loadout item guid
        public uint LoadoutId;
        public uint ConfigId; // Assumption. If so, 0: PvE, 1: PvP

        [AeroArray(typeof(byte))]
        public LoadoutConfig_Visual[] Visuals;

        public byte Result; // 1 = Success, 0 = Failure
    }
}