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
        public HalfVector3 MaybeHalfs; // ???
        public QuantisedVector3 Aim;

        [AeroSdb("dbitems::Ammo", "id")] // Definition
        //[AeroSdb("aptfs::FireProjectileCommandDef", "ammotype")] // Reference values, eg Range
        public ushort AmmoType;
        public float Range;
        public int Unk1;
        public byte Unk2;
        public float Unk3;
        public byte Unk4;
        public uint Unk5;
        public uint Unk6; // Hardpoint?

        public byte UnkFlag;
        [AeroIf(nameof(UnkFlag), 1)]
        public ulong UnkFlaggedEntity;
    }
}