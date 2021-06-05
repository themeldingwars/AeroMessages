using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroIfAttribute;
using AeroMessages.Common;
using System.Numerics;
using System;
namespace AeroMessages.GSS.Character
{
    [AeroBlock]
    public struct Character_EquipmentView_ShadowFieldUpdate
    {
        public enum ShadowFieldIndex : byte
        {
            VisualOverrides      = 0x00,
            CurrentEquipment     = 0x01,
            Level                = 0x02,
            EffectiveLevel       = 0x03,
            LevelResetCount      = 0x04,
            CurrentDurabilityPct = 0x05,
            CharacterStats       = 0x06,
            ScalingLevel         = 0x07,
            PvPRank              = 0x08,
            EliteLevel           = 0x09,
        }

        public ShadowFieldIndex Idx;

        [AeroIf(nameof(Idx), ShadowFieldIndex.VisualOverrides)]
        public VisualOverridesField VisualOverrides;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentEquipment)]
        public EquipmentData CurrentEquipment;
        [AeroIf(nameof(Idx), ShadowFieldIndex.Level)]
        public byte Level;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EffectiveLevel)]
        public byte EffectiveLevel;
        [AeroIf(nameof(Idx), ShadowFieldIndex.LevelResetCount)]
        public byte LevelResetCount;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CurrentDurabilityPct)]
        public byte CurrentDurabilityPct;
        [AeroIf(nameof(Idx), ShadowFieldIndex.CharacterStats)]
        public CharacterStatsData CharacterStats;
        [AeroIf(nameof(Idx), ShadowFieldIndex.ScalingLevel)]
        public uint ScalingLevel;
        [AeroIf(nameof(Idx), ShadowFieldIndex.PvPRank)]
        public uint PvPRank;
        [AeroIf(nameof(Idx), ShadowFieldIndex.EliteLevel)]
        public uint EliteLevel;
    }

    [Aero]
    public partial class Character_EquipmentView_Update
    {
        [AeroArray(-20)]
        public Character_EquipmentView_ShadowFieldUpdate[] Updates;
    }
}