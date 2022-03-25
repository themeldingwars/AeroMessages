using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.ResourceNode
{
    // TODO: Need a capture or replay of these, this is mostly guesswork based on shadowfields and what the client seems to like.
    [Aero(true)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 48, 1)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 48, 3)]
    public partial class ResourceNode_ObserverView
    {
        [AeroSdb("dbzonemetadata::ResourceNodeType", "id")] // TODO: Verify
        private uint NodeType;

        private ThumpingCharacterInfoStruct ThumpingCharacterInfo;
        private Vector3 Position;

        [AeroSdb("dbitems::ResourceNodeBeacon", "id")]
        private uint BeaconId;
        private byte CurrentHealthPct;
        private uint MaxHealth;
        private float Progress;
        private StateInfoStruct StateInfo;

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

        [AeroNullable] public StatusEffectData StatusEffects_0;
        [AeroNullable] public StatusEffectData StatusEffects_1;
        [AeroNullable] public StatusEffectData StatusEffects_2;
        [AeroNullable] public StatusEffectData StatusEffects_3;
        [AeroNullable] public StatusEffectData StatusEffects_4;
        [AeroNullable] public StatusEffectData StatusEffects_5;
        [AeroNullable] public StatusEffectData StatusEffects_6;
        [AeroNullable] public StatusEffectData StatusEffects_7;
        [AeroNullable] public StatusEffectData StatusEffects_8;
        [AeroNullable] public StatusEffectData StatusEffects_9;
        [AeroNullable] public StatusEffectData StatusEffects_10;
        [AeroNullable] public StatusEffectData StatusEffects_11;
        [AeroNullable] public StatusEffectData StatusEffects_12;
        [AeroNullable] public StatusEffectData StatusEffects_13;
        [AeroNullable] public StatusEffectData StatusEffects_14;
        [AeroNullable] public StatusEffectData StatusEffects_15;
        [AeroNullable] public StatusEffectData StatusEffects_16;
        [AeroNullable] public StatusEffectData StatusEffects_17;
        [AeroNullable] public StatusEffectData StatusEffects_18;
        [AeroNullable] public StatusEffectData StatusEffects_19;
        [AeroNullable] public StatusEffectData StatusEffects_20;
        [AeroNullable] public StatusEffectData StatusEffects_21;
        [AeroNullable] public StatusEffectData StatusEffects_22;
        [AeroNullable] public StatusEffectData StatusEffects_23;
        [AeroNullable] public StatusEffectData StatusEffects_24;
        [AeroNullable] public StatusEffectData StatusEffects_25;
        [AeroNullable] public StatusEffectData StatusEffects_26;
        [AeroNullable] public StatusEffectData StatusEffects_27;
        [AeroNullable] public StatusEffectData StatusEffects_28;
        [AeroNullable] public StatusEffectData StatusEffects_29;
        [AeroNullable] public StatusEffectData StatusEffects_30;
        [AeroNullable] public StatusEffectData StatusEffects_31;

        private HostilityInfoData HostilityInfo;

        [AeroNullable] public PersonalFactionStanceData PersonalFactionStance;

        private ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [AeroBlock]
    public struct ThumpingCharacterInfoStruct
    {
        public EntityId OwnerId1; // total assumption, similar to vehicle
        public EntityId OwnerId2; // total assumption, similar to vehicle

        [AeroString]
        public string Owner;

        public uint UnkMaybeTime;
    }

    [AeroBlock]
    public struct StateInfoStruct
    {
       public byte State;
       public uint Time;
       public uint CountdownTime;
    }
}