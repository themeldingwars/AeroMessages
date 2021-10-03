using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.ResourceNode
{
    [AeroBlock]
    public struct ResourceNode_ObserverView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            NodeType                    = 0x00,
            ThumpingCharacterInfo       = 0x01,
            Position                    = 0x02,
            BeaconId                    = 0x03,
            CurrentHealthPct            = 0x04,
            MaxHealth                   = 0x05,
            Progress                    = 0x06,
            StateInfo                   = 0x07,
            StatusEffectsChangeTime_0   = 0x08,
            StatusEffectsChangeTime_1   = 0x09,
            StatusEffectsChangeTime_2   = 0x0a,
            StatusEffectsChangeTime_3   = 0x0b,
            StatusEffectsChangeTime_4   = 0x0c,
            StatusEffectsChangeTime_5   = 0x0d,
            StatusEffectsChangeTime_6   = 0x0e,
            StatusEffectsChangeTime_7   = 0x0f,
            StatusEffectsChangeTime_8   = 0x10,
            StatusEffectsChangeTime_9   = 0x11,
            StatusEffectsChangeTime_10  = 0x12,
            StatusEffectsChangeTime_11  = 0x13,
            StatusEffectsChangeTime_12  = 0x14,
            StatusEffectsChangeTime_13  = 0x15,
            StatusEffectsChangeTime_14  = 0x16,
            StatusEffectsChangeTime_15  = 0x17,
            StatusEffectsChangeTime_16  = 0x18,
            StatusEffectsChangeTime_17  = 0x19,
            StatusEffectsChangeTime_18  = 0x1a,
            StatusEffectsChangeTime_19  = 0x1b,
            StatusEffectsChangeTime_20  = 0x1c,
            StatusEffectsChangeTime_21  = 0x1d,
            StatusEffectsChangeTime_22  = 0x1e,
            StatusEffectsChangeTime_23  = 0x1f,
            StatusEffectsChangeTime_24  = 0x20,
            StatusEffectsChangeTime_25  = 0x21,
            StatusEffectsChangeTime_26  = 0x22,
            StatusEffectsChangeTime_27  = 0x23,
            StatusEffectsChangeTime_28  = 0x24,
            StatusEffectsChangeTime_29  = 0x25,
            StatusEffectsChangeTime_30  = 0x26,
            StatusEffectsChangeTime_31  = 0x27,
            StatusEffects_0             = 0x28,
            StatusEffects_1             = 0x29,
            StatusEffects_2             = 0x2a,
            StatusEffects_3             = 0x2b,
            StatusEffects_4             = 0x2c,
            StatusEffects_5             = 0x2d,
            StatusEffects_6             = 0x2e,
            StatusEffects_7             = 0x2f,
            StatusEffects_8             = 0x30,
            StatusEffects_9             = 0x31,
            StatusEffects_10            = 0x32,
            StatusEffects_11            = 0x33,
            StatusEffects_12            = 0x34,
            StatusEffects_13            = 0x35,
            StatusEffects_14            = 0x36,
            StatusEffects_15            = 0x37,
            StatusEffects_16            = 0x38,
            StatusEffects_17            = 0x39,
            StatusEffects_18            = 0x3a,
            StatusEffects_19            = 0x3b,
            StatusEffects_20            = 0x3c,
            StatusEffects_21            = 0x3d,
            StatusEffects_22            = 0x3e,
            StatusEffects_23            = 0x3f,
            StatusEffects_24            = 0x40,
            StatusEffects_25            = 0x41,
            StatusEffects_26            = 0x42,
            StatusEffects_27            = 0x43,
            StatusEffects_28            = 0x44,
            StatusEffects_29            = 0x45,
            StatusEffects_30            = 0x46,
            StatusEffects_31            = 0x47,
            HostilityInfo               = 0x48,
            PersonalFactionStance       = 0x49,
            ScopeBubbleInfo             = 0x4a,
        }

        public ShadowFieldIndex Idx;

    
        [AeroIf(nameof(Idx), ShadowFieldIndex.NodeType)]
        [AeroSdb("dbzonemetadata::ResourceNodeType", "id")] // TODO: Verify
        public uint NodeType;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ThumpingCharacterInfo)]
        public ThumpingCharacterInfoStruct ThumpingCharacterInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Position)]
        public Vector3 Position;
        [AeroSdb("dbitems::ResourceNodeBeacon", "id")]
        [AeroIf(nameof(Idx), ShadowFieldIndex.BeaconId)]
        public uint BeaconId;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentHealthPct)]
        public byte CurrentHealthPct;
        [AeroIf(nameof(Idx), ShadowFieldIndex.MaxHealth)]
        public uint MaxHealth;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Progress)]
        public float Progress;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StateInfo)]
        public StateInfoStruct StateInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_0)]
        public ushort StatusEffectsChangeTime_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_1)]
        public ushort StatusEffectsChangeTime_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_2)]
        public ushort StatusEffectsChangeTime_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_3)]
        public ushort StatusEffectsChangeTime_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_4)]
        public ushort StatusEffectsChangeTime_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_5)]
        public ushort StatusEffectsChangeTime_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_6)]
        public ushort StatusEffectsChangeTime_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_7)]
        public ushort StatusEffectsChangeTime_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_8)]
        public ushort StatusEffectsChangeTime_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_9)]
        public ushort StatusEffectsChangeTime_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_10)]
        public ushort StatusEffectsChangeTime_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_11)]
        public ushort StatusEffectsChangeTime_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_12)]
        public ushort StatusEffectsChangeTime_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_13)]
        public ushort StatusEffectsChangeTime_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_14)]
        public ushort StatusEffectsChangeTime_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_15)]
        public ushort StatusEffectsChangeTime_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_16)]
        public ushort StatusEffectsChangeTime_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_17)]
        public ushort StatusEffectsChangeTime_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_18)]
        public ushort StatusEffectsChangeTime_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_19)]
        public ushort StatusEffectsChangeTime_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_20)]
        public ushort StatusEffectsChangeTime_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_21)]
        public ushort StatusEffectsChangeTime_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_22)]
        public ushort StatusEffectsChangeTime_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_23)]
        public ushort StatusEffectsChangeTime_23;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_24)]
        public ushort StatusEffectsChangeTime_24;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_25)]
        public ushort StatusEffectsChangeTime_25;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_26)]
        public ushort StatusEffectsChangeTime_26;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_27)]
        public ushort StatusEffectsChangeTime_27;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_28)]
        public ushort StatusEffectsChangeTime_28;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_29)]
        public ushort StatusEffectsChangeTime_29;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_30)]
        public ushort StatusEffectsChangeTime_30;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffectsChangeTime_31)]
        public ushort StatusEffectsChangeTime_31;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_0)]
        public StatusEffectData StatusEffects_0;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_1)]
        public StatusEffectData StatusEffects_1;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_2)]
        public StatusEffectData StatusEffects_2;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_3)]
        public StatusEffectData StatusEffects_3;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_4)]
        public StatusEffectData StatusEffects_4;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_5)]
        public StatusEffectData StatusEffects_5;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_6)]
        public StatusEffectData StatusEffects_6;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_7)]
        public StatusEffectData StatusEffects_7;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_8)]
        public StatusEffectData StatusEffects_8;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_9)]
        public StatusEffectData StatusEffects_9;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_10)]
        public StatusEffectData StatusEffects_10;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_11)]
        public StatusEffectData StatusEffects_11;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_12)]
        public StatusEffectData StatusEffects_12;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_13)]
        public StatusEffectData StatusEffects_13;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_14)]
        public StatusEffectData StatusEffects_14;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_15)]
        public StatusEffectData StatusEffects_15;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_16)]
        public StatusEffectData StatusEffects_16;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_17)]
        public StatusEffectData StatusEffects_17;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_18)]
        public StatusEffectData StatusEffects_18;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_19)]
        public StatusEffectData StatusEffects_19;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_20)]
        public StatusEffectData StatusEffects_20;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_21)]
        public StatusEffectData StatusEffects_21;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_22)]
        public StatusEffectData StatusEffects_22;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_23)]
        public StatusEffectData StatusEffects_23;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_24)]
        public StatusEffectData StatusEffects_24;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_25)]
        public StatusEffectData StatusEffects_25;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_26)]
        public StatusEffectData StatusEffects_26;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_27)]
        public StatusEffectData StatusEffects_27;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_28)]
        public StatusEffectData StatusEffects_28;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_29)]
        public StatusEffectData StatusEffects_29;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_30)]
        public StatusEffectData StatusEffects_30;
        [AeroIf(nameof(Idx), ShadowFieldIndex.StatusEffects_31)]
        public StatusEffectData StatusEffects_31;
        [AeroIf(nameof(Idx), ShadowFieldIndex.HostilityInfo)]
        public HostilityInfoData HostilityInfo;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PersonalFactionStance)]
        public PersonalFactionStanceData PersonalFactionStance;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScopeBubbleInfo)]
        public ScopeBubbleInfoData ScopeBubbleInfo;
    }

    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 48, 1)]
    public partial class ResourceNode_ObserverView_Update
    {
        [AeroArray(-148)]
        public ResourceNode_ObserverView_ShadowFieldUpdate[] Updates;
    }
}