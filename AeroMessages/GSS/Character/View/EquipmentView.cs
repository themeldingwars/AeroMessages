using Aero.Gen.Attributes;
using Aero.Protocol;
using Aero.Gen;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.View
{
    [Aero(AeroGenTypes.View)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterView.EquipmentView, GssVersion.V1, GssVersion.V74)]
    public partial class EquipmentView
    {
        private VisualOverridesField VisualOverrides;
        private EquipmentData CurrentEquipment;
        private byte Level;
        private byte EffectiveLevel;
        private byte LevelResetCount;
        private byte CurrentDurabilityPct;
        private CharacterStatsData CharacterStats;
        private uint ScalingLevel;
        private uint PvPRank;
        private uint EliteLevel;
    }
}