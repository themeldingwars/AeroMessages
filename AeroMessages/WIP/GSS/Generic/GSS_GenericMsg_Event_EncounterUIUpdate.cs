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
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_EncounterUIUpdate
    {
        public EntityId EncounterId;

        //[AeroArray(-1)]
        //public byte[] Unk;
    }
}