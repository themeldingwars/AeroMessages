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
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 6, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 6, 4)]
    public partial class LocalEffectsController
    {
        [AeroNullable] private LocalEffectsData LocalStatusEffects_0;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_1;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_2;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_3;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_4;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_5;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_6;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_7;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_8;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_9;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_10;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_11;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_12;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_13;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_14;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_15;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_16;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_17;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_18;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_19;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_20;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_21;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_22;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_23;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_24;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_25;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_26;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_27;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_28;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_29;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_30;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_31;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_32;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_33;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_34;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_35;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_36;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_37;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_38;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_39;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_40;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_41;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_42;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_43;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_44;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_45;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_46;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_47;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_48;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_49;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_50;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_51;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_52;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_53;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_54;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_55;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_56;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_57;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_58;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_59;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_60;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_61;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_62;
        [AeroNullable] private LocalEffectsData LocalStatusEffects_63;
    }

    [AeroBlock]
    public struct LocalEffectsData
    {
        public EntityId Entity;
        public uint Effect;
        public uint Time;
    }
}