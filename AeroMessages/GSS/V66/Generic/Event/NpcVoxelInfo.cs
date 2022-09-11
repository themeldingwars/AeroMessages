using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 58)]
    public partial class NpcVoxelInfo
    {
        public EntityId Unk1;
        public NpcVoxelInfoData Unk2;
        [AeroArray(typeof(byte))] public uint[] Unk3;
        public byte Unk4;
    }

    [AeroBlock]
    public struct NpcVoxelInfoData
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }
}