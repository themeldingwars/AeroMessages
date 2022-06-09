using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 100)]
    public partial class Generic_Event_EncounterUIScopeIn
    {
        public EntityId EncounterId;

        [AeroArray(typeof(ushort))]
        public byte[] TextData; // Text keys with values inbetween or?

        //[AeroArray(-1)]
        //public byte[] Unk;
    }
}