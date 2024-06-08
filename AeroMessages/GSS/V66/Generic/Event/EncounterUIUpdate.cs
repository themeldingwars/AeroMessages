using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 101)]
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

        [AeroArray(typeof(ushort))] public byte[] BlobData;

        private int _size;

        [AeroArray(nameof(_size))]
        public byte[] ShadowFieldValues;
    }
}