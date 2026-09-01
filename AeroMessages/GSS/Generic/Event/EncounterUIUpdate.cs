using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.EncounterUIUpdate, GssVersion.V1, GssVersion.V67)]
    public partial class EncounterUIUpdate
    {
        public EncounterUIUpdate(int size)
        {
            _size = size;
        }

        public EncounterUIUpdate()
        {
        }

        public EntityId EncounterId;

        [AeroBlob(typeof(ushort))] public byte[] BlobData;

        private int _size;

        [AeroArray(nameof(_size))]
        public byte[] ShadowFieldValues;
    }
}