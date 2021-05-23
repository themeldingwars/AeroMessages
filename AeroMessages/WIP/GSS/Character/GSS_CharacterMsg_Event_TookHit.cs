/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 105
    MsgName: TookHit
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_TookHit
    {
        // There are some variations of this message that don't include dealer entity.
        // DealtHit has similiar variations.
        // Maybe for fall dmg or similiar in this case.

        public byte HaveDealerEntity;

        [AeroIf(nameof(HaveDealerEntity), true)]
        public TookHitType1Data Data1;

        [AeroIf(nameof(HaveDealerEntity), false)]
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

        [AeroSDB("dbcharacter::DamageType", "id")]
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