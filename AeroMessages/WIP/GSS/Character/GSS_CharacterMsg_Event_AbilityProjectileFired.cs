/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 11
    TypeName: Character::CombatView
    MsgId: 96
    MsgName: AbilityProjectileFired
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;

namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_AbilityProjectileFired
    {
        public ushort ShortTime;
        
        [AeroArray(3)]
        public ushort[] PackedUnk; // Could be a ruse, if not, what vector would this be???
        
        public QuantisedVector3 PackedAim; // TODO: Aero needs to unpack this to Vector3

        //[AeroSDB("dbitems::Ammo", "id")] // Definition
        //[AeroSDB("aptfs::FireProjectileCommandDef", "ammotype")] // Reference values, eg Range
        public ushort AmmoType;
        public float Range;

        [AeroArray(14)]
        public byte[] Unk1;

        public ushort Hardpoint;

        [AeroArray(2)]
        public byte[] Unk5;

        public byte UnkFlag;
        [AeroIf(nameof(UnkFlag), 1)]
        public ulong UnkFlaggedEntity;
    }
}