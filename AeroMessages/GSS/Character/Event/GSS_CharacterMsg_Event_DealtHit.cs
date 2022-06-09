using Aero.Gen.Attributes;
using AeroMessages.Common;
using System;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 107)]
    public partial class Character_Event_DealtHit
    {
        public byte UnknownFlag;

        [AeroIf(nameof(UnknownFlag), 0)]
        public Variation0 Type0;

        [AeroIf(nameof(UnknownFlag), 1)]
        public Variation1 Type1;
        
    }

    [AeroBlock]
    public struct Variation0
    {
        public byte Unk1;
        public byte Unk2;
    }

    [AeroBlock]
    public struct Variation1
    {
        [Flags]
        public enum DamageResponseFlags : byte
        {
            Critical  = 1 << 0,
            Unk       = 1 << 1,
            Effective = 1 << 2,
            Resisted  = 1 << 3,
            Immune    = 12,
        }

        public EntityId TargetEntity;

        public byte HaveDealerEntity;
        [AeroIf(nameof(HaveDealerEntity), 1)]
        public EntityId DealerEntity;

        public uint DamageValue;

        [AeroSdb("dbcharacter::DamageType", "id")]
        public byte DamageType;

        public byte Unk_3_byte;

        // Damage Response Flags
        // 1 - Critical
        // 2 - ???
        // 4 - Effective
        // 8 - Resisted
        // (Effective+Resisted => Immune)
        public DamageResponseFlags DamageFlags;
    }
}