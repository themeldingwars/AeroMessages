/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 9
    TypeName: Character::EquipmentView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_EquipmentView_Keyframe
    {
        public byte VisualOverrides_HaveData;
        [AeroIf(nameof(VisualOverrides_HaveData), 1)]
        public VisualOverridesData VisualOverrides;

        public EquipmentData CurrentEquipment;
        public byte Level;
        public byte EffectiveLevel;
        public byte LevelResetCount;
        public byte CurrentDurabilityPct;
        public CharacterStatsData CharacterStats;
        public uint ScalingLevel;
        public uint PvP_Rank;
        public uint Elite_Rank;
    }

    [AeroBlock]
    public struct VisualOverridesData
    {
        public byte UnkByte;
        public uint VisualsGroupId;
    }
}