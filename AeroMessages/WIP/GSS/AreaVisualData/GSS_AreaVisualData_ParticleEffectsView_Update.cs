/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 21
    TypeName: AreaVisualData::ParticleEffectsView
    MsgId: 1
    MsgName: Update
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.AreaVisualData
{
    [AeroBlock]
    public struct AreaVisualData_ParticleEffectsView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            ParticleEffects_0 = 0x00,
            ParticleEffects_1 = 0x01,
            ParticleEffects_2 = 0x02,
            ParticleEffects_3 = 0x03,
            ParticleEffects_4 = 0x04,
            ParticleEffects_5 = 0x05,
            ParticleEffects_6 = 0x06,
            ParticleEffects_7 = 0x07,
            ParticleEffects_8 = 0x08,
            ParticleEffects_9 = 0x09,
            ParticleEffects_10 = 0x0a,
            ParticleEffects_11 = 0x0b,
            ParticleEffects_12 = 0x0c,
            ParticleEffects_13 = 0x0d,
            ParticleEffects_14 = 0x0e,
            ParticleEffects_15 = 0x0f,
            ParticleEffects_16 = 0x10,
            ParticleEffects_17 = 0x11,
            ParticleEffects_18 = 0x12,
            ParticleEffects_19 = 0x13,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_0)]
        public ParticleEffect ParticleEffects_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_1)]
        public ParticleEffect ParticleEffects_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_2)]
        public ParticleEffect ParticleEffects_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_3)]
        public ParticleEffect ParticleEffects_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_4)]
        public ParticleEffect ParticleEffects_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_5)]
        public ParticleEffect ParticleEffects_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_6)]
        public ParticleEffect ParticleEffects_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_7)]
        public ParticleEffect ParticleEffects_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_8)]
        public ParticleEffect ParticleEffects_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_9)]
        public ParticleEffect ParticleEffects_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_10)]
        public ParticleEffect ParticleEffects_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_11)]
        public ParticleEffect ParticleEffects_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_12)]
        public ParticleEffect ParticleEffects_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_13)]
        public ParticleEffect ParticleEffects_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_14)]
        public ParticleEffect ParticleEffects_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_15)]
        public ParticleEffect ParticleEffects_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_16)]
        public ParticleEffect ParticleEffects_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_17)]
        public ParticleEffect ParticleEffects_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_18)]
        public ParticleEffect ParticleEffects_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ParticleEffects_19)]
        public ParticleEffect ParticleEffects_19;
    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 21, 1)]
    public partial class AreaVisualData_ParticleEffectsView_Update
    {
        [AeroArray(-60)]
        public AreaVisualData_ParticleEffectsView_ShadowFieldUpdate[] Updates;    
    }
}