using Aero.Gen.Attributes;
using AeroMessages.Common;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    public partial class LocalProximityAbilitySuccess
    {
        public EntityId   Source;
        public byte       Unk;
        public uint       ClientProximityCommandId;
        [AeroArray(typeof(byte))]
        public EntityId[] AffectedEntitys;
        public uint       Time;
    }
}