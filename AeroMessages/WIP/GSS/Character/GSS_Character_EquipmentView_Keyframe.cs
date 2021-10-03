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
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 9, 3)]
    public partial class Character_EquipmentView_Keyframe
    {
        public VisualOverridesField VisualOverrides;
        public EquipmentData CurrentEquipment;
        public byte Level;
        public byte EffectiveLevel;
        public byte LevelResetCount;
        public byte CurrentDurabilityPct;
        public CharacterStatsData CharacterStats;
        public uint ScalingLevel;
        public uint PvPRank;
        public uint EliteLevel;
    }

    [AeroBlock]
    public struct VisualOverridesField
    {
        public byte HaveData;
        [AeroIf(nameof(HaveData), 1)]
        public VisualOverridesData Data;
    }

    [AeroBlock]
    public struct VisualOverridesData
    {
        public byte UnkByte;
        public uint VisualsGroupId;
    }
}