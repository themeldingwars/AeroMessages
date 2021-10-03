/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 101
    MsgName: EncounterUIUpdate
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 101)]
    public partial class Generic_Event_EncounterUIUpdate
    {
        public EntityId EncounterId;

        //[AeroArray(-1)]
        //public byte[] Unk;
    }
}