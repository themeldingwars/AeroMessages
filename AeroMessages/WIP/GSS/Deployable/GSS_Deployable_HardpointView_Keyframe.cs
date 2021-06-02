using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.Deployable
{
    [Aero]
    public partial class Deployable_HardpointView_Keyframe
    {
        [AeroSdb("dbcharacter::Deployable", "id")]
        public uint HardpointChildType; // DeployableTypeId Of the selected deployable
        public HardpointChildIDData HardpointChildId;
    }

    [AeroBlock]
    public struct HardpointChildIDData {
        public byte HaveChild;

        [AeroIf(nameof(HaveChild), 1)]
        public EntityId ChildId;
    }
}