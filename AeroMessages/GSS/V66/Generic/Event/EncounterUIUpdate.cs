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

        //[AeroArray(-1)]
        //public byte[] Unk;
    }
}