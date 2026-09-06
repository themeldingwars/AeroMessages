using Aero.Gen.Attributes;
using Aero.Protocol;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.NpcVoxelInfo, GssVersion.V1, GssVersion.V74)]
    public partial class NpcVoxelInfo
    {
        public EntityId Unk1;
        [AeroArray(typeof(byte))] public Vector3[] Unk2;
        [AeroArray(typeof(byte))] public uint[] Unk3;
        public byte Unk4; // 0 seems to clear?
    }
}