using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.EncounterUIUpdate, GssVersion.V1, GssVersion.V74)]
    public partial class EncounterUIUpdate
    {
        // Kept for callers that still pass the packed size, the values are read to the end now
        public EncounterUIUpdate(int size)
        {
        }

        public EncounterUIUpdate()
        {
        }

        public EntityId EncounterId;

        // SinCard changes until the end of the blob, per entry: ulong Guid, then
        //   (Guid & 0xff) == 0xff: ulong Target, uint Type, SinCardFieldData[] Fields (byte count), creates or replaces the card
        //   otherwise: byte n, n == 0 removes the card, else n times (byte field index, SinCardFieldData value)
        // Aero can't read a structure bounded by a byte length, so it stays a blob
        [AeroBlob(typeof(ushort))] public byte[] SinCardChanges;

        // Shadow field changes for the encounter view announced in EncounterUIScopeIn
        [AeroBlob] public byte[] ShadowFieldValues;
    }
}