using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Character.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 3)]
    public partial class CombatView
    {
        public ushort StatusEffectsChangeTime_0;
        public ushort StatusEffectsChangeTime_1;
        public ushort StatusEffectsChangeTime_2;
        public ushort StatusEffectsChangeTime_3;
        public ushort StatusEffectsChangeTime_4;
        public ushort StatusEffectsChangeTime_5;
        public ushort StatusEffectsChangeTime_6;
        public ushort StatusEffectsChangeTime_7;
        public ushort StatusEffectsChangeTime_8;
        public ushort StatusEffectsChangeTime_9;
        public ushort StatusEffectsChangeTime_10;
        public ushort StatusEffectsChangeTime_11;
        public ushort StatusEffectsChangeTime_12;
        public ushort StatusEffectsChangeTime_13;
        public ushort StatusEffectsChangeTime_14;
        public ushort StatusEffectsChangeTime_15;
        public ushort StatusEffectsChangeTime_16;
        public ushort StatusEffectsChangeTime_17;
        public ushort StatusEffectsChangeTime_18;
        public ushort StatusEffectsChangeTime_19;
        public ushort StatusEffectsChangeTime_20;
        public ushort StatusEffectsChangeTime_21;
        public ushort StatusEffectsChangeTime_22;
        public ushort StatusEffectsChangeTime_23;
        public ushort StatusEffectsChangeTime_24;
        public ushort StatusEffectsChangeTime_25;
        public ushort StatusEffectsChangeTime_26;
        public ushort StatusEffectsChangeTime_27;
        public ushort StatusEffectsChangeTime_28;
        public ushort StatusEffectsChangeTime_29;
        public ushort StatusEffectsChangeTime_30;
        public ushort StatusEffectsChangeTime_31;

        [AeroNullable] private StatusEffectData StatusEffects_0;
        [AeroNullable] private StatusEffectData StatusEffects_1;
        [AeroNullable] private StatusEffectData StatusEffects_2;
        [AeroNullable] private StatusEffectData StatusEffects_3;
        [AeroNullable] private StatusEffectData StatusEffects_4;
        [AeroNullable] private StatusEffectData StatusEffects_5;
        [AeroNullable] private StatusEffectData StatusEffects_6;
        [AeroNullable] private StatusEffectData StatusEffects_7;
        [AeroNullable] private StatusEffectData StatusEffects_8;
        [AeroNullable] private StatusEffectData StatusEffects_9;
        [AeroNullable] private StatusEffectData StatusEffects_10;
        [AeroNullable] private StatusEffectData StatusEffects_11;
        [AeroNullable] private StatusEffectData StatusEffects_12;
        [AeroNullable] private StatusEffectData StatusEffects_13;
        [AeroNullable] private StatusEffectData StatusEffects_14;
        [AeroNullable] private StatusEffectData StatusEffects_15;
        [AeroNullable] private StatusEffectData StatusEffects_16;
        [AeroNullable] private StatusEffectData StatusEffects_17;
        [AeroNullable] private StatusEffectData StatusEffects_18;
        [AeroNullable] private StatusEffectData StatusEffects_19;
        [AeroNullable] private StatusEffectData StatusEffects_20;
        [AeroNullable] private StatusEffectData StatusEffects_21;
        [AeroNullable] private StatusEffectData StatusEffects_22;
        [AeroNullable] private StatusEffectData StatusEffects_23;
        [AeroNullable] private StatusEffectData StatusEffects_24;
        [AeroNullable] private StatusEffectData StatusEffects_25;
        [AeroNullable] private StatusEffectData StatusEffects_26;
        [AeroNullable] private StatusEffectData StatusEffects_27;
        [AeroNullable] private StatusEffectData StatusEffects_28;
        [AeroNullable] private StatusEffectData StatusEffects_29;
        [AeroNullable] private StatusEffectData StatusEffects_30;
        [AeroNullable] private StatusEffectData StatusEffects_31;

        private FireModeData FireMode_0;
        private FireModeData FireMode_1;

        private ushort Ammo_0;
        private ushort Ammo_1;
        private ushort AltAmmo_0;
        private ushort AltAmmo_1;
        private WeaponIndexData WeaponIndex;
        private uint ClipEmptyBegin;
        private uint ClipEmptyEnd;
        private uint WeaponBurstFired;
        private uint WeaponBurstEnded;
        private uint WeaponBurstCancelled;
        private uint WeaponReloaded;
        private uint WeaponReloadCancelled;
        private float WeaponAgilityMod;
        private uint AbilityCooldownEndMs_0;
        private uint AbilityCooldownEndMs_1;
        private uint AbilityCooldownEndMs_2;
        private uint AbilityCooldownEndMs_3;
        private uint EquipmentLoadTime;
        private CombatFlagsData CombatFlags;

        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_0;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_1;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_2;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_3;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_4;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_5;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_6;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_7;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_8;
        [AeroNullable] private AppendageHealthPoolData AppendageHealthPools_9;

        private byte AppendageHealthPct_0;
        private byte AppendageHealthPct_1;
        private byte AppendageHealthPct_2;
        private byte AppendageHealthPct_3;
        private byte AppendageHealthPct_4;
        private byte AppendageHealthPct_5;
        private byte AppendageHealthPct_6;
        private byte AppendageHealthPct_7;
        private byte AppendageHealthPct_8;
        private byte AppendageHealthPct_9;

        [AeroNullable] private EntityId NPCTargetObjId;
        [AeroNullable] private BattleChatterTagData BattleChatterTag;

        private EntityId MimicParent;
        private Vector3 MimicOffset;
    }

    [AeroBlock]
    public struct BattleChatterTagData
    {
        [AeroArray(2)] public byte[] Tag; // Fixme: String?
    }
}