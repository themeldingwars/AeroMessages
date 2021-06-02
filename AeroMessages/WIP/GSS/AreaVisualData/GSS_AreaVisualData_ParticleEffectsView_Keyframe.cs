/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 21
    TypeName: AreaVisualData::MapMarkerView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.AreaVisualData
{
    [Aero]
    public partial class AreaVisualData_ParticleEffectsView_Keyframe
    {
        [Flags]
        public enum BitfieldMask1: ushort
        {
            ParticleEffects_0  = 1 << 0,
            ParticleEffects_1  = 1 << 1,
            ParticleEffects_2  = 1 << 2,
            ParticleEffects_3  = 1 << 3,
            ParticleEffects_4  = 1 << 4,
            ParticleEffects_5  = 1 << 5,
            ParticleEffects_6  = 1 << 6,
            ParticleEffects_7  = 1 << 7,
            ParticleEffects_8  = 1 << 8,
            ParticleEffects_9  = 1 << 9,
            ParticleEffects_10 = 1 << 10,
            ParticleEffects_11 = 1 << 11,
            ParticleEffects_12 = 1 << 12,
            ParticleEffects_13 = 1 << 13,
            ParticleEffects_14 = 1 << 14,
            ParticleEffects_15 = 1 << 15,
        }

        [Flags]
        public enum BitfieldMask2: byte
        {
            ParticleEffects_16 = 1 << 0,
            ParticleEffects_17 = 1 << 1,
            ParticleEffects_18 = 1 << 2,
            ParticleEffects_19 = 1 << 3,
        }

        public BitfieldMask1 Bitfield1;
        public BitfieldMask2 Bitfield2;

        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_0)]
        public ParticleEffect ParticleEffects_0;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_1)]
        public ParticleEffect ParticleEffects_1;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_2)]
        public ParticleEffect ParticleEffects_2;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_3)]
        public ParticleEffect ParticleEffects_3;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_4)]
        public ParticleEffect ParticleEffects_4;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_5)]
        public ParticleEffect ParticleEffects_5;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_6)]
        public ParticleEffect ParticleEffects_6;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_7)]
        public ParticleEffect ParticleEffects_7;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_8)]
        public ParticleEffect ParticleEffects_8;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_9)]
        public ParticleEffect ParticleEffects_9;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_10)]
        public ParticleEffect ParticleEffects_10;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_11)]
        public ParticleEffect ParticleEffects_11;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_12)]
        public ParticleEffect ParticleEffects_12;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_13)]
        public ParticleEffect ParticleEffects_13;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_14)]
        public ParticleEffect ParticleEffects_14;
        [AeroIf(nameof(Bitfield1), Ops.DoesntHaveFlag, BitfieldMask1.ParticleEffects_15)]
        public ParticleEffect ParticleEffects_15;

        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ParticleEffects_16)]
        public ParticleEffect ParticleEffects_16;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ParticleEffects_17)]
        public ParticleEffect ParticleEffects_17;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ParticleEffects_18)]
        public ParticleEffect ParticleEffects_18;
        [AeroIf(nameof(Bitfield2), Ops.DoesntHaveFlag, BitfieldMask2.ParticleEffects_19)]
        public ParticleEffect ParticleEffects_19;
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