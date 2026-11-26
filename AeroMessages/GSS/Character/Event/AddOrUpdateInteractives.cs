using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AddOrUpdateInteractives, GssCharacterView.CombatController, GssVersion.V1, GssVersion.V74)]
    public partial class AddOrUpdateInteractives
    {
        [AeroArray(typeof(byte), Chunked = true)]
        public ulong[] Entities; // "Interactives"

        [AeroArray(typeof(byte), Chunked = true)]
        public byte[] InteractionTypes; // "Types"

        [AeroArray(typeof(byte), Chunked = true)]
        public uint[] InteractionDurationsMs; // "Durations"
    }
}