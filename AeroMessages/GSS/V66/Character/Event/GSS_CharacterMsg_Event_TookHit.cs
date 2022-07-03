using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 105)]
    public partial class TookHit
    {
        // There are some variations of this message that don't include dealer entity.
        // DealtHit has similiar variations.
        // Maybe for fall dmg or similiar in this case.

        public byte HaveDealerEntity;

        [AeroIf(nameof(HaveDealerEntity), 1)]
        public TookHitType1Data Data1;

        [AeroIf(nameof(HaveDealerEntity), 0)]
        public TookHitType0Data Data0;
        
        // Always
        public ushort ShortTime;
        public byte Unk_Byte;
    }

    [AeroBlock]
    public struct TookHitType1Data
    {
        public EntityId DealerEntity;

        public byte Unk_2_byte;
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
        public byte DamageFlags;
    }

    [AeroBlock]
    public struct TookHitType0Data
    {
        [AeroArray(2)]
        public byte[] Unk;
    }
}