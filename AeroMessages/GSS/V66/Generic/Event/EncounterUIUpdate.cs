using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 101)]
    public partial class EncounterUIUpdate
    {
        public EntityId EncounterId;
        [AeroArray(typeof(ushort))] public byte[] BlobData;
        [AeroString] public string Unk; // Consume remaining bytes, this is probably json?
    }
}