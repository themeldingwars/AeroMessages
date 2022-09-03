using Aero.Gen.Attributes;
using AeroMessages.Common;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 86)] // TookDebugWeaponHit
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 85)] // TookDebugWeaponHitPublic
    public partial class TookDebugWeaponHit // TookDebugWeaponHitPublic has the same parser
    {   
        public byte Unk1;
        public uint Unk2;
        public uint Unk3;
        public ushort Unk4;
        public Vector3 Unk5;
        public Vector3 Unk6;
        public uint Unk7;
        
        public byte HaveUnk8;
        [AeroIf(nameof(HaveUnk8), 1)] public TookDebugWeaponHitRelatedData Unk8;

        public byte HaveUnk9;
        [AeroIf(nameof(HaveUnk9), 1)] public TookDebugWeaponHitRelatedData2 Unk9;
    }

    [AeroBlock]
    public struct TookDebugWeaponHitRelatedData
    {
        public ulong Unk1;
        public Vector3 Unk2;
        public Quaternion Unk3;
        public sbyte Unk4;
        public byte Unk5;
    }

    [AeroBlock]
    public struct TookDebugWeaponHitRelatedData2
    {
        // FUN_009f6bb0
        public ulong Unk1;

        // 009f6020
        [AeroArray(typeof(byte))] public MaybeMatrix[] Unk2;
    }

    [AeroBlock]
    public struct MaybeMatrix
    {
        // 00a093e0
        [AeroArray(4)] uint[] Unk;
    }


}