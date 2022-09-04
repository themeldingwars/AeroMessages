using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 54)]
    public partial class NpcNavigationInfo
    {
        public EntityId Unk1;
        [AeroArray(typeof(byte))] public NpcNavigationData1[] Unk2;
        [AeroArray(typeof(byte))] public NpcNavigationData2[] Unk3;
    }

    [AeroBlock]
    public struct NpcNavigationData1
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }

    [AeroBlock]
    public struct NpcNavigationData2
    {
        // Uncertain types, looks like it's actually a lot of floats
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
        public float Unk5;
        public uint Unk6;
        public uint Unk7;
        public uint Unk8;
        public uint Unk9;
        public uint Unk10;
        public byte Unk11;
    }
}