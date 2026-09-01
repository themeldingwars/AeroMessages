using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.LocalProximityAbilitySuccess, GssVersion.V1, GssVersion.V67)]
    public partial class LocalProximityAbilitySuccess
    {
        public EntityId Source;
        public sbyte Unk;

        [AeroSdb("aptfs::RegisterClientProximityCommandDef", "id")]
        public uint ClientProximityCommandId;

        [AeroArray(typeof(byte))]
        public EntityId[] Targets;

        public uint Time;
    }
}