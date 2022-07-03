using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
using Aero.Gen;

namespace AeroMessages.GSS.V66.Vehicle.Controller
{
    [Aero(AeroGenTypes.Controller)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 4)]
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

        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_0;
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_1;
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_2;
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_3;
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_4;
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_5;
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_6;
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_7;
        [AeroSdb("apt::AbilityData", "id")]
        public uint SlottedAbility_8;
    }
}