using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 56)]
    public partial class NpcPositionalDebugInfo
    {
        public EntityId Unk1;
        [AeroString] public string Unk2;
        [AeroArray(typeof(byte))] public NpcPositionalDebugInfoData[] Unk3;
        public byte Unk4;
    }

    [AeroBlock]
    public struct NpcPositionalDebugInfoData
    {
        public ulong Unk1;
        public float Unk2;
        public float Unk3;
        public float Unk4;
        public float Unk5;
        public float Unk6;
        public float Unk7;
        public float Unk8;
        public float Unk9;
    }
}