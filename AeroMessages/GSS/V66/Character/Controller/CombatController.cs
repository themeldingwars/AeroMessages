using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Character.Controller
{
    [Aero(AeroGenTypes.Controller)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 4)]
    public partial class CombatController
    {
        private ushort StatusEffectsChangeTime_0;
        private ushort StatusEffectsChangeTime_1;
        private ushort StatusEffectsChangeTime_2;
        private ushort StatusEffectsChangeTime_3;
        private ushort StatusEffectsChangeTime_4;
        private ushort StatusEffectsChangeTime_5;
        private ushort StatusEffectsChangeTime_6;
        private ushort StatusEffectsChangeTime_7;
        private ushort StatusEffectsChangeTime_8;
        private ushort StatusEffectsChangeTime_9;
        private ushort StatusEffectsChangeTime_10;
        private ushort StatusEffectsChangeTime_11;
        private ushort StatusEffectsChangeTime_12;
        private ushort StatusEffectsChangeTime_13;
        private ushort StatusEffectsChangeTime_14;
        private ushort StatusEffectsChangeTime_15;
        private ushort StatusEffectsChangeTime_16;
        private ushort StatusEffectsChangeTime_17;
        private ushort StatusEffectsChangeTime_18;
        private ushort StatusEffectsChangeTime_19;
        private ushort StatusEffectsChangeTime_20;
        private ushort StatusEffectsChangeTime_21;
        private ushort StatusEffectsChangeTime_22;
        private ushort StatusEffectsChangeTime_23;
        private ushort StatusEffectsChangeTime_24;
        private ushort StatusEffectsChangeTime_25;
        private ushort StatusEffectsChangeTime_26;
        private ushort StatusEffectsChangeTime_27;
        private ushort StatusEffectsChangeTime_28;
        private ushort StatusEffectsChangeTime_29;
        private ushort StatusEffectsChangeTime_30;
        private ushort StatusEffectsChangeTime_31;

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


        private StatMultiplierData RunSpeedMult;
        private StatMultiplierData FwdRunSpeedMult;
        private StatMultiplierData JumpHeightMult;
        private StatMultiplierData AirControlMult;
        private StatMultiplierData ThrustStrengthMult;
        private StatMultiplierData ThrustAirControl;
        private StatMultiplierData Friction;
        private StatMultiplierData AmmoConsumption;
        private StatMultiplierData MaxTurnRate;
        private StatMultiplierData TurnSpeed;
        private StatMultiplierData TimeDilation;
        private StatMultiplierData FireRateModifier;
        private StatMultiplierData AccuracyModifier;
        private StatMultiplierData GravityMult;
        private StatMultiplierData AirResistanceMult;
        private StatMultiplierData WeaponChargeupMod;
        private StatMultiplierData WeaponDamageDealtMod;

        private FireModeData FireMode_0;
        private FireModeData FireMode_1;

        private ushort Clip_0;
        private ushort Clip_1;
        private ushort AltClip_0;
        private ushort AltClip_1;
        private ushort Ammo_0;
        private ushort Ammo_1;
        private ushort AltAmmo_0;
        private ushort AltAmmo_1;

        private WeaponIndexData WeaponIndex;
        private WeaponFireBaseTimeData WeaponFireBaseTime;
        private float WeaponAgilityMod;
        private CombatFlagsData CombatFlags;
        private PermissionFlagsData PermissionFlags;
        private uint GliderProfileId;
        private uint HoverProfileId;
        private uint CombatTimer_0;
        private byte CombatTimer_1;

        private NemesesData Nemeses;

        private SuperChargeData SuperCharge;
        private byte NoSpreadFlags;

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
    }



    [AeroBlock]
    public struct StatMultiplierData
    {
        public float Value;
        public uint Time;
    }

    [AeroBlock]
    public struct PermissionFlagsData
    {
        [Flags]
        public enum CharacterPermissionFlags : ulong
        {
            movement = 1U << 0,
            sprint = 1U << 1,
            jump = 1U << 2,
            interact = 1U << 3,
            weapon = 1U << 4,
            melee = 1U << 5,
            abilities = 1U << 6,
            flashlight = 1U << 7,
            unk_8 = 1U << 8,
            cheat_jump_midair = 1U << 9,
            glider = 1U << 10,
            unk_11 = 1U << 11,
            jetpack = 1U << 12,
            map = 1U << 13,
            unk_14 = 1U << 14, // Some relation to flashlight permission, seems to affect a base value (if we have permission then it becomes 1.0, otherwise 0)
            spectate_input = 1U << 15, // Spectate button can be pressed while Dead (Jump) (needs testing)
            new_character = 1U << 16,
            glider_hud = 1U << 17,
            crouch = 1U << 18,
            cheat_float = 1U << 19,
            detect_resources = 1U << 20,
            unk_21 = 1U << 21,
            calldown_abilities = 1U << 22,
            unk_23 = 1U << 23,
            emotes = 1U << 24,
            unk_25 = 1U << 25,
            unk_26 = 1U << 26,
            self_revive = 1U << 27,
            respawn_input = 1U << 28, // Respawn button can be pressed while Dead (Reload)
            free_repairs = 1U << 29,
            battleframe_abilities = 1U << 30,
            unk_31 = 1U << 31, // Something returns false early if we dont have it - related to combat.timeout cvar, text "In combat, aggros" displayed where?
            // another 32 bits
        }

        public CharacterPermissionFlags Value;
        public uint Time;
    }

    [AeroBlock]
    public struct SuperChargeData
    {
        public HalfFloat Value;
        public byte Op; // Probably?
    }

    [AeroBlock]
    public struct NemesesData
    {
        [AeroArray(typeof(byte))] public ulong[] Values;
    }
}