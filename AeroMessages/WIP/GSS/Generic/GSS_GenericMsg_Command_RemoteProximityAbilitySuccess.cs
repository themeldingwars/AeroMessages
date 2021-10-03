/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 251
    TypeName: Generic
    MsgId: 21
    MsgName: RemoteProximityAbilitySuccess
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 251, 21)]
    public partial class Generic_Command_RemoteProximityAbilitySuccess
    {
        public EntityId Source;
        public byte Unk;

        [AeroSdb("aptfs::RegisterClientProximityCommandDef", "id")]
        public uint ClientProximityCommandId;

        [AeroArray(typeof(byte))]
        public EntityId[] Targets;

        public uint Time;
    }
}