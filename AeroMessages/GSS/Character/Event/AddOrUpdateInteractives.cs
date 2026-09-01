using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AddOrUpdateInteractives, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V67)]
    public partial class AddOrUpdateInteractives
    {
        [AeroArray(typeof(byte))]
        public ulong[] Entities; // "Interactives"

        [AeroArray(typeof(byte))]
        public byte[] InteractionTypes; // "Types"

        [AeroArray(typeof(byte))]
        public uint[] InteractionDurationsMs; // "Durations"
    }
}