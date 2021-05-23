/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 65
    MsgName: MissionStatusChanged
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class Generic_Event_MissionStatusChanged
    {
        [AeroSDB("clientmissions::Mission","id")]
        [AeroSDB("clientmissions::MissionObjective","mission_id")]
        public uint MissionId;

        [AeroArray(5)]
        public byte[] Unk1;
    }
}