using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 57)]
    public partial class NpcShapeDebugInfo
    {
        public EntityId Unk1; // Primary key
        [AeroString] public string Unk2; // Secondary key
        [AeroArray(typeof(byte))] public NpcShapeDebugInfoData[] Unk3;
    }

    [AeroBlock]
    public struct NpcShapeDebugInfoData
    {
        public byte Unk1;
        [AeroArray(4)] public Vector4[] Unk2; // Assumed float / 4x4 matrix
        public Vector4 Unk3; // Assumed float
        public byte Unk4;
    }
}