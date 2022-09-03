using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 137)]
    public partial class ResourceNodeCompletedEvent
    {
        public ulong Unk1;
        public ulong Unk2;
        public ulong Unk3;
        [AeroString] public string Unk4;
        public float Unk5;
        public float Unk6;
        public byte Unk7;
        public uint Unk8;
        public byte Unk9;
        public uint Unk10;
        [AeroArray(typeof(byte))] public ResourceNodeCompletedInnerData[] Unk11;
    }

    [AeroBlock]
    public struct ResourceNodeCompletedInnerData
    {
        // FUN_009df150
        public uint Unk1;
        public ushort Unk2;
        public uint Unk3;
    }
}