using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.V66.AreaVisualData
{
    [AeroBlock]
    public struct ParticleEffect
    {
        public EntityId PfxEntityId; // Guesswork, following sequentially from the view
        public uint PfxAssetId;
        public Vector3 Position;
        public byte HaveUnk4;
        [AeroIf(nameof(HaveUnk4), 1)] public Vector3 Unk4;
        public QuantisedQuaternion Rotation;
        public byte Unk9; // loop?
        public uint Unk10; // group? time?
        public HalfFloat Scale;
        public byte HaveUnk12;
        [AeroIf(nameof(HaveUnk12), 1)] public ParticleEffectUnkData Unk12;
    }
    
    [AeroBlock]
    public struct ParticleEffectUnkData
    {
        public uint Unk1;
        public uint Unk2;
    }
}