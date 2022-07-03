using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.AreaVisualData.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 21, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 21, 3)]
    public partial class ParticleEffectsView
    {
        [AeroNullable] private ParticleEffect ParticleEffects_0;
        [AeroNullable] private ParticleEffect ParticleEffects_1;
        [AeroNullable] private ParticleEffect ParticleEffects_2;
        [AeroNullable] private ParticleEffect ParticleEffects_3;
        [AeroNullable] private ParticleEffect ParticleEffects_4;
        [AeroNullable] private ParticleEffect ParticleEffects_5;
        [AeroNullable] private ParticleEffect ParticleEffects_6;
        [AeroNullable] private ParticleEffect ParticleEffects_7;
        [AeroNullable] private ParticleEffect ParticleEffects_8;
        [AeroNullable] private ParticleEffect ParticleEffects_9;
        [AeroNullable] private ParticleEffect ParticleEffects_10;
        [AeroNullable] private ParticleEffect ParticleEffects_11;
        [AeroNullable] private ParticleEffect ParticleEffects_12;
        [AeroNullable] private ParticleEffect ParticleEffects_13;
        [AeroNullable] private ParticleEffect ParticleEffects_14;
        [AeroNullable] private ParticleEffect ParticleEffects_15;
        [AeroNullable] private ParticleEffect ParticleEffects_16;
        [AeroNullable] private ParticleEffect ParticleEffects_17;
        [AeroNullable] private ParticleEffect ParticleEffects_18;
        [AeroNullable] private ParticleEffect ParticleEffects_19;
    }

    [AeroBlock]
    public struct ParticleEffect
    {
        public EntityId SomeEntityId;
        public uint Unk2;
        public Vector3 Position;
        [AeroArray(17)]
        public byte[] Unk3;
    }
}