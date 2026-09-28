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
        // Size is ignored, kept for compatibility
        public EncounterUIUpdate(int size)
        {
        }

        public EncounterUIUpdate()
        {
        }

        public EntityId EncounterId;

        [AeroBlob(typeof(ushort))] public byte[] BlobData;

        // Shadow field changes for the encounter view announced in EncounterUIScopeIn
        [AeroBlob] public byte[] ShadowFieldValues;
    }
}