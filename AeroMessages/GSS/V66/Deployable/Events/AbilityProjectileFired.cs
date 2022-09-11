using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Deployable.Events
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 35, 84)]
    public partial class AbilityProjectileFired
    {
        public ushort ShortTime;
        public HalfVector3 MaybeHalfs; // ???
        public QuantisedVector3 Aim;

        [AeroSdb("dbitems::Ammo", "id")] // Definition
        public ushort AmmoType;
        public float Range;
        public int Unk1;
        public byte Unk2;
        public float Unk3;
        public byte Unk4;
        public uint Unk5;
        public uint Unk6; // Hardpoint?

        public byte HaveUnk7;
        [AeroIf(nameof(HaveUnk7), 1)]
        public ulong Unk7;
    }
}