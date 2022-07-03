using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 96)]
    public partial class AbilityProjectileFired
    {
        public ushort ShortTime;
        
        [AeroArray(3)]
        public ushort[] PackedUnk; // Could be a ruse, if not, what vector would this be???
        
        public QuantisedVector3 Aim;

        [AeroSdb("dbitems::Ammo", "id")] // Definition
        //[AeroSdb("aptfs::FireProjectileCommandDef", "ammotype")] // Reference values, eg Range
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