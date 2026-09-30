using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;

namespace AeroMessages.GSS.AreaVisualData
{
    [AeroBlock]
    public struct ParticleEffect
    {
        public EntityId PfxEntityId;
        public uint PfxAssetId;
        public Vector3 Position;
        public byte HaveUnk4;
        [AeroIf(nameof(HaveUnk4), 1)] public Vector3 Unk4;
        public QuantisedQuaternion Rotation;
        public byte Unk9; // loop?
        public uint StartTime; // server time in ms
        public HalfFloat Scale;
        public byte HaveScopeBubbleInfo;
        [AeroIf(nameof(HaveScopeBubbleInfo), 1)] public ScopeBubbleInfoData ScopeBubbleInfo;
    }
}