using Aero.Gen.Attributes;
using AeroMessages.Common;
using System;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 107)]
    public partial class DealtHit
    {
        public byte HaveDamageData;
        [AeroIf(nameof(HaveDamageData), 1)]
        public HitDamageData Data;

        public byte Unk;

        [Flags]
        public enum DamageResponseFlags : byte
        {
            Critical  = 1 << 0,
            Unk       = 1 << 1,
            Effective = 1 << 2,
            Resisted  = 1 << 3,
            Immune    = 12, // (Effective+Resisted => Immune)
        }
        public DamageResponseFlags DamageFlags;
    }

    [AeroBlock]
    public struct HitDamageData
    {
        public EntityId TargetEntity;

        public byte HaveDealerEntity;
        [AeroIf(nameof(HaveDealerEntity), 1)]
        public EntityId DealerEntity;

        public uint DamageValue;

        [AeroSdb("dbcharacter::DamageType", "id")]
        public byte DamageType;
    }
}