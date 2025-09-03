using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 123)]
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