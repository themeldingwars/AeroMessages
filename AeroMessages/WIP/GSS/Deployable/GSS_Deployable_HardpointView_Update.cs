using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Deployable
{
    [AeroBlock]
    public struct Deployable_HardpointView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            HardpointChildType = 0x00,
            HardpointChildId = 0x01,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.HardpointChildType)]
        [AeroSdb("dbcharacter::Deployable", "id")]
        public uint HardpointChildType; // DeployableTypeId Of the selected deployable
        
        [AeroIf(nameof(Idx), ShadowFieldIndex.HardpointChildId)]
        public HardpointChildIDData HardpointChildId;
    }

    [Aero]
    public partial class Deployable_HardpointView_Update
    {
        [AeroArray(-4)]
        public Deployable_HardpointView_ShadowFieldUpdate[] Updates;
    }
}